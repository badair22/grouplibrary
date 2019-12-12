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

        private void viewMaterialsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            allMaterials allMaterials = new allMaterials();
            allMaterials.Show();
        }

        private void lateMaterialsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lateMaterials lateMaterials = new lateMaterials();
            lateMaterials.Show();
        }

        private void feesOwedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            feesOwed feesOwed = new feesOwed();
            feesOwed.Show();
        }

        private void outstandingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            outstandingFees outstandingFees = new outstandingFees();
            outstandingFees.Show();
        }

        private void allAccountsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            allAccounts allAccounts = new allAccounts();
            allAccounts.Show();
        }

        private void checkOutsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkOuts checkOuts = new checkOuts();
            checkOuts.Show();
        }
    }
}
