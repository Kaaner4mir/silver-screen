namespace SilverScreen.Forms.CustomerForms
{
    partial class FormCustomerList
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
            this.grid_control_customers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_control_customers
            // 
            this.grid_control_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_control_customers.Location = new System.Drawing.Point(0, 0);
            this.grid_control_customers.MainView = this.gridView1;
            this.grid_control_customers.Name = "grid_control_customers";
            this.grid_control_customers.Size = new System.Drawing.Size(800, 450);
            this.grid_control_customers.TabIndex = 0;
            this.grid_control_customers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_control_customers;
            this.gridView1.Name = "gridView1";
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_control_customers);
            this.Name = "FormCustomerList";
            this.Text = "List of customers";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_control_customers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}