using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.model
{
    public class Person
    {
        // instans felter
        protected string _name;
        protected string _email;
        

        // konstruktører
        public Person()
        {
            Name = "Dummy";
            Email = "";
        }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }

        // properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        

        public override string ToString()
        {
            return "Name= " + Name + ", Email=" + Email;
        }

        public virtual string Salery()
        {
            return "Jeg tjener 12000 kr om måneden";
        }
    }
}
