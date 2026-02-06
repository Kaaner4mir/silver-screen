using DevExpress.XtraEditors;
using SilverScreen.DataAccess.Services;
using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverScreen.Forms.CustomerForms
{
    public partial class FormUpdateCustomer : Form
    {
        private readonly CustomerService _service;

        public FormUpdateCustomer()
        {
            InitializeComponent();
            _service = new CustomerService(new DataAccess.SilverScreenContext());
        }

        private void FormUpdateCustomer_Load(object sender, EventArgs e)
        {
            var customers = _service.GetAll();

            comboBox_selected_customer.DataSource = customers;
            comboBox_selected_customer.DisplayMember = "Name";
            comboBox_selected_customer.ValueMember = "Id";
        }

        private void comboBox_selected_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_selected_customer.SelectedItem == null)
                return;

            Customer selectedCustomer = (Customer)comboBox_selected_customer.SelectedItem;

            textedit_customer_firstName.Text = selectedCustomer.Name;
            textedit_customer_lastName.Text = selectedCustomer.Surname;
            textedit_customer_email.Text = selectedCustomer.Email;
            textedit_customer_phone_number.Text = selectedCustomer.PhoneNumber;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Customer chosenMovie = (Customer)comboBox_selected_customer.SelectedItem;

            if (comboBox_selected_customer.SelectedItem != null)
            {
                chosenMovie.Name = textedit_customer_firstName.Text;
                chosenMovie.Surname = textedit_customer_lastName.Text;
                chosenMovie.Email = textedit_customer_email.Text;
                chosenMovie.Email=textedit_customer_email.Text;

                _service.Update(chosenMovie);

                XtraMessageBox.Show("The customer has been successfully updated", "Successful transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
