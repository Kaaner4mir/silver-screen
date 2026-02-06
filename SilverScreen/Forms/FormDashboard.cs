using DevExpress.XtraEditors;
using SilverScreen.DataAccess;
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

namespace SilverScreen.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private async void FormDashboard_Load(object sender, EventArgs e)
        {
            await RefreshStatsAsync();
        }

        private async Task RefreshStatsAsync()
        {
            using (var context = new SilverScreenContext())
            {
                var movieCount = await context.Movies.CountAsync();
                var customerCount = await context.Customers.CountAsync();
                
                var today = DateTime.Today;
                var todayReservations = await context.Reservations
                    .CountAsync(r => DbFunctions.TruncateTime(r.ReservationTime) == today);

                var totalRevenue = await context.Reservations
                    .Include(r => r.Showtime)
                    .SumAsync(r => (decimal?)r.Showtime.Price) ?? 0;

                label_movie_count.Text = movieCount.ToString();
                label_customer_count.Text = customerCount.ToString();
                label_reservation_today.Text = todayReservations.ToString();
                label_total_revenue.Text = $"{totalRevenue:N2} TL";
            }
        }
    }
}
