using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_29_Homework
{
    interface ICustomerDAO
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(int id, Customer customer);
        void DeleteCustomer(int id);
        List<Customer> GetCustomersLivingInCity(string city);
        List<Customer> GetCustomersBetweenAges(int minAge, int maxAge);
        Customer GetCustomerByPhoneNumber(string phone);
        void RemoveAllCustomers();
    }
}
