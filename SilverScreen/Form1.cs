using SilverScreen.DataAccess;
using DevExpress.XtraEditors;
using SilverScreen.Business.Services;
using SilverScreen.Entities.Models;
using SilverScreen.Forms;
using SilverScreen.Forms.CustomerForms;
using SilverScreen.Forms.ReservationsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SilverScreen
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private readonly MovieService _movieService;

        public Form1()
        {
            _movieService = new MovieService(new SilverScreenContext());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupNavigation();
            ShowDashboard();
        }

        private void ShowDashboard()
        {
            FormDashboard form = new FormDashboard();
            form.MdiParent = this;
            form.Show();
        }

        private void SetupNavigation()
        {
            // Show current user info
            if (AuthService.CurrentUser != null)
            {
                this.Text = $"Silver Screen - Welcome, {AuthService.CurrentUser.FullName} ({AuthService.CurrentUser.Role})";
            }

            // Add Dashboard Button
            var dashboardButton = new DevExpress.XtraBars.BarButtonItem();
            dashboardButton.Caption = "Dashboard";
            string dashboardPath = Path.Combine(Application.StartupPath, "Icons", "dashboard.png");
            if (File.Exists(dashboardPath))
            {
                dashboardButton.ImageOptions.Image = Image.FromFile(dashboardPath);
            }
            dashboardButton.ItemClick += (s, e) => ShowDashboard();
            
            ribbonControl1.Items.Add(dashboardButton);
            ribbonPageGroup1.ItemLinks.Insert(0, dashboardButton);

            // Add Logout Button
            var logoutButton = new DevExpress.XtraBars.BarButtonItem();
            logoutButton.Caption = "Logout";
            string logoutPath = Path.Combine(Application.StartupPath, "Icons", "logout.png");
            if (File.Exists(logoutPath))
            {
                logoutButton.ImageOptions.Image = Image.FromFile(logoutPath);
            }
            logoutButton.ItemClick += (s, e) => {
                new AuthService(new SilverScreenContext()).Logout();
                this.Hide();
                new Forms.FormLogin().Show();
                this.Close();
            };

            ribbonControl1.Items.Add(logoutButton);
            ribbonPageGroup1.ItemLinks.Add(logoutButton);

            // Link existing Reports button
            barButtonItem6.ItemClick += (s, e) => {
                var form = new Forms.FinancialForms.FormFinancialModule();
                form.MdiParent = this;
                form.Show();
            };

            // Link existing Take Payment button
            barButtonItem7.ItemClick += (s, e) => {
                var form = new Forms.ReservationsForms.FormReservationList();
                form.MdiParent = this;
                form.Show();
            };

            // Link existing Close Day button
            barButtonItem8.ItemClick += async (s, e) => {
                if (XtraMessageBox.Show("Are you sure you want to close the day?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try {
                        var financialService = new FinancialService(new SilverScreenContext());
                        await financialService.CloseDayAsync(DateTime.Now);
                        XtraMessageBox.Show("Day closed successfully.", "Success");
                    } catch (Exception ex) {
                        XtraMessageBox.Show($"Error: {ex.Message}", "Error");
                    }
                }
            };

            // Link existing Make a Reservation button
            barButtonItem13.ItemClick += (s, e) => {
                var form = new Forms.ReservationsForms.FormCreateReservation();
                form.ShowDialog();
            };
        }

        private void bar_button_list_movie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormMovieList form = new FormMovieList();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_add_movie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormAddMovie form = new FormAddMovie();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_edit_movie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormUpdateMovie form = new FormUpdateMovie();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_delete_movie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDeleteMovie form = new FormDeleteMovie();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_list_customer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCustomerList form = new FormCustomerList();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_add_customer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormAddCustomer form = new FormAddCustomer();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_edit_customer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormUpdateCustomer form = new FormUpdateCustomer();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_delete_customer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDeleteCustomer form = new FormDeleteCustomer();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_show_seats_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormReservationSeats form = new FormReservationSeats();
            form.MdiParent = this;
            form.Show();
        }
    }
}
