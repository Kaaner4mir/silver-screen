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

namespace SilverScreen
{
    public partial class FormMovieList : Form
    {
        private readonly MovieService _movieService;

        public FormMovieList()
        {
            InitializeComponent();
            _movieService = new MovieService(new SilverScreenContext());

        }

        private void FormMovieList_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                List<Movie> movies = _movieService.GetAll();
                grid_control_movies.DataSource = movies;
                gridView1.PopulateColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
