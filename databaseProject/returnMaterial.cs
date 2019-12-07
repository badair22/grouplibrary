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
    public partial class returnMaterial : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0DDCEJQ;Initial Catalog=Library_DB;Integrated Security=True");
        public returnMaterial()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string input = materialTextbox.Text;
            string input2 = conditionCombobox.Text;
            string input3 = checkoutTextbox.Text;
            int num = -1;

            //needs fixed, only runs second command.
            if (int.TryParse(input, out num) && input != null && input2 != null && int.TryParse(input3, out num))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Materials set Condition='" + conditionCombobox.Text + "' where MaterialID='" + materialTextbox.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                if (int.TryParse(input, out num) && input != null && input2 != null && int.TryParse(input3, out num))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from CheckoutMaterials where CheckoutID='" + checkoutTextbox.Text + "' and MaterialID='" + materialTextbox.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Return Successful.");
                    conditionCombobox.SelectedIndex = -1;
                    materialTextbox.Clear();
                    checkoutTextbox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a number and select a condition.");
                materialTextbox.Clear();
                conditionCombobox.SelectedIndex = -1;
            }
        }
    }
}
