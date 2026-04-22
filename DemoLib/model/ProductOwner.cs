using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.model
{
    public class ProductOwner : Person   // : Person betyder at ProductOwner arver fra Person
    {
        // instans felter
        private string _company;





        // konstruktører
        public ProductOwner() : base()  // kalder Person's default constructor
        {
            //Email = "prøver at sætte email";
            Company = "";
        }
        public ProductOwner(string name, string email, string company) : base(name, email)  // kalder Person's constructor med parameters
        {
            Company = company;
        }   


        // properties
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }





        public override string ToString()
        {
            return base.ToString() + ", Company=" + Company;  // kalder Person's ToString() og tilføjer Company
        }



        public override string Salery()
        {
               return "Jeg tjener 25000 kr om måneden";
        }
    }
}
