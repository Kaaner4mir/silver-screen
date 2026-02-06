namespace SilverScreen.Forms.CustomerForms
{
    partial class FormAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCustomer));
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            this.textedit_customer_lastName = new DevExpress.XtraEditors.TextEdit();
            this.label_email = new DevExpress.XtraEditors.LabelControl();
            this.label_phone = new DevExpress.XtraEditors.LabelControl();
            this.label_lastName = new DevExpress.XtraEditors.LabelControl();
            this.textedit_customer_firstName = new DevExpress.XtraEditors.TextEdit();
            this.label_firstName = new DevExpress.XtraEditors.LabelControl();
            this.textedit_customer_phone_number = new DevExpress.XtraEditors.TextEdit();
            this.textedit_customer_email = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_lastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_firstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_phone_number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_email.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add.Appearance.Options.UseFont = true;
            this.button_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_add.ImageOptions.Image")));
            this.button_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.button_add.Location = new System.Drawing.Point(296, 282);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(177, 55);
            this.button_add.TabIndex = 17;
            this.button_add.Text = "Save new customer";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textedit_customer_lastName
            // 
            this.textedit_customer_lastName.Location = new System.Drawing.Point(296, 74);
            this.textedit_customer_lastName.Name = "textedit_customer_lastName";
            this.textedit_customer_lastName.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedit_customer_lastName.Properties.Appearance.Options.UseFont = true;
            this.textedit_customer_lastName.Size = new System.Drawing.Size(411, 32);
            this.textedit_customer_lastName.TabIndex = 16;
            // 
            // label_email
            // 
            this.label_email.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Appearance.Options.UseFont = true;
            this.label_email.Appearance.Options.UseTextOptions = true;
            this.label_email.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label_email.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_email.Location = new System.Drawing.Point(100, 223);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(185, 25);
            this.label_email.TabIndex = 15;
            this.label_email.Text = "E-mail";
            // 
            // label_phone
            // 
            this.label_phone.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Appearance.Options.UseFont = true;
            this.label_phone.Appearance.Options.UseTextOptions = true;
            this.label_phone.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label_phone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_phone.Location = new System.Drawing.Point(100, 148);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(185, 25);
            this.label_phone.TabIndex = 14;
            this.label_phone.Text = "Phone Number";
            // 
            // label_lastName
            // 
            this.label_lastName.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Appearance.Options.UseFont = true;
            this.label_lastName.Appearance.Options.UseTextOptions = true;
            this.label_lastName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label_lastName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_lastName.Location = new System.Drawing.Point(100, 77);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(185, 25);
            this.label_lastName.TabIndex = 13;
            this.label_lastName.Text = "Customer Last Name";
            // 
            // textedit_customer_firstName
            // 
            this.textedit_customer_firstName.Location = new System.Drawing.Point(296, 7);
            this.textedit_customer_firstName.Name = "textedit_customer_firstName";
            this.textedit_customer_firstName.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedit_customer_firstName.Properties.Appearance.Options.UseFont = true;
            this.textedit_customer_firstName.Size = new System.Drawing.Size(411, 32);
            this.textedit_customer_firstName.TabIndex = 12;
            // 
            // label_firstName
            // 
            this.label_firstName.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Appearance.Options.UseFont = true;
            this.label_firstName.Appearance.Options.UseTextOptions = true;
            this.label_firstName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label_firstName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label_firstName.Location = new System.Drawing.Point(100, 10);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(185, 25);
            this.label_firstName.TabIndex = 11;
            this.label_firstName.Text = "Customer First Name";
            // 
            // textedit_customer_phone_number
            // 
            this.textedit_customer_phone_number.Location = new System.Drawing.Point(296, 145);
            this.textedit_customer_phone_number.Name = "textedit_customer_phone_number";
            this.textedit_customer_phone_number.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedit_customer_phone_number.Properties.Appearance.Options.UseFont = true;
            this.textedit_customer_phone_number.Size = new System.Drawing.Size(411, 32);
            this.textedit_customer_phone_number.TabIndex = 18;
            // 
            // textedit_customer_email
            // 
            this.textedit_customer_email.Location = new System.Drawing.Point(296, 220);
            this.textedit_customer_email.Name = "textedit_customer_email";
            this.textedit_customer_email.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textedit_customer_email.Properties.Appearance.Options.UseFont = true;
            this.textedit_customer_email.Size = new System.Drawing.Size(411, 32);
            this.textedit_customer_email.TabIndex = 19;
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textedit_customer_email);
            this.Controls.Add(this.textedit_customer_phone_number);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textedit_customer_lastName);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.textedit_customer_firstName);
            this.Controls.Add(this.label_firstName);
            this.Name = "FormAddCustomer";
            this.Text = "Add a new customer";
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_lastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_firstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_phone_number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_customer_email.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton button_add;
        private DevExpress.XtraEditors.TextEdit textedit_customer_lastName;
        private DevExpress.XtraEditors.LabelControl label_email;
        private DevExpress.XtraEditors.LabelControl label_phone;
        private DevExpress.XtraEditors.LabelControl label_lastName;
        private DevExpress.XtraEditors.TextEdit textedit_customer_firstName;
        private DevExpress.XtraEditors.LabelControl label_firstName;
        private DevExpress.XtraEditors.TextEdit textedit_customer_phone_number;
        private DevExpress.XtraEditors.TextEdit textedit_customer_email;
    }
}