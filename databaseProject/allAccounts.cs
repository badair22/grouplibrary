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
    public partial class allAccounts : Form
    {
        public allAccounts()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homePage = new homePage();
            homePage.Show();
        }

        private void allAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DBDataSet.LibraryAccounts' table. You can move, or remove it, as needed.
            this.libraryAccountsTableAdapter.Fill(this.library_DBDataSet.LibraryAccounts);

        }
    }
}
