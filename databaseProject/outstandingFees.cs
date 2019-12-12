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
    public partial class outstandingFees : Form
    {
        public outstandingFees()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homePage = new homePage();
            homePage.Show();
        }

        private void outstandingFees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DBDataSet.LibraryAccounts' table. You can move, or remove it, as needed.
            this.libraryAccountsTableAdapter.Fill(this.library_DBDataSet.LibraryAccounts);
            // TODO: This line of code loads data into the 'library_DBDataSet.LibraryAccounts' table. You can move, or remove it, as needed.
            this.libraryAccountsTableAdapter.Fill(this.library_DBDataSet.LibraryAccounts);

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.libraryAccountsTableAdapter.FillBy3(this.library_DBDataSet.LibraryAccounts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
