using SilverScreen.DataAccess;
using SilverScreen.DataAccess.Services;
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
            Database.SetInitializer(new CreateDatabaseIfNotExists<SilverScreenContext>());

            using (var database = new SilverScreenContext())
            {
                database.Database.Initialize(force: true);
            }
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
