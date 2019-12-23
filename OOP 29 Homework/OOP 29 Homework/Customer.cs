using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_29_Homework
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string PhNumber { get; set; }

        public Customer()
        {

        }

        public Customer(int iD, string firstName, string lastName, int age, string addressCity, string addressStreet, string phNumber)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            AddressCity = addressCity;
            AddressStreet = addressStreet;
            PhNumber = phNumber;
        }

        public override string ToString()
        {
            return $"Customer -- ID: {ID}, First Name: {FirstName}, Last Name: {LastName}, Age: {Age}, " +
                $"Address City: {AddressCity}, Address Street: {AddressStreet}, Phone Number: {PhNumber}";
        }
    }
}
