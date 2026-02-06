namespace SilverScreen.Forms
{
    partial class FormTicket
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl label_title;
        private DevExpress.XtraEditors.LabelControl lbl_movie;
        private DevExpress.XtraEditors.LabelControl lbl_hall;
        private DevExpress.XtraEditors.LabelControl lbl_seat;
        private DevExpress.XtraEditors.LabelControl lbl_price;
        private DevExpress.XtraEditors.SimpleButton btn_print;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_title = new DevExpress.XtraEditors.LabelControl();
            this.lbl_movie = new DevExpress.XtraEditors.LabelControl();
            this.lbl_hall = new DevExpress.XtraEditors.LabelControl();
            this.lbl_seat = new DevExpress.XtraEditors.LabelControl();
            this.lbl_price = new DevExpress.XtraEditors.LabelControl();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Appearance.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.label_title.Appearance.Options.UseFont = true;
            this.label_title.Location = new System.Drawing.Point(100, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(164, 32);
            this.label_title.Text = "MOVIE TICKET";
            // 
            // lbl_movie
            // 
            this.lbl_movie.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_movie.Appearance.Options.UseFont = true;
            this.lbl_movie.Location = new System.Drawing.Point(30, 80);
            this.lbl_movie.Name = "lbl_movie";
            this.lbl_movie.Size = new System.Drawing.Size(51, 21);
            this.lbl_movie.Text = "Movie: ";
            // 
            // lbl_hall
            // 
            this.lbl_hall.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_hall.Appearance.Options.UseFont = true;
            this.lbl_hall.Location = new System.Drawing.Point(30, 120);
            this.lbl_hall.Name = "lbl_hall";
            this.lbl_hall.Size = new System.Drawing.Size(35, 21);
            this.lbl_hall.Text = "Hall: ";
            // 
            // lbl_seat
            // 
            this.lbl_seat.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl_seat.Appearance.Options.UseFont = true;
            this.lbl_seat.Location = new System.Drawing.Point(30, 160);
            this.lbl_seat.Name = "lbl_seat";
            this.lbl_seat.Size = new System.Drawing.Size(38, 21);
            this.lbl_seat.Text = "Seat: ";
            // 
            // lbl_price
            // 
            this.lbl_price.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_price.Appearance.Options.UseFont = true;
            this.lbl_price.Location = new System.Drawing.Point(30, 200);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(46, 21);
            this.lbl_price.Text = "Price: ";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(130, 250);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(100, 30);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "Print Ticket";
            // 
            // FormTicket
            // 
            this.ClientSize = new System.Drawing.Size(380, 400);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_seat);
            this.Controls.Add(this.lbl_hall);
            this.Controls.Add(this.lbl_movie);
            this.Controls.Add(this.label_title);
            this.Name = "FormTicket";
            this.Text = "Bilet Görüntüle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
