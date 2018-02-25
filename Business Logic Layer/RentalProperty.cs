using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVsBuy.Business_Logic_Layer
{
    public class RentalProperty
    {
        //Initalize
        private double rent;
        private string paymentFrequency;
        
        //Public
        public double Rent
        {
            get { return rent; }
            set { rent = value; }
        }
        public string PaymentFrequency
        {
            get { return paymentFrequency; }
            set { paymentFrequency = value; }
        }
        
        public double AnnualRent
        {
            get
            {
                System.Diagnostics.Debug.WriteLine("Rent: " + rent);
                System.Diagnostics.Debug.WriteLine("Payment Frequncy: " + paymentFrequency);


                switch (paymentFrequency) {
                    case "Weekly":
                        return rent * 52;
                    case "Fortnightly":
                        return rent * 26;
                    case "Monthly":
                        return rent * 12;
                    case "Annually":
                        return rent;
                    default:
                        return 0;
                }
            }

            
        }


        //Default Constructor
        public RentalProperty() { }

        //Paramaterized Constructor
        public RentalProperty(double rent, string paymentFrequency)
        {
            Rent = rent;
            PaymentFrequency = paymentFrequency;
        }
    }
}
