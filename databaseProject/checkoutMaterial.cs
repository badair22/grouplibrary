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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0DDCEJQ;Initial Catalog=Library_DB;Integrated Security=True");
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

            if (input != null && input2 != null && input3 != null)
            {
                //first insert statement is not working
                //may just use the second only

                //con.Open();
                SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "insert into CheckoutMaterials values ('"+ 11 + "', '" + Convert.ToDouble(titleCombobox.Text) + "')";
                //cmd.ExecuteNonQuery();
                //con.Close();
                if ( input != null && input2 != null && input3 != null && int.TryParse(input4, out num) && input4 != null)
                {
                    //fix the return date
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into CheckOuts values ('" + accountTextbox.Text + "', '" + DateTime.Now + "', '"+ DateTime.Now +"')";
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
                conditionCombobox.SelectedIndex = -1;
                titleCombobox.SelectedIndex = -1;
                conditionCombobox.SelectedIndex = -1;
                authorCombobox.SelectedIndex = -1;
                accountTextbox.Clear();
                conditionCombobox.SelectedIndex = -1;
            }
        }
    }
}
