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
    public partial class AddCustomerForm : Form
    {
        string connectionString = "Data Source=(local);Initial Catalog=Bank;Integrated Security=SSPI";

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(Object sender, EventArgs e)
        {
            if (txt_SSN.Text == "" || txt_Fname.Text == "" || txt_Lname.Text == "")
            {
                MessageBox.Show("SSN, First Name, and Last Name are required.");
                return;
            }
            if (txt_SSN.Text.Length != 14)
            {
                MessageBox.Show("SSN must be exactly 14 characters.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                string insertStr = @"INSERT INTO customer (SSN, Fname, Lname, Adress, DOB)
                                     VALUES (@SSN, @Fname, @Lname, @Adress, @DOB)";

                SqlCommand cmd = new SqlCommand(insertStr, con);

                cmd.Parameters.Add(new SqlParameter("@SSN", txt_SSN.Text));
                cmd.Parameters.Add(new SqlParameter("@Fname", txt_Fname.Text));
                cmd.Parameters.Add(new SqlParameter("@Lname", txt_Lname.Text));
                cmd.Parameters.Add(new SqlParameter("@Adress", txt_Address.Text));

                if (txt_DOB.Text != "")
                    cmd.Parameters.Add(new SqlParameter("@DOB", txt_DOB.Text));
                else
                    cmd.Parameters.Add(new SqlParameter("@DOB", DBNull.Value));

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Customer added successfully!");

                txt_SSN.Text = "";
                txt_Fname.Text = "";
                txt_Lname.Text = "";
                txt_Address.Text = "";
                txt_DOB.Text = "";

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
