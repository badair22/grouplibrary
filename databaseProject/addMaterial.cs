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
    public partial class addMaterial : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library_DB;Integrated Security=True");
        public addMaterial()
        {
            InitializeComponent();
        }

        private void addMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DBDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.library_DBDataSet.Genres);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string title = titleTextbox.Text;
            string publish = publishTextbox.Text;
            string type = typeTextbox.Text;
            string language = languageTextbox.Text;
            string condition = conditionCombobox.Text;
            string authorFirst = authorFirstTextbox.Text;
            string authorLast = authorLastTextbox.Text;
            string producerFirst = producerFirstTextbox.Text;
            string producerLast = producerLastTextbox.Text;

            if (title != null && publish != null && type != null && type != "" && language != null && authorFirst != null && authorLast != null || producerFirst != null && producerLast != null)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Materials values ('"+ title +"', '"+ publish +"', '"+ type +"', '"+ condition +"', '"+ language + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                if (authorFirst != null && authorLast != null)
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Authors values ('" + authorFirst + "', '" + authorLast + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Material Added.");
                }
                else
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Producers values ('" + producerFirst + "', '" + producerLast + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Material Added.");
                }
                
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

    }
    }

