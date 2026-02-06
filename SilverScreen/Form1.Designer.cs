namespace SilverScreen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_list_movie = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_add_movie = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_edit_movie = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_delete_movie = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_list_customer = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_add_customer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_edit_customer = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_delete_customer = new DevExpress.XtraBars.BarButtonItem();
            this.bar_button_show_seats = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Movies";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.bar_button_list_movie,
            this.bar_button_add_movie,
            this.bar_button_edit_movie,
            this.bar_button_delete_movie,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.bar_button_list_customer,
            this.bar_button_add_customer,
            this.barButtonItem5,
            this.bar_button_edit_customer,
            this.bar_button_delete_customer,
            this.bar_button_show_seats,
            this.barButtonItem13});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1200, 185);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar_button_list_movie
            // 
            this.bar_button_list_movie.Caption = "List";
            this.bar_button_list_movie.Hint = "Lists available movies";
            this.bar_button_list_movie.Id = 2;
            this.bar_button_list_movie.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_list_movie.ImageOptions.Image")));
            this.bar_button_list_movie.LargeWidth = 100;
            this.bar_button_list_movie.Name = "bar_button_list_movie";
            this.bar_button_list_movie.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bar_button_list_movie.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_list_movie_ItemClick);
            // 
            // bar_button_add_movie
            // 
            this.bar_button_add_movie.Caption = "Add";
            this.bar_button_add_movie.Id = 3;
            this.bar_button_add_movie.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_add_movie.ImageOptions.Image")));
            this.bar_button_add_movie.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_button_add_movie.ImageOptions.LargeImage")));
            this.bar_button_add_movie.LargeWidth = 100;
            this.bar_button_add_movie.Name = "bar_button_add_movie";
            this.bar_button_add_movie.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_add_movie_ItemClick);
            // 
            // bar_button_edit_movie
            // 
            this.bar_button_edit_movie.Caption = "Edit";
            this.bar_button_edit_movie.Id = 4;
            this.bar_button_edit_movie.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_edit_movie.ImageOptions.Image")));
            this.bar_button_edit_movie.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_button_edit_movie.ImageOptions.LargeImage")));
            this.bar_button_edit_movie.LargeWidth = 100;
            this.bar_button_edit_movie.Name = "bar_button_edit_movie";
            this.bar_button_edit_movie.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_edit_movie_ItemClick);
            // 
            // bar_button_delete_movie
            // 
            this.bar_button_delete_movie.Caption = "Delete";
            this.bar_button_delete_movie.Id = 5;
            this.bar_button_delete_movie.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_delete_movie.ImageOptions.Image")));
            this.bar_button_delete_movie.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_button_delete_movie.ImageOptions.LargeImage")));
            this.bar_button_delete_movie.LargeWidth = 100;
            this.bar_button_delete_movie.Name = "bar_button_delete_movie";
            this.bar_button_delete_movie.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_delete_movie_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Reports";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.LargeWidth = 133;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Take Payment";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.LargeWidth = 133;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Close Day";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.LargeWidth = 133;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // bar_button_list_customer
            // 
            this.bar_button_list_customer.Caption = "List";
            this.bar_button_list_customer.Id = 9;
            this.bar_button_list_customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_list_customer.ImageOptions.Image")));
            this.bar_button_list_customer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_button_list_customer.ImageOptions.LargeImage")));
            this.bar_button_list_customer.LargeWidth = 100;
            this.bar_button_list_customer.Name = "bar_button_list_customer";
            this.bar_button_list_customer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_list_customer_ItemClick);
            // 
            // bar_button_add_customer
            // 
            this.bar_button_add_customer.Caption = "Add";
            this.bar_button_add_customer.Id = 10;
            this.bar_button_add_customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_add_customer.ImageOptions.Image")));
            this.bar_button_add_customer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_button_add_customer.ImageOptions.LargeImage")));
            this.bar_button_add_customer.LargeWidth = 100;
            this.bar_button_add_customer.Name = "bar_button_add_customer";
            this.bar_button_add_customer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_add_customer_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 11;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // bar_button_edit_customer
            // 
            this.bar_button_edit_customer.Caption = "Edit";
            this.bar_button_edit_customer.Id = 12;
            this.bar_button_edit_customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_edit_customer.ImageOptions.Image")));
            this.bar_button_edit_customer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_button_edit_customer.ImageOptions.LargeImage")));
            this.bar_button_edit_customer.LargeWidth = 100;
            this.bar_button_edit_customer.Name = "bar_button_edit_customer";
            this.bar_button_edit_customer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_edit_customer_ItemClick);
            // 
            // bar_button_delete_customer
            // 
            this.bar_button_delete_customer.Caption = "Delete";
            this.bar_button_delete_customer.Id = 13;
            this.bar_button_delete_customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_delete_customer.ImageOptions.Image")));
            this.bar_button_delete_customer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_button_delete_customer.ImageOptions.LargeImage")));
            this.bar_button_delete_customer.LargeWidth = 100;
            this.bar_button_delete_customer.Name = "bar_button_delete_customer";
            this.bar_button_delete_customer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_delete_customer_ItemClick);
            // 
            // bar_button_show_seats
            // 
            this.bar_button_show_seats.Caption = "Show Seats";
            this.bar_button_show_seats.Id = 14;
            this.bar_button_show_seats.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_button_show_seats.ImageOptions.Image")));
            this.bar_button_show_seats.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_button_show_seats.ImageOptions.LargeImage")));
            this.bar_button_show_seats.LargeWidth = 200;
            this.bar_button_show_seats.Name = "bar_button_show_seats";
            this.bar_button_show_seats.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_button_show_seats_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Make a reservation";
            this.barButtonItem13.Id = 15;
            this.barButtonItem13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.Image")));
            this.barButtonItem13.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.LargeImage")));
            this.barButtonItem13.LargeWidth = 200;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "     Movies";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AccessibleDescription = "";
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_button_list_movie);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_button_add_movie);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_button_edit_movie);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_button_delete_movie);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "All operations related to movies";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "     Cash Register";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem6, true);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "All operations related to the cash register";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "     Customer";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_button_list_customer);
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_button_add_customer);
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_button_edit_customer);
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_button_delete_customer);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "All operations related to customers";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Reservation";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bar_button_show_seats);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "All operations related to rezervations";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Edit";
            this.barButtonItem9.Id = 4;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.LargeWidth = 100;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 770);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silver Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bar_button_list_movie;
        private DevExpress.XtraBars.BarButtonItem bar_button_add_movie;
        private DevExpress.XtraBars.BarButtonItem bar_button_edit_movie;
        private DevExpress.XtraBars.BarButtonItem bar_button_delete_movie;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bar_button_list_customer;
        private DevExpress.XtraBars.BarButtonItem bar_button_add_customer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem bar_button_edit_customer;
        private DevExpress.XtraBars.BarButtonItem bar_button_delete_customer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem bar_button_show_seats;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

