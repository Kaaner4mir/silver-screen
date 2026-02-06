using SilverScreen.DataAccess;
using SilverScreen.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverScreen.Forms
{
    public partial class FormLogin : Form
    {
        private readonly AuthService _authService;

        public FormLogin()
        {
            InitializeComponent();
            _authService = new AuthService(new SilverScreenContext());
        }

        private async void button_login_Click(object sender, EventArgs e)
        {
            string username = textEdit_username.Text;
            string password = textEdit_password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = await _authService.LoginAsync(username, password);

            if (success)
            {
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
                mainForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
