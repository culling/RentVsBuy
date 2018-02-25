using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace RentVsBuy.Business_Logic_Layer
{
    public class BankAccount
    {
        //Initialisation
        private double currentSavings;
        private double savingsInterestRate;
        private double mortgageInterestRate;
        private int term;

        

        //Get and Set
        public double CurrentSavings
        {
            get { return currentSavings; }
            set { currentSavings = value; }
        }

        public double SavingsInterestRate
        {
            get { return savingsInterestRate; }
            set { savingsInterestRate = value; }
        }

        public double MortgageInterestRate
        {
            get { return mortgageInterestRate; }
            set { mortgageInterestRate = value; }
        }

        public int Term
        {
            get { return term; }
            set { term = value; }
        }

        //Methods
        public double BalanceNextYearRenting(RentalProperty rentalProperty, double deposits){
            double balanceNextYear;
            double savingsInterest;

            //Costs
            double costs = rentalProperty.AnnualRent;

            savingsInterest = currentSavings * savingsInterestRate;
            balanceNextYear = (currentSavings + savingsInterest + deposits) - costs;

            return balanceNextYear;
        }

        public double[] BalanceRenting(RentalProperty rentalProperty, double deposits, int term)
        {
            double[] savings = new double[term +1];
            double savingsInterest;

            //Costs
            double costs = rentalProperty.AnnualRent;

            savings[0] = currentSavings;

            for (int i=1; i < term +1; i++) { 
                savingsInterest = savings[i -1] * savingsInterestRate;
                savings[i] = (savings[i-1] + savingsInterest + deposits) - costs;

                System.Diagnostics.Debug.WriteLine("Savings for year " + i + ": " + savings[i]);
            }
            return savings;
        }





        public double BalanceNextYearBuying(PurchaseProperty purchaseProperty, double deposits)
        {
            //Costs
            double mortgageInterest = (purchaseProperty.PurchasePrice * mortgageInterestRate);
            System.Diagnostics.Debug.WriteLine("Mortgage Interest Rate: " + mortgageInterestRate); 
            System.Diagnostics.Debug.WriteLine("Mortgage Interest: " + mortgageInterest );

            double mortgagePrincipleRepayment = purchaseProperty.PurchasePrice / term;
            System.Diagnostics.Debug.WriteLine("Mortgage Principle Repayment: " + mortgagePrincipleRepayment);

            double costs =  purchaseProperty.AnnualCosts + 
                            mortgageInterest + 
                            mortgagePrincipleRepayment;


            double balanceNextYear = (currentSavings + deposits) - costs;
            return balanceNextYear;
        }



        public double[] BalanceBuying(PurchaseProperty purchaseProperty, double deposits, int term)
        {
            double[] savings = new double[term + 1];

            //Costs Initalise
            double costs;
            double principleRepayment = purchaseProperty.PurchasePrice / (term - 1);
            double mortgageInterest;
            double mortgageLeft = purchaseProperty.PurchasePrice;

            savings[0] = currentSavings;
            System.Diagnostics.Debug.WriteLine(@"
                #############################################
                Buying
                #############################################
                ");
            for (int i = 1; i < term + 1; i++)
            {
                
                mortgageInterest    = mortgageLeft * mortgageInterestRate;
                costs               = principleRepayment + mortgageInterest + purchaseProperty.AnnualCosts;
                mortgageLeft -= principleRepayment;


                //System.Diagnostics.Debug.WriteLine("Mortgage Interest for year " + i + ": " + mortgageInterest);
                //System.Diagnostics.Debug.WriteLine("Principle Repayment for year " + i + ": " + principleRepayment);
                System.Diagnostics.Debug.WriteLine("Total costs for year " + i + ": " + costs);
                //System.Diagnostics.Debug.WriteLine("Mortgage Left " + i + ": " + mortgageLeft);

                savings[i] = (savings[i - 1] + deposits) - costs;

                System.Diagnostics.Debug.WriteLine("Savings for year " + i + ": " + savings[i]);

                
            }
            return savings;
        }



        //Default Constructor
        public BankAccount() { }

        //Paramaterised Constuctor
        public BankAccount(
            double currentSavings,
            double savingsInterestRate,
            double mortgageInterestRate,
            int term
            ){
            CurrentSavings          = currentSavings;
            SavingsInterestRate     = savingsInterestRate;
            MortgageInterestRate    = mortgageInterestRate;
            Term                    = term;
        }


    }
}
