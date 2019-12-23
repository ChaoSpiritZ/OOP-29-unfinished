using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OOP_29_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\user\Desktop\SQLite\SQLite DBs\oop29.db";
            //using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            //{
            //    con.Open();
            //    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM CUSTOMERS", con))
            //    {
            //        using (SQLiteDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                Console.WriteLine($"{reader["ID"]}, {reader["FIRST_NAME"]}");
            //            }
            //        }
            //    }
            //};

            Customer cus1 = new Customer(1, "george", "lucas", 56, "somewhere", "somestreet", "051-1111111");
            Customer cus2 = new Customer(2, "shmuel", "bialik", 24, "nowhere", "nostreet", "052-2222222");

            Customer cus3 = new Customer(2, "shmuel", "bialik", 24, "nowhere", "nostreet", "052-2222222");

            CustomerDAO DAO = new CustomerDAO();
            //DAO.GetAllCustomers();
            //DAO.CreateCustomersTable();
            //DAO.AddCustomer(cus1);
            //DAO.AddCustomer(cus2);
            //List<Customer> customers = DAO.GetAllCustomers();
            //List<Customer> cusList = DAO.GetAllCustomers();
            //customers.ForEach(c => Console.WriteLine(c));
            //Console.WriteLine(DAO.GetCustomerByPhoneNumber("050-0000000"));
            //DAO.UpdateCustomer(3, cus3);
            //DAO.RemoveAllCustomers();

        }
    }
}
