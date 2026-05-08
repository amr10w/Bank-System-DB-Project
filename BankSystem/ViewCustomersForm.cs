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
    public partial class ViewCustomersForm : Form
    {
        string connectionString = "Data Source=(local);Initial Catalog=Bank;Integrated Security=SSPI";

        public ViewCustomersForm()
        {
            InitializeComponent();
        }

        private void ViewCustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomers()
        {
            SqlConnection con =new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT SSN, Fname, Lname, Adress, DOB FROM customer", con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            
            DataTable tbl = new DataTable();
            tbl.Columns.Add("SSN");
            tbl.Columns.Add("First Name");
            tbl.Columns.Add("Last Name");
            tbl.Columns.Add("Address");
            tbl.Columns.Add("Date of Birth");

            DataRow row;

            while (reader.Read())
            {
                row=tbl.NewRow();
                row["SSN"]=reader["SSN"];
                row["First Name"]=reader["Fname"];
                row["Last Name"]=reader["Lname"];
                row["Address"]=reader["Adress"];
                row["Date of Birth"]=reader["DOB"];
                tbl.Rows.Add(row);

            }

            reader.Close();
            con.Close();

            dgv_Customers.DataSource = tbl;



        }

      
    }
}
