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
    public partial class FormDeleteCustomer : Form
    {
        private readonly CustomerService _customerService;
        private readonly DataAccess.SilverScreenContext _context;

        public FormDeleteCustomer()
        {
            InitializeComponent();
            _context = new DataAccess.SilverScreenContext();
            _customerService = new CustomerService(_context);
        }

        private async Task LoadCustomersAsync()
        {
            List<Customer> customers = await _customerService.GetAllCustomersAsync();
            grid_control_customers.DataSource = customers;
        }

        private async void FormDeleteCustomer_Load(object sender, EventArgs e)
        {
            await LoadCustomersAsync();
        }

        private async void grid_control_customers_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow chosenRow = grid_control_customers.CurrentRow;

            int value = Convert.ToInt32(chosenRow.Cells[0].Value);

            DialogResult result = XtraMessageBox.Show("Are you sure you want to delete the selected customer?", "Successful transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _customerService.DeleteCustomerAsync(value);
                XtraMessageBox.Show("The customer has been successfully deleted", "Successful transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadCustomersAsync();
            }
        }
    }
}
