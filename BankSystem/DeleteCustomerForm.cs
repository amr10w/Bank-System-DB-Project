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
    public partial class DeleteCustomerForm : Form
    {
        string connectionString = "Data Source=(local);Initial Catalog=Bank;Integrated Security=SSPI";
        public DeleteCustomerForm()
        {
            InitializeComponent();
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (t_SSN.Text == "")
            {
                MessageBox.Show("Please enter a SSN.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete customer with SSN: " + t_SSN.Text + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    // Delete from Customer_Phone first
                    cmd.CommandText = "DELETE FROM Customer_Phone WHERE SSN = @SSN";
                    cmd.Parameters.Add(new SqlParameter("@SSN", t_SSN.Text));
                    cmd.ExecuteNonQuery();

                    // Delete from Login_Credentials
                    cmd.CommandText = "DELETE FROM Login_Credentials WHERE customerID = @SSN";
                    cmd.ExecuteNonQuery();

                    // Delete from Owns
                    cmd.CommandText = "DELETE FROM Owns WHERE customerID = @SSN";
                    cmd.ExecuteNonQuery();

                    // Set Loan customer_ID to NULL (your FK is ON DELETE SET NULL)
                    // This is already handled by SQL Server automatically
                    // but we can also do it manually to be safe
                    cmd.CommandText = "UPDATE Loan SET customer_ID = NULL WHERE customer_ID = @SSN";
                    cmd.ExecuteNonQuery();

                    // Now delete the customer
                    cmd.CommandText = "DELETE FROM customer WHERE SSN = @SSN";
                    int rowsAffected = cmd.ExecuteNonQuery();

                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!");
                        t_SSN.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No customer found with that SSN.");
                    }

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
