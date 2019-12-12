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
    public partial class allMaterials : Form
    {
        public allMaterials()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homePage = new homePage();
            homePage.Show();
        }

        private void allMaterials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DBDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.library_DBDataSet.Materials);
            // TODO: This line of code loads data into the 'library_DBDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.library_DBDataSet.Materials);
        }

        private void checked_Out_MaterialsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.materialsTableAdapter.Checked_Out_Materials(this.library_DBDataSet.Materials);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.checkoutMaterialsTableAdapter.FillBy(this.library_DBDataSet.CheckoutMaterials);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
