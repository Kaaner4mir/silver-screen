using DevExpress.XtraEditors;
using SilverScreen.Business.Services;
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
    public partial class FormCreateReservation : XtraForm
    {
        private readonly ReservationService _reservationService;
        private readonly MovieService _movieService;
        private readonly CustomerService _customerService;
        private readonly SilverScreenContext _context;

        public FormCreateReservation()
        {
            InitializeComponent();
            _context = new SilverScreenContext();
            _reservationService = new ReservationService(_context);
            _movieService = new MovieService(_context);
            _customerService = new CustomerService(_context);
        }

        private async void FormCreateReservation_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var showtimes = _context.Showtimes.Include("Movie")
                    .Select(s => new
                    {
                        s.Id,
                        MovieName = s.Movie.Name,
                        s.HallName,
                        Date = s.StartTime
                    }).ToList();

                // Configure Showtime LookUp
                lookUpEdit_showtime.Properties.Columns.Clear();
                lookUpEdit_showtime.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MovieName", "Movie"));
                lookUpEdit_showtime.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HallName", "Hall"));
                lookUpEdit_showtime.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Date", "Time", 80, DevExpress.Utils.FormatType.DateTime, "HH:mm", true, DevExpress.Utils.HorzAlignment.Default));
                lookUpEdit_showtime.Properties.DataSource = showtimes;
                lookUpEdit_showtime.Properties.DisplayMember = "MovieName";
                lookUpEdit_showtime.Properties.ValueMember = "Id";
                lookUpEdit_showtime.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

                var customers = (await _customerService.GetAllCustomersAsync())
                    .Select(c => new 
                    { 
                        c.Id, 
                        Name = c.Name + " " + c.Surname,
                        Email = c.Email 
                    }).ToList();

                // Configure Customer LookUp
                lookUpEdit_customer.Properties.Columns.Clear();
                lookUpEdit_customer.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Customer"));
                lookUpEdit_customer.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email"));
                lookUpEdit_customer.Properties.DataSource = customers;
                lookUpEdit_customer.Properties.DisplayMember = "Name"; 
                lookUpEdit_customer.Properties.ValueMember = "Id";
                lookUpEdit_customer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

                var seats = _context.Seats.Where(s => !s.Taken)
                    .Select(s => new
                    {
                        s.Id,
                        Number = s.SeatNumber
                    }).ToList();

                // Configure Seat LookUp
                lookUpEdit_seat.Properties.Columns.Clear();
                lookUpEdit_seat.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Seat Number"));
                lookUpEdit_seat.Properties.DataSource = seats;
                lookUpEdit_seat.Properties.DisplayMember = "Number";
                lookUpEdit_seat.Properties.ValueMember = "Id";
                lookUpEdit_seat.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading data: {ex.Message}", "Error");
            }
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (lookUpEdit_showtime.EditValue == null || lookUpEdit_customer.EditValue == null || lookUpEdit_seat.EditValue == null)
            {
                XtraMessageBox.Show("Please select all fields.", "Warning");
                return;
            }

            try
            {
                int showtimeId = (int)lookUpEdit_showtime.EditValue;
                int customerId = (int)lookUpEdit_customer.EditValue;
                int seatId = (int)lookUpEdit_seat.EditValue;

                await _reservationService.CreateReservationAsync(showtimeId, customerId, seatId);
                XtraMessageBox.Show("Reservation created successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error creating reservation: {ex.Message}", "Error");
            }
        }
    }
}
