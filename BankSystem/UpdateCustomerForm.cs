using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSystem
{
    public partial class UpdateCustomerForm : Form
    {

        string connectionString = "Data Source=(local);Initial Catalog=Bank;Integrated Security=SSPI";
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_NewSSN.Text == "")
            {
                MessageBox.Show("Please enter the SSN of the customer to update.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                string updateStr = @"UPDATE customer 
                                     SET Adress = @NewAdress, DOB = @NewDOB
                                     WHERE SSN = @SSN";

                SqlCommand cmd = new SqlCommand(updateStr, con);

                cmd.Parameters.Add(new SqlParameter("@SSN", txt_NewSSN.Text));
                cmd.Parameters.Add(new SqlParameter("@NewAdress", txt_NewAddress.Text));

                if (txt_NewDOB.Text != "")
                    cmd.Parameters.Add(new SqlParameter("@NewDOB", txt_NewDOB.Text));
                else
                    cmd.Parameters.Add(new SqlParameter("@NewDOB", DBNull.Value));

                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                    MessageBox.Show("Customer updated successfully!");
                else
                    MessageBox.Show("No customer found with that SSN.");

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
