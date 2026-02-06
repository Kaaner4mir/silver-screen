namespace SilverScreen.Forms.FinancialForms
{
    partial class FormFinancialModule
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl label_daily_revenue;
        private DevExpress.XtraEditors.LabelControl label_summary;
        private DevExpress.XtraGrid.GridControl grid_movie_stats;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;

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
            this.label_daily_revenue = new DevExpress.XtraEditors.LabelControl();
            this.label_summary = new DevExpress.XtraEditors.LabelControl();
            this.grid_movie_stats = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movie_stats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_daily_revenue
            // 
            this.label_daily_revenue.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label_daily_revenue.Appearance.Options.UseFont = true;
            this.label_daily_revenue.Location = new System.Drawing.Point(20, 20);
            this.label_daily_revenue.Name = "label_daily_revenue";
            this.label_daily_revenue.Size = new System.Drawing.Size(183, 23);
            this.label_daily_revenue.TabIndex = 0;
            this.label_daily_revenue.Text = "Daily Revenue: ...";
            // 
            // label_summary
            // 
            this.label_summary.Location = new System.Drawing.Point(20, 55);
            this.label_summary.Name = "label_summary";
            this.label_summary.Size = new System.Drawing.Size(89, 13);
            this.label_summary.TabIndex = 1;
            this.label_summary.Text = "Daily Summary: ...";
            // 
            // grid_movie_stats
            // 
            this.grid_movie_stats.Location = new System.Drawing.Point(20, 90);
            this.grid_movie_stats.MainView = this.gridView1;
            this.grid_movie_stats.Name = "grid_movie_stats";
            this.grid_movie_stats.Size = new System.Drawing.Size(560, 250);
            this.grid_movie_stats.TabIndex = 2;
            this.grid_movie_stats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_movie_stats;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(505, 20);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // FormFinancialModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grid_movie_stats);
            this.Controls.Add(this.label_summary);
            this.Controls.Add(this.label_daily_revenue);
            this.Name = "FormFinancialModule";
            this.Text = "Financial Module";
            this.Load += new System.EventHandler(this.FormFinancialModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_movie_stats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
