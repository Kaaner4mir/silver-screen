namespace SilverScreen.Forms.CustomerForms
{
    partial class FormUpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateCustomer));
            this.button_update = new DevExpress.XtraEditors.SimpleButton();
            this.textedit_customer_email = new DevExpress.XtraEditors.TextEdit();
            this.textedit_customer_phone_number = new DevExpress.XtraEditors.TextEdit();
            this.textedit_customer_lastName = new DevExpress.XtraEditors.TextEdit();
            this.label_email = new DevExpress.XtraEditors.LabelControl();
            this.label_phone = new DevExpress.XtraEditors.LabelControl();
            this.label_lastName = new DevExpress.XtraEditors.LabelControl();
            this.textedit_customer_firstName = new DevExpress.XtraEditors.TextEdit();
            this.label_firstName = new DevExpress.XtraEditors.LabelControl();
            this.comboBox_selected_customer = new System.Windows.Forms.ComboBox();
            this.label_selected_customer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_phone_number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_lastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_firstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_update.Appearance.Options.UseFont = true;
            this.button_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_update.ImageOptions.Image")));
            this.button_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.button_update.Location = new System.Drawing.Point(570, 380);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(180, 50);
            this.button_update.TabIndex = 29;
            this.button_update.Text = "Update Customer";
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textedit_customer_email
            // 
            this.textedit_customer_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textedit_customer_email.Location = new System.Drawing.Point(200, 217);
            this.textedit_customer_email.Name = "textedit_customer_email";
            this.textedit_customer_email.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textedit_customer_email.Properties.Appearance.Options.UseFont = true;
            this.textedit_customer_email.Size = new System.Drawing.Size(550, 28);
            this.textedit_customer_email.TabIndex = 37;
            // 
            // textedit_customer_phone_number
            // 
            this.textedit_customer_phone_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textedit_customer_phone_number.Location = new System.Drawing.Point(200, 177);
            this.textedit_customer_phone_number.Name = "textedit_customer_phone_number";
            this.textedit_customer_phone_number.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textedit_customer_phone_number.Properties.Appearance.Options.UseFont = true;
            this.textedit_customer_phone_number.Size = new System.Drawing.Size(550, 28);
            this.textedit_customer_phone_number.TabIndex = 36;
            // 
            // textedit_customer_lastName
            // 
            this.textedit_customer_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textedit_customer_lastName.Location = new System.Drawing.Point(200, 137);
            this.textedit_customer_lastName.Name = "textedit_customer_lastName";
            this.textedit_customer_lastName.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textedit_customer_lastName.Properties.Appearance.Options.UseFont = true;
            this.textedit_customer_lastName.Size = new System.Drawing.Size(550, 28);
            this.textedit_customer_lastName.TabIndex = 35;
            // 
            // label_email
            // 
            this.label_email.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_email.Appearance.Options.UseFont = true;
            this.label_email.Location = new System.Drawing.Point(50, 220);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 21);
            this.label_email.TabIndex = 34;
            this.label_email.Text = "E-mail";
            // 
            // label_phone
            // 
            this.label_phone.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_phone.Appearance.Options.UseFont = true;
            this.label_phone.Location = new System.Drawing.Point(50, 180);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(120, 21);
            this.label_phone.TabIndex = 33;
            this.label_phone.Text = "Phone Number";
            // 
            // label_lastName
            // 
            this.label_lastName.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_lastName.Appearance.Options.UseFont = true;
            this.label_lastName.Location = new System.Drawing.Point(50, 140);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(155, 21);
            this.label_lastName.TabIndex = 32;
            this.label_lastName.Text = "Customer Surname";
            // 
            // textedit_customer_firstName
            // 
            this.textedit_customer_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textedit_customer_firstName.Location = new System.Drawing.Point(200, 97);
            this.textedit_customer_firstName.Name = "textedit_customer_firstName";
            this.textedit_customer_firstName.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textedit_customer_firstName.Properties.Appearance.Options.UseFont = true;
            this.textedit_customer_firstName.Size = new System.Drawing.Size(550, 28);
            this.textedit_customer_firstName.TabIndex = 31;
            // 
            // label_firstName
            // 
            this.label_firstName.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_firstName.Appearance.Options.UseFont = true;
            this.label_firstName.Location = new System.Drawing.Point(50, 100);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(130, 21);
            this.label_firstName.TabIndex = 30;
            this.label_firstName.Text = "Customer Name";
            // 
            // comboBox_selected_customer
            // 
            this.comboBox_selected_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_selected_customer.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.comboBox_selected_customer.FormattingEnabled = true;
            this.comboBox_selected_customer.Location = new System.Drawing.Point(200, 17);
            this.comboBox_selected_customer.Name = "comboBox_selected_customer";
            this.comboBox_selected_customer.Size = new System.Drawing.Size(550, 29);
            this.comboBox_selected_customer.TabIndex = 38;
            this.comboBox_selected_customer.SelectedIndexChanged += new System.EventHandler(this.comboBox_selected_customer_SelectedIndexChanged);
            // 
            // label_selected_customer
            // 
            this.label_selected_customer.AutoSize = true;
            this.label_selected_customer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_selected_customer.Location = new System.Drawing.Point(50, 20);
            this.label_selected_customer.Name = "label_selected_customer";
            this.label_selected_customer.Size = new System.Drawing.Size(149, 21);
            this.label_selected_customer.TabIndex = 39;
            this.label_selected_customer.Text = "Selected Customer";
            // 
            // FormUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_selected_customer);
            this.Controls.Add(this.comboBox_selected_customer);
            this.Controls.Add(this.textedit_customer_email);
            this.Controls.Add(this.textedit_customer_phone_number);
            this.Controls.Add(this.textedit_customer_lastName);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.textedit_customer_firstName);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.button_update);
            this.Name = "FormUpdateCustomer";
            this.Text = "Update customer";
            this.Load += new System.EventHandler(this.FormUpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_phone_number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_lastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_firstName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton button_update;
        private DevExpress.XtraEditors.TextEdit textedit_customer_email;
        private DevExpress.XtraEditors.TextEdit textedit_customer_phone_number;
        private DevExpress.XtraEditors.TextEdit textedit_customer_lastName;
        private DevExpress.XtraEditors.LabelControl label_email;
        private DevExpress.XtraEditors.LabelControl label_phone;
        private DevExpress.XtraEditors.LabelControl label_lastName;
        private DevExpress.XtraEditors.TextEdit textedit_customer_firstName;
        private DevExpress.XtraEditors.LabelControl label_firstName;
        private System.Windows.Forms.ComboBox comboBox_selected_customer;
        private System.Windows.Forms.Label label_selected_customer;
    }
}