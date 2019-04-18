using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_DependencyPropertyDemo
{
    public class Customer
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
    }
}
