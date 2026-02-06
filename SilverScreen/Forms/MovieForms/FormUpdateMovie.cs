using DevExpress.XtraEditors;
using SilverScreen.DataAccess;
using SilverScreen.Business.Services;
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
    public partial class FormUpdateMovie : Form
    {
        private readonly MovieService _service;
        private readonly SilverScreenContext _context;

        public FormUpdateMovie()
        {
            InitializeComponent();
            _context = new SilverScreenContext();
            _service = new MovieService(_context);
        }

        private async void FormUpdateMovie_Load(object sender, EventArgs e)
        {
            var movies = await _service.GetAllMoviesAsync();

            comboBox_select_movie.DataSource = movies;
            comboBox_select_movie.DisplayMember = "Name";
            comboBox_select_movie.ValueMember = "Id";
        }

        private void comboBox_select_movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_select_movie.SelectedItem == null)
                return;

            Movie chosenMovie = (Movie)comboBox_select_movie.SelectedItem;

            textedit_movie_name.Text = chosenMovie.Name;
            textedit_movie_type.Text = chosenMovie.Type;
            numeric_up_down_duration.Value = chosenMovie.Duration;
            dateEdit_release_time.DateTime = chosenMovie.ReleaseTime;
        }

        private async void button_update_Click(object sender, EventArgs e)
        {
            Movie chosenMovie = (Movie)comboBox_select_movie.SelectedItem;

            if (comboBox_select_movie.SelectedItem != null)
            {
                chosenMovie.Name = textedit_movie_name.Text;
                chosenMovie.Type = textedit_movie_type.Text;
                chosenMovie.Duration = (int)numeric_up_down_duration.Value;
                chosenMovie.ReleaseTime = dateEdit_release_time.DateTime;

                await _service.UpdateMovieAsync(chosenMovie);

                XtraMessageBox.Show("The movie has been successfully updated", "Successful transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
