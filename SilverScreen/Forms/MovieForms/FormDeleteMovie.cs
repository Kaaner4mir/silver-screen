using DevExpress.XtraEditors;
using SilverScreen.DataAccess;
using SilverScreen.DataAccess.Services;
using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverScreen.Forms
{
    public partial class FormDeleteMovie : Form
    {
        private readonly MovieService _movieService;

        public FormDeleteMovie()
        {
            InitializeComponent();
            _movieService = new MovieService(new SilverScreenContext());
        }

        private void LoadMovies()
        {
            try
            {
                List<Movie> movies = _movieService.GetAll();
                grid_control_movies.DataSource = movies;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FormDeleteMovie_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void grid_control_movies_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow chosenRow = grid_control_movies.CurrentRow;

            int value = Convert.ToInt32(chosenRow.Cells[0].Value);

            DialogResult result = XtraMessageBox.Show("Are you sure you want to delete the selected movie?", "Successful transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _movieService.DeleteMovie(value);
                XtraMessageBox.Show("The movie has been successfully deleted", "Successful transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMovies();
            }
        }
    }
}



