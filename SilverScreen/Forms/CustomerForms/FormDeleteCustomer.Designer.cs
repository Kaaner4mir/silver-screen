namespace SilverScreen.Forms.CustomerForms
{
    partial class FormDeleteCustomer
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
            this.grid_control_customers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_control_customers
            // 
            this.grid_control_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_control_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_control_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_control_customers.Location = new System.Drawing.Point(0, 0);
            this.grid_control_customers.Name = "grid_control_customers";
            this.grid_control_customers.ReadOnly = true;
            this.grid_control_customers.Size = new System.Drawing.Size(800, 450);
            this.grid_control_customers.TabIndex = 0;
            this.grid_control_customers.DoubleClick += new System.EventHandler(this.grid_control_customers_DoubleClick);
            // 
            // FormDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_control_customers);
            this.Name = "FormDeleteCustomer";
            this.Text = "Delete customer";
            this.Load += new System.EventHandler(this.FormDeleteCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_control_customers;
    }
}