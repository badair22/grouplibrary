﻿using System;
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
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library_DB;Integrated Security=True");
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

            if (int.TryParse(input, out num) && input != null)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Materials set Condition='" + conditionCombobox.Text + "' where MaterialID='" + materialTextbox.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                if (int.TryParse(input, out num) && input != null)
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from CheckOuts where CheckoutID='" + checkoutTextbox.Text + "'";
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

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homePage = new homePage();
            homePage.Show();
        }
    }
}
