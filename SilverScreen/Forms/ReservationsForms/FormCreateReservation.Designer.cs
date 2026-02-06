namespace SilverScreen.Forms.ReservationsForms
{
    partial class FormCreateReservation
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_showtime;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_customer;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_seat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lookUpEdit_showtime = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit_customer = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit_seat = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_showtime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_seat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit_showtime
            // 
            this.lookUpEdit_showtime.Location = new System.Drawing.Point(120, 30);
            this.lookUpEdit_showtime.Name = "lookUpEdit_showtime";
            this.lookUpEdit_showtime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_showtime.Properties.NullText = "Select Showtime";
            this.lookUpEdit_showtime.Size = new System.Drawing.Size(200, 20);
            this.lookUpEdit_showtime.TabIndex = 0;
            // 
            // lookUpEdit_customer
            // 
            this.lookUpEdit_customer.Location = new System.Drawing.Point(120, 70);
            this.lookUpEdit_customer.Name = "lookUpEdit_customer";
            this.lookUpEdit_customer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_customer.Properties.NullText = "Select Customer";
            this.lookUpEdit_customer.Size = new System.Drawing.Size(200, 20);
            this.lookUpEdit_customer.TabIndex = 1;
            // 
            // lookUpEdit_seat
            // 
            this.lookUpEdit_seat.Location = new System.Drawing.Point(120, 110);
            this.lookUpEdit_seat.Name = "lookUpEdit_seat";
            this.lookUpEdit_seat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_seat.Properties.NullText = "Select Seat";
            this.lookUpEdit_seat.Size = new System.Drawing.Size(200, 20);
            this.lookUpEdit_seat.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Showtime:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Customer:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Seat:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(120, 160);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 30);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(230, 160);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 30);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += (s, e) => this.Close();
            // 
            // FormCreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 220);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpEdit_seat);
            this.Controls.Add(this.lookUpEdit_customer);
            this.Controls.Add(this.lookUpEdit_showtime);
            this.Name = "FormCreateReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Reservation";
            this.Load += new System.EventHandler(this.FormCreateReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_showtime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_seat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
