using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseProject
{
    public partial class createAccount : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library_DB;Integrated Security=True");
        public createAccount()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string firstName = firstTextbox.Text;
            string lastName = lastTextbox.Text;
            string phone = phoneTextbox.Text;
            string address = addressTextbox.Text;

            if (firstName != "" && lastName != "" && address != "" && phone != "")
            {
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into LibraryAccounts values ('" + firstName + "','" + lastName + "','" + address + "','" + phone + "','"+0.00+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Account Creation Successful.");
                firstTextbox.Clear();
                lastTextbox.Clear();
                phoneTextbox.Clear();
                addressTextbox.Clear();
            }

            else
            {
                MessageBox.Show("Please make sure all fields are filled in and that everything is valid.");
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homePage = new homePage();
            homePage.Show();
        }
    }
}
