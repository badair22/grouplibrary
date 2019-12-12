using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseProject
{
    public partial class lateMaterials : Form
    {
        public lateMaterials()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homePage = new homePage();
            homePage.Show();
        }

        private void lateMaterials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DBDataSet.CheckOuts' table. You can move, or remove it, as needed.
            this.checkOutsTableAdapter.Fill(this.library_DBDataSet.CheckOuts);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.checkOutsTableAdapter.FillBy(this.library_DBDataSet.CheckOuts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
