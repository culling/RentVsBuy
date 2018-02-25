using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVsBuy.Business_Logic_Layer
{
    public class PurchaseProperty
    {
        //Initalize
        private double purchasePrice;
        private double annualCosts;

        //Public
        public Double PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }

        public Double AnnualCosts
        {
            get { return annualCosts; }
            set { annualCosts = value; }
        }




        //Default Constructor
        public PurchaseProperty() { }

        //Paramaterized Constructor
        public PurchaseProperty(
            double purchasePrice,
            double annualCosts)
        {
            PurchasePrice   = purchasePrice;
            AnnualCosts     = annualCosts;
        }




    }
}
