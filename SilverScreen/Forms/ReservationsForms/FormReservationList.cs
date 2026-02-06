using DevExpress.XtraEditors;
using SilverScreen.Business.Services;
using SilverScreen.DataAccess;
using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverScreen.Forms.ReservationsForms
{
    public partial class FormReservationList : XtraForm
    {
        private readonly SilverScreenContext _context;
        private readonly ReservationService _reservationService;
        private readonly PaymentService _paymentService;

        public FormReservationList()
        {
            InitializeComponent();
            _context = new SilverScreenContext();
            _reservationService = new ReservationService(_context);
            _paymentService = new PaymentService(_context);
        }

        private async void FormReservationList_Load(object sender, EventArgs e)
        {
            await LoadReservationsAsync();
        }

        private async Task LoadReservationsAsync()
        {
            try
            {
                var reservations = await _context.Reservations
                    .Include(r => r.Customer)
                    .Include(r => r.Showtime.Movie)
                    .Include(r => r.Seat)
                    .Select(r => new
                    {
                        r.Id,
                        Customer = r.Customer.Name + " " + r.Customer.Surname,
                        Movie = r.Showtime.Movie.Name,
                        Hall = r.Showtime.HallName,
                        Seat = r.Seat.SeatNumber,
                        Time = r.Showtime.StartTime,
                        IsPaid = r.IsPaid,
                        Price = r.Showtime.Price
                    })
                    .OrderByDescending(r => r.Time)
                    .ToListAsync();

                gridControl1.DataSource = reservations;
                gridView1.BestFitColumns();
                
                if (gridView1.Columns["Price"] != null)
                {
                     gridView1.Columns["Price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                     gridView1.Columns["Price"].DisplayFormat.FormatString = "c2";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading reservations: {ex.Message}", "Error");
            }
        }

        private async void btn_take_payment_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow();
            if (selectedRow == null) return;

            dynamic row = selectedRow;
            int reservationId = row.Id;
            bool isPaid = row.IsPaid;

            if (isPaid)
            {
                XtraMessageBox.Show("This reservation is already paid.", "Information");
                return;
            }

            if (XtraMessageBox.Show("Record payment for this reservation?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    await _paymentService.ProcessPaymentAsync(reservationId, "Ticket Payment");
                    XtraMessageBox.Show("Payment successful!", "Success");
                    await LoadReservationsAsync();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
        }
    }
}
