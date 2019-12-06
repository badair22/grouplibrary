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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
            removeMaterial removeMaterial = new removeMaterial();
            removeMaterial.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            returnMaterial returnMaterial = new returnMaterial();
            returnMaterial.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            createAccount createAccount = new createAccount();
            createAccount.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkoutMaterial checkoutMaterial = new checkoutMaterial();
            checkoutMaterial.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            feePayment feePayment = new feePayment();
            feePayment.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            addMaterial addMaterial = new addMaterial();
            addMaterial.Show();
        }
    }
}
