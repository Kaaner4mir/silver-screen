using SilverScreen.DataAccess;
using SilverScreen.DataAccess.Services;
using SilverScreen.Entities.Models;
using SilverScreen.Forms;
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

        private void bar_button_list_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormMovieList form = new FormMovieList();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormAddMovie form= new FormAddMovie();
            form.MdiParent = this;
            form.Show();
        }

        private void bar_button_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bar_button_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDeleteMovie form = new FormDeleteMovie();
            form.MdiParent = this;
            form.Show();
        }
    }
}
