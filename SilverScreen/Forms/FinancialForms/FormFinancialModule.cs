using DevExpress.XtraEditors;
using SilverScreen.Business.Services;
using SilverScreen.DataAccess;
using SilverScreen.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverScreen.Forms.FinancialForms
{
    public partial class FormFinancialModule : XtraForm
    {
        private readonly ReportingService _reportingService;
        private readonly FinancialService _financialService;
        private readonly SilverScreenContext _context;

        public FormFinancialModule()
        {
            InitializeComponent();
            _context = new SilverScreenContext();
            _reportingService = new ReportingService(_context);
            _financialService = new FinancialService(_context);
        }

        private async void FormFinancialModule_Load(object sender, EventArgs e)
        {
            await RefreshDataAsync();
        }

        private async Task RefreshDataAsync()
        {
            try
            {
                var dailyRevenue = await _reportingService.GetDailyRevenueAsync(DateTime.Now);
                label_daily_revenue.Text = $"Daily Revenue: {dailyRevenue:C2}";

                var movieStats = await _reportingService.GetMovieStatisticsAsync();
                grid_movie_stats.DataSource = movieStats;

                var summary = await _financialService.GetDailySummaryAsync(DateTime.Now);
                label_summary.Text = $"Transactions: {summary.TransactionCount} | Avg: {summary.AvgTransactionValue:C2}";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading data: {ex.Message}", "Error");
            }
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            await RefreshDataAsync();
        }
    }
}
