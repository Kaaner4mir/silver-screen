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

namespace SilverScreen
{
    public partial class FormMovieList : Form
    {
        private readonly MovieService _movieService;
        private readonly SilverScreenContext _context;

        public FormMovieList()
        {
            InitializeComponent();
            _context = new SilverScreenContext();
            _movieService = new MovieService(_context);
        }

        private async void FormMovieList_Load(object sender, EventArgs e)
        {
            await LoadMoviesAsync();
        }

        private async Task LoadMoviesAsync()
        {
            try
            {
                List<Movie> movies = await _movieService.GetAllMoviesAsync();
                grid_control_movies.DataSource = movies;
                gridView1.PopulateColumns();
                
                // Hide navigation properties columns
                if (gridView1.Columns["Showtimes"] != null)
                    gridView1.Columns["Showtimes"].Visible = false;

                // Enable search and filtering
                gridView1.OptionsFind.AlwaysVisible = true;
                gridView1.OptionsView.ShowAutoFilterRow = true;
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
