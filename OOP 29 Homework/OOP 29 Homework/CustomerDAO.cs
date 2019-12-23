using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_29_Homework
{
    public class CustomerDAO : ICustomerDAO
    {
        /// <summary>
        /// adds a customer to the DB
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO CUSTOMERS(ID, FIRST_NAME, LAST_NAME, AGE, ADDRESS_CITY, ADDRESS_STREET, PH_NUMBER) " +
                    $"VALUES({customer.ID}, '{customer.FirstName}', '{customer.LastName}', '{customer.Age}', '{customer.AddressCity}', '{customer.AddressStreet}', '{customer.PhNumber}')", con))
                {
                    cmd.ExecuteNonQuery();
                }
            };
        }

        /// <summary>
        /// removes a customer from the DB
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCustomer(int id)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"Delete from CUSTOMERS where ID = {id}", con))
                {
                    cmd.ExecuteNonQuery();
                }
            };
        }

        /// <summary>
        /// gets all customers from the DB
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMERS", con))
                {
                    using(SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer c = new Customer()
                            {
                                ID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Age = reader.GetInt32(3),
                                AddressCity = reader.GetString(4),
                                AddressStreet = reader.GetString(5),
                                PhNumber = reader.GetString(6)
                            };
                            customers.Add(c);
                        }
                    }
                }
            };
            return customers;
        }

        /// <summary>
        /// gets a customer by his id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int id)
        {
            Customer customer = new Customer();
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMERS WHERE ID = {id}", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customer.ID = reader.GetInt32(0);
                            customer.FirstName = reader.GetString(1);
                            customer.LastName = reader.GetString(2);
                            customer.Age = reader.GetInt32(3);
                            customer.AddressCity = reader.GetString(4);
                            customer.AddressStreet = reader.GetString(5);
                            customer.PhNumber = reader.GetString(6);
                        }
                    }
                }
            };
            return customer;
        }

        /// <summary>
        /// gets a customer by his phone number
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public Customer GetCustomerByPhoneNumber(string phone)
        {
            Customer customer = new Customer();
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMERS WHERE PH_NUMBER = '{phone}'", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customer.ID = reader.GetInt32(0);
                            customer.FirstName = reader.GetString(1);
                            customer.LastName = reader.GetString(2);
                            customer.Age = reader.GetInt32(3);
                            customer.AddressCity = reader.GetString(4);
                            customer.AddressStreet = reader.GetString(5);
                            customer.PhNumber = reader.GetString(6);
                        }
                    }
                }
            };
            return customer;
        }

        /// <summary>
        /// gets a list of customers between the inputted ages
        /// </summary>
        /// <param name="minAge"></param>
        /// <param name="maxAge"></param>
        /// <returns></returns>
        public List<Customer> GetCustomersBetweenAges(int minAge, int maxAge)
        {
            List<Customer> customers = new List<Customer>();
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMERS WHERE AGE BETWEEN {minAge} AND {maxAge}", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer c = new Customer()
                            {
                                ID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Age = reader.GetInt32(3),
                                AddressCity = reader.GetString(4),
                                AddressStreet = reader.GetString(5),
                                PhNumber = reader.GetString(6)
                            };
                            customers.Add(c);
                        }
                    }
                }
            };
            return customers;
        }

        /// <summary>
        /// gets a list of costumers that live in the inputted city
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public List<Customer> GetCustomersLivingInCity(string city)
        {
            List<Customer> customers = new List<Customer>();
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMERS WHERE ADDRESS_CITY = '{city}'", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer c = new Customer()
                            {
                                ID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Age = reader.GetInt32(3),
                                AddressCity = reader.GetString(4),
                                AddressStreet = reader.GetString(5),
                                PhNumber = reader.GetString(6)
                            };
                            customers.Add(c);
                        }
                    }
                }
            };
            return customers;
        }

        /// <summary>
        /// removes all the customers from the DB
        /// </summary>
        public void RemoveAllCustomers()
        {
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"Delete from CUSTOMERS", con))
                {
                    cmd.ExecuteNonQuery();
                }
            };
        }

        /// <summary>
        /// updates a customer chosen by his id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customer"></param>
        public void UpdateCustomer(int id, Customer customer)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"UPDATE CUSTOMERS SET ID = {customer.ID}, FIRST_NAME = '{customer.FirstName}', LAST_NAME = '{customer.LastName}', " +
                    $"AGE = {customer.Age}, ADDRESS_CITY = '{customer.AddressCity}', ADDRESS_STREET = '{customer.AddressStreet}', PH_NUMBER = '{customer.PhNumber}' WHERE ID = {id}", con))
                {
                    cmd.ExecuteNonQuery();
                }
            };
        }

        public void CreateCustomersTable()
        {
            using (SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CustomersDBLocal"].ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"CREATE TABLE CUSTOMERS ('ID' INTEGER PRIMARY KEY, 'FIRST_NAME' TEXT, 'LAST_NAME' TEXT, 'AGE' INTEGER, 'ADDRESS_CITY' TEXT, 'ADDRESS_STREET' TEXT, 'PH_NUMBER' TEXT UNIQUE)", con))
                {
                    cmd.ExecuteNonQuery();
                }
            };
        }
    }
}
