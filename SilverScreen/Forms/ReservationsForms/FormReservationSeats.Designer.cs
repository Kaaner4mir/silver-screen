namespace SilverScreen.Forms.ReservationsForms
{
    partial class FormReservationSeats
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel_seats = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.label_available_legend = new System.Windows.Forms.Label();
            this.label_taken_legend = new System.Windows.Forms.Label();
            this.label_stats = new System.Windows.Forms.Label();
            this.panel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_seats
            // 
            this.flowLayoutPanel_seats.AutoScroll = true;
            this.flowLayoutPanel_seats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_seats.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel_seats.Name = "flowLayoutPanel_seats";
            this.flowLayoutPanel_seats.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_seats.Size = new System.Drawing.Size(800, 370);
            this.flowLayoutPanel_seats.TabIndex = 0;
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_info.Controls.Add(this.label_stats);
            this.panel_info.Controls.Add(this.label_taken_legend);
            this.panel_info.Controls.Add(this.label_available_legend);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(0, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(800, 80);
            this.panel_info.TabIndex = 1;
            // 
            // label_available_legend
            // 
            this.label_available_legend.BackColor = System.Drawing.Color.Green;
            this.label_available_legend.ForeColor = System.Drawing.Color.White;
            this.label_available_legend.Location = new System.Drawing.Point(20, 15);
            this.label_available_legend.Name = "label_available_legend";
            this.label_available_legend.Size = new System.Drawing.Size(120, 25);
            this.label_available_legend.TabIndex = 0;
            this.label_available_legend.Text = "Available Seat";
            this.label_available_legend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_taken_legend
            // 
            this.label_taken_legend.BackColor = System.Drawing.Color.Red;
            this.label_taken_legend.ForeColor = System.Drawing.Color.White;
            this.label_taken_legend.Location = new System.Drawing.Point(20, 45);
            this.label_taken_legend.Name = "label_taken_legend";
            this.label_taken_legend.Size = new System.Drawing.Size(120, 25);
            this.label_taken_legend.TabIndex = 1;
            this.label_taken_legend.Text = "Reserved Seat";
            this.label_taken_legend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_stats
            // 
            this.label_stats.AutoSize = true;
            this.label_stats.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_stats.Location = new System.Drawing.Point(160, 25);
            this.label_stats.Name = "label_stats";
            this.label_stats.Size = new System.Drawing.Size(157, 21);
            this.label_stats.TabIndex = 2;
            this.label_stats.Text = "Seat Statistics: ...";
            // 
            // FormReservationSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel_seats);
            this.Controls.Add(this.panel_info);
            this.Name = "FormReservationSeats";
            this.Text = "Show Seats";
            this.Load += new System.EventHandler(this.FormReservationSeats_Load);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_seats;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label label_available_legend;
        private System.Windows.Forms.Label label_taken_legend;
        private System.Windows.Forms.Label label_stats;
    }
}