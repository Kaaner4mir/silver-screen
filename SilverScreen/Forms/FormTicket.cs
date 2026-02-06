using DevExpress.XtraEditors;
using SilverScreen.Entities.Models;
using System;
using System.Windows.Forms;

namespace SilverScreen.Forms
{
    public partial class FormTicket : DevExpress.XtraEditors.XtraForm
    {
        public FormTicket(Showtime showtime, Seat seat)
        {
            InitializeComponent();
            lbl_movie.Text = $"Movie: {showtime.Movie.Name}";
            lbl_hall.Text = $"Hall: {showtime.HallName}";
            lbl_seat.Text = $"Seat: {seat.SeatNumber}";
            lbl_price.Text = $"Price: {showtime.Price:C2}";

            btn_print.Click += (s, e) => DevExpress.XtraEditors.XtraMessageBox.Show("Printing...", "Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
