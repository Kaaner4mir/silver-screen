using SilverScreen.DataAccess;
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

namespace SilverScreen.Forms.ReservationsForms
{
    public partial class FormReservationSeats : Form
    {
        private readonly SilverScreenContext _context;

        public FormReservationSeats()
        {
            InitializeComponent();
            _context = new SilverScreenContext();
        }

        private void FormReservationSeats_Load(object sender, EventArgs e)
        {
            flowLayoutPanel_seats.Controls.Clear();

            new DatabaseSeeder(_context).SeedSeat();

            var seats = _context.Seats.OrderBy(s => s.HallName).ThenBy(s => s.SequenceNumber).ToList();

            int availableCount = seats.Count(s => !s.Taken);
            int takenCount = seats.Count(s => s.Taken);
            label_stats.Text = $"Seat Statistics: Total: {seats.Count} | Available: {availableCount} | Reserved: {takenCount}";

            var groupedSeats = seats.GroupBy(s => s.HallName);

            foreach (var group in groupedSeats)
            {
                // Create a GroupBox for each Hall
                GroupBox hb = new GroupBox();
                hb.Text = $"Hall: {group.Key}";
                hb.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
                hb.Size = new Size(flowLayoutPanel_seats.Width - 40, 200); // Fixed height for hall group
                hb.ForeColor = Color.DarkSlateBlue;

                FlowLayoutPanel hallFlow = new FlowLayoutPanel();
                hallFlow.Dock = DockStyle.Fill;
                hallFlow.AutoScroll = true;
                hb.Controls.Add(hallFlow);

                foreach (var seat in group)
                {
                    Button btn = new Button();
                    btn.Text = $"Seq: {seat.SequenceNumber}\nSeat: {seat.SeatNumber}";
                    btn.Width = 100;
                    btn.Height = 80;
                    btn.Tag = seat.Id;
                    btn.BackColor = seat.Taken ? Color.Red : Color.Green;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Nirmala UI", 10F, FontStyle.Regular);

                    // Tooltip for more info
                    ToolTip tt = new ToolTip();
                    tt.SetToolTip(btn, $"Hall: {seat.HallName}\nSequence: {seat.SequenceNumber}\nSeat: {seat.SeatNumber}\nStatus: {(seat.Taken ? "Reserved" : "Available")}");

                    hallFlow.Controls.Add(btn);
                }

                flowLayoutPanel_seats.Controls.Add(hb);
            }
        }
    }
}
