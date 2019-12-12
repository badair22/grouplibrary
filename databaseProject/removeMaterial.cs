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

namespace databaseProject
{
    public partial class removeMaterial : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library_DB;Integrated Security=True");
        public removeMaterial()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string input = removeTextbox.Text;
            int num = -1;

            if (int.TryParse(input, out num) && input != null)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from CheckoutMaterials where MaterialID='" + input + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                if (int.TryParse(input, out num) && input != null)
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Checkouts where MaterialID='" + input + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (int.TryParse(input, out num) && input != null)
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Materials where MaterialID='" + input + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record removed successfully.");
                    removeTextbox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.");
                removeTextbox.Clear();
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
