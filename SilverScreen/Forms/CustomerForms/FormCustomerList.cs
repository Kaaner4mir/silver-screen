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
        private readonly Business.Services.CustomerService _customerService;

        public FormCustomerList()
        {
            InitializeComponent();
            _customerService = new Business.Services.CustomerService(new DataAccess.SilverScreenContext());
        }

        private async Task LoadCustomerListAsync()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            grid_control_customers.DataSource = customers;
            
            // Enable search and filtering
            if (grid_control_customers.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
            {
                gridView.OptionsFind.AlwaysVisible = true;
                gridView.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private async void FormCustomerList_Load(object sender, EventArgs e)
        {
            await LoadCustomerListAsync();
        }
    }
}
