using DevExpress.XtraEditors;
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
    public partial class FormAddMovie : Form
    {
        private readonly MovieService _service;

        public FormAddMovie()
        {
            InitializeComponent();
            _service = new MovieService(new DataAccess.SilverScreenContext());
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                var newMovie = new Movie
                {
                    Name = textedit_movie_name.Text,
                    Type = textedit_movie_type.Text,
                    Duration = Convert.ToInt32(numeric_up_down_duration.Value),
                    ReleaseTime = dateEdit_release_time.DateTime,
                    Reservations = new List<Reservation>()
                };

                _service.AddMovie(newMovie);

                XtraMessageBox.Show("The movie has been successfully added", "Successful transaction",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += "\nInner Error: " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                    {
                        message += "\nMore Detail: " + ex.InnerException.InnerException.Message;
                    }
                }
                XtraMessageBox.Show($"Error adding movie: {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
