namespace SilverScreen.Forms
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.TextEdit textEdit_username;
        private DevExpress.XtraEditors.TextEdit textEdit_password;
        private DevExpress.XtraEditors.SimpleButton button_login;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;

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
            this.textEdit_username = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_password = new DevExpress.XtraEditors.TextEdit();
            this.button_login = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit_username
            // 
            this.textEdit_username.Location = new System.Drawing.Point(50, 110);
            this.textEdit_username.Name = "textEdit_username";
            this.textEdit_username.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textEdit_username.Properties.Appearance.Options.UseFont = true;
            this.textEdit_username.Size = new System.Drawing.Size(250, 28);
            this.textEdit_username.TabIndex = 0;
            // 
            // textEdit_password
            // 
            this.textEdit_password.Location = new System.Drawing.Point(50, 180);
            this.textEdit_password.Name = "textEdit_password";
            this.textEdit_password.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textEdit_password.Properties.Appearance.Options.UseFont = true;
            this.textEdit_password.Properties.UseSystemPasswordChar = true;
            this.textEdit_password.Size = new System.Drawing.Size(250, 28);
            this.textEdit_password.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button_login.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_login.Appearance.Options.UseBackColor = true;
            this.button_login.Appearance.Options.UseFont = true;
            this.button_login.Location = new System.Drawing.Point(50, 240);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(250, 40);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 21);
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 155);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 21);
            this.labelControl2.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(50, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 37);
            this.labelControl3.Text = "SilverScreen";
            // 
            // FormLogin
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textEdit_password);
            this.Controls.Add(this.textEdit_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - SilverScreen";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
