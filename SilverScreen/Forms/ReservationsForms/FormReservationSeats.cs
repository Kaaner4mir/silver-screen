using SilverScreen.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverScreen.Forms.ReservationsForms
{
    public partial class FormReservationSeats : Form
    {
        public FormReservationSeats()
        {
            InitializeComponent();

            
        }

        private void FormReservationSeats_Load(object sender, EventArgs e)
        {
            flowLayoutPanel_seats.Controls.Clear();

            using (var context = new SilverScreenContext())
            {
                new DatabaseSeeder(context).SeedSeat();

                var seats = context.Seats.ToList();

                foreach (var seat in seats)
                {
                    Button btn = new Button();
                    btn.Text = $"Hall: {seat.HallName}, Seq: {seat.SequenceNumber}, Seat: {seat.SeatNumber}";
                    btn.Width = 150;
                    btn.Height =100;
                    btn.Tag=seat.Id;
                    btn.BackColor = seat.Taken ? Color.Red : Color.Green;
                    btn.ForeColor = Color.White;
                    
                    flowLayoutPanel_seats.Controls.Add(btn);

                }
            }
        }
    }
}
