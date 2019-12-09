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
    public partial class checkoutMaterial : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library_DB;Integrated Security=True");
        public checkoutMaterial()
        {
            InitializeComponent();
        }

        private void checkoutMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DBDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.library_DBDataSet.Authors);
            // TODO: This line of code loads data into the 'library_DBDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.library_DBDataSet.Materials);

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string input = titleCombobox.Text;
            string input2 = conditionCombobox.Text;
            string input3 = authorCombobox.Text;
            string input4 = accountTextbox.Text;
            int num = -1;

            if (input != null && input2 != null && input3 != null && input4 != null)
            {
                SqlCommand cmd = con.CreateCommand();

                if ( input != null && input2 != null && input3 != null && int.TryParse(input4, out num) && input4 != null)
                {
                    //fix the return date
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into CheckOuts values ('" + input4 + "', '" + DateTime.Now + "', '"+ DateTime.Now.AddDays(20) +"', '"+ titleCombobox.SelectedValue +"', '"+ input2 +"')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Checkout Successful.");
                    conditionCombobox.SelectedIndex = -1;
                    titleCombobox.SelectedIndex = -1;
                    conditionCombobox.SelectedIndex = -1;
                    authorCombobox.SelectedIndex = -1;
                    accountTextbox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a number and select a condition.");
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
