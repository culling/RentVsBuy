using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVsBuy.Business_Logic_Layer
{
    public class Customer
    {
        //Initalize
        private string firstName;
        private string lastName;
        private double income;
        private double annualExpenses;

        //Public
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }


        public Double Income
        {
            get { return income; }
            set { income = value; }
        }

        public double AnnualExpenses
        {
            get { return annualExpenses; }
            set { annualExpenses = value; }
        }

        public double IncomeAfterExpenses
        {
            get { return (income - annualExpenses); }
        }

        //Default Constructor
        public Customer() { }

        //Paramaterized Constructor
        public Customer(
            double income,
            double annualExpenses)
        {
            Income = income;
            AnnualExpenses = annualExpenses;
        }

        


    }
}
