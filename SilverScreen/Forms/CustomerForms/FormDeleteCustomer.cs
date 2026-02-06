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
    public partial class FormDeleteCustomer : Form
    {
        private readonly CustomerService _customerService;

        public FormDeleteCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService(new DataAccess.SilverScreenContext());
        }

        private void LoadCustomers()
        {
            List<Customer> customers = _customerService.GetAll();
            grid_control_customers.DataSource = customers;
        }

        private void FormDeleteCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void grid_control_customers_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow chosenRow = grid_control_customers.CurrentRow;

            int value = Convert.ToInt32(chosenRow.Cells[0].Value);

            DialogResult result = XtraMessageBox.Show("Are you sure you want to delete the selected customer?", "Successful transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _customerService.Delete(value);
                XtraMessageBox.Show("The customer has been successfully deleted", "Successful transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
            }
        }
    }
}
