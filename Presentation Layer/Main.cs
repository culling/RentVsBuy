using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using RentVsBuy.Business_Logic_Layer;

namespace RentVsBuy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        //--------------------------------------------------------
        //Formatting the inputs
        //--------------------------------------------------------
        private void txtCurrentRent_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if(double.TryParse(txtCurrentRent.Text, System.Globalization.NumberStyles.Currency, null, out amount ))
            {
                txtCurrentRent.Text = amount.ToString("C");
            }
            else
            {
                if(! String.IsNullOrEmpty( txtCurrentRent.Text )) { 
                    MessageBox.Show("Invalid input, please enter a number", "Invalid input", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                }
                txtCurrentRent.Text = "$0.00";
                txtCurrentRent.Focus();
            }
        }

        private void txtPurchasePrice_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (double.TryParse(txtPurchasePrice.Text, System.Globalization.NumberStyles.Currency, null, out amount))
            {
                txtPurchasePrice.Text = amount.ToString("C");
            }
            else
            {
                if (!String.IsNullOrEmpty(txtPurchasePrice.Text))
                {
                    MessageBox.Show("Invalid input, please enter a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtPurchasePrice.Text = "$0.00";
                txtPurchasePrice.Focus();
            }
        }

        private void txtAnnualCosts_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (double.TryParse(txtAnnualCosts.Text, System.Globalization.NumberStyles.Currency, null, out amount))
            {
                txtAnnualCosts.Text = amount.ToString("C");
            }
            else
            {
                if (!String.IsNullOrEmpty(txtAnnualCosts.Text))
                {
                    MessageBox.Show("Invalid input, please enter a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtAnnualCosts.Text = "$0.00";
                txtAnnualCosts.Focus();
            }
        }

        private void txtAfterTaxIncome_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (double.TryParse(txtAfterTaxIncome.Text, System.Globalization.NumberStyles.Currency, null, out amount))
            {
                txtAfterTaxIncome.Text = amount.ToString("C");
            }
            else
            {
                if (!String.IsNullOrEmpty(txtAfterTaxIncome.Text))
                {
                    MessageBox.Show("Invalid input, please enter a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtAfterTaxIncome.Text = "$0.00";
                txtAfterTaxIncome.Focus();
            }
        }

        private void txtAnnualExpenses_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (double.TryParse(txtAnnualExpenses.Text, System.Globalization.NumberStyles.Currency, null, out amount))
            {
                txtAnnualExpenses.Text = amount.ToString("C");
            }
            else
            {
                if (!String.IsNullOrEmpty(txtAnnualExpenses.Text))
                {
                    MessageBox.Show("Invalid input, please enter a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtAnnualExpenses.Text = "$0.00";
                txtAnnualExpenses.Focus();
            }
        }

        private void txtSavings_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (double.TryParse(txtSavings.Text, System.Globalization.NumberStyles.Currency, null, out amount))
            {
                txtSavings.Text = amount.ToString("C");
            }
            else
            {
                if (!String.IsNullOrEmpty(txtSavings.Text))
                {
                    MessageBox.Show("Invalid input, please enter a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtSavings.Text = "$0.00";
                txtSavings.Focus();
            }
        }

        private void txtInterestOnSavings_Leave(object sender, EventArgs e)
        {
            if( txtInterestOnSavings.Text.Contains("%") != true )
            {
                double rate = 0.0d;
                if (double.TryParse(txtInterestOnSavings.Text , out rate))
                {
                    rate /= 100;
                    txtInterestOnSavings.Text = rate.ToString("0%");
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtInterestOnSavings.Text))
                    {
                        MessageBox.Show("Invalid input, please enter a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtInterestOnSavings.Text = "%0";
                    txtInterestOnSavings.Focus();
                }
            }


        }

        private void txtMortgageRate_Leave(object sender, EventArgs e)
        {

            if (txtMortgageRate.Text.Contains("%") != true)
            {
                double rate = 0.0d;
                if (double.TryParse(txtMortgageRate.Text, out rate))
                {
                    rate /= 100;
                    txtMortgageRate.Text = rate.ToString("0%");
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtMortgageRate.Text))
                    {
                        MessageBox.Show("Invalid input, please enter a number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtMortgageRate.Text = "%0";
                    txtMortgageRate.Focus();
                }
            
            }
        }


        


        //------------------------------------
        // Calculations
        //------------------------------------
        private void CalculateAll()
        {

            string resultText;

            //RentalProperty
            double currentRent = 0.0d;
            double.TryParse(txtCurrentRent.Text, System.Globalization.NumberStyles.Currency, null, out currentRent);

            string rentalPaymentFrequency = cmbRentalPaymentFrequency.Text;

            RentalProperty rentalProperty = new RentalProperty(currentRent, rentalPaymentFrequency);

            //PurchaseProperty
            double purchasePrice = 0.0d;
            double.TryParse(txtPurchasePrice.Text, System.Globalization.NumberStyles.Currency, null, out purchasePrice);

            double annualCosts = 0.0d;
            double.TryParse(txtAnnualCosts.Text, System.Globalization.NumberStyles.Currency, null, out annualCosts);

            PurchaseProperty purchaseProperty = new PurchaseProperty(purchasePrice, annualCosts);

            //Customer
            double afterTaxIncome = 0.0d; ;
            double.TryParse(txtAfterTaxIncome.Text, System.Globalization.NumberStyles.Currency, null, out afterTaxIncome);

            double annualExpenses = 0.0d; ;
            double.TryParse(txtAnnualExpenses.Text, System.Globalization.NumberStyles.Currency, null, out annualExpenses);

            Customer customer = new Customer(afterTaxIncome, annualExpenses);


            //Bank
            double savings = 0.0d;
            double.TryParse(txtSavings.Text, System.Globalization.NumberStyles.Currency, null, out savings);

            double interestOnSavingsRateRaw = 0.0d;
            string interestOnSavingsRateRawString = txtInterestOnSavings.Text;
            interestOnSavingsRateRawString = interestOnSavingsRateRawString.Replace('%', ' ').Trim();
            double.TryParse(interestOnSavingsRateRawString, out interestOnSavingsRateRaw);
            double interestOnSavingsRate = interestOnSavingsRateRaw / 100;//Turn into a percentage

            double mortgageRateRaw = 0.0d;
            string mortgageRateRawString = txtMortgageRate.Text;
            mortgageRateRawString = mortgageRateRawString.Replace('%', ' ').Trim();
            double.TryParse(mortgageRateRawString, out mortgageRateRaw);
            double mortgageRate = mortgageRateRaw / 100;//Turn into a percentage

            int term = 0;
            int.TryParse(cmbMortgageTerm.Text, out term);

            BankAccount bankAccount = new BankAccount(savings, interestOnSavingsRate, mortgageRate, term);


            double[] accountsByYearRenting;
            double[] accountsByYearBuying;

            accountsByYearRenting = bankAccount.BalanceRenting(rentalProperty, customer.IncomeAfterExpenses, term);
            accountsByYearBuying = bankAccount.BalanceBuying(purchaseProperty, customer.IncomeAfterExpenses, term);

            //Heading of Result Text
            resultText = "Result" + Environment.NewLine;
            resultText += "Total Assets Final Year Renting: " + accountsByYearRenting[accountsByYearRenting.Length - 1].ToString("C") + Environment.NewLine;


            double totalAssetsFinalYearBuying = (accountsByYearBuying[accountsByYearBuying.Length - 1] + purchaseProperty.PurchasePrice);
            resultText += "Total Assets Final Year Buying: " + totalAssetsFinalYearBuying.ToString("C") + Environment.NewLine;

            


            resultText += Environment.NewLine;

            resultText += "Current Savings: " + bankAccount.CurrentSavings.ToString() + Environment.NewLine;
            resultText += Environment.NewLine;


            //Renting Property
            resultText += "Rent Annually: " + rentalProperty.AnnualRent.ToString() + Environment.NewLine;

            resultText += "Account Balance Renting" + Environment.NewLine;
            for (int i = 0; i < accountsByYearRenting.Length; i++)
            {
                resultText += "Year " + i + ": " + accountsByYearRenting[i].ToString("C") + Environment.NewLine;
            }
            resultText += Environment.NewLine;


            //Purchasing property

            resultText += "Account Balance Buying" + Environment.NewLine;
            for (int i = 0; i < accountsByYearBuying.Length; i++)
            {
                resultText += "Year " + i + ": " + accountsByYearBuying[i].ToString("C") + Environment.NewLine;
            }
            resultText += Environment.NewLine;



            rtxResult.Text = resultText;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateAll();
        }
        
        


    }
}
