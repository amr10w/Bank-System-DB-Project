using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            ViewCustomersForm frm = new ViewCustomersForm();
            frm.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddCustomerForm frm = new AddCustomerForm();
            frm.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateCustomerForm frm = new UpdateCustomerForm();
            frm.Show();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteCustomerForm frm = new DeleteCustomerForm();
            frm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
