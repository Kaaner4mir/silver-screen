using DevExpress.XtraEditors;
using SilverScreen.Business.Services;
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
    public partial class FormAddCustomer : Form
    {
        private readonly CustomerService _customerService;
        public FormAddCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService(new DataAccess.SilverScreenContext());
        }

        private async void button_add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Name=textedit_customer_firstName.Text,
                Surname=textedit_customer_lastName.Text,
                PhoneNumber=textedit_customer_phone_number.Text,
                Email=textedit_customer_email.Text
            };

            await _customerService.AddCustomerAsync(customer);

            XtraMessageBox.Show("Customer has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
