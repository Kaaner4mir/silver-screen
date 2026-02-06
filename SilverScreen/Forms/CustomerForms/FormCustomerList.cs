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
    public partial class FormCustomerList : Form
    {
        private readonly DataAccess.Services.CustomerService _customerService;

        public FormCustomerList()
        {
            InitializeComponent();
            _customerService = new DataAccess.Services.CustomerService(new DataAccess.SilverScreenContext());
        }

        private void LoadCustomerList()
        {
            var customers = _customerService.GetAll();
            grid_control_customers.DataSource = customers;
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }
    }
}
