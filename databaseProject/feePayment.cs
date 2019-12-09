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
    public partial class feePayment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library_DB;Integrated Security=True");
        public feePayment()
        {
            InitializeComponent();
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM LibraryAccounts WHERE AccountID='{0}'", accountTextbox.Text);
            var cm = new SqlCommand(sql, con);
            con.Open();
            var dr = cm.ExecuteReader();
            decimal feesOwed = 0;
            while (dr.Read())
            {
                feesOwed = Convert.ToDecimal(dr["FeesOwed"]);
            }
            con.Close();
            string input = accountTextbox.Text;
            string input2 = amountTextbox.Text;
            int num = -1;

                if (int.TryParse(input, out num) && input != null && input2 != null)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into FeePayments values ('" + input + "', '" + input2 + "', '" + DateTime.Now + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (int.TryParse(input, out num) && input != null && input2 != null)
                    {
                        decimal total = ((feesOwed) - Decimal.Parse(input2));
                        con.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update LibraryAccounts set FeesOwed='"+ total +"' where AccountID='" + input + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Payment Successful.");
                        accountTextbox.Clear();
                        amountTextbox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a dollar payment and fill all fields.");
                    accountTextbox.Clear();
                    amountTextbox.Clear();
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
