using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_29_Homework;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDAO cDAO = new CustomerDAO();
            List<Customer> customers = cDAO.GetAllCustomers();
        }
    }
}
