﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OnlineShop.BusinessLayer
{
    class SqlDb : IDatabase
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=OnlineShopDb;Trusted_Connection = True;";

        public void AddCustomer(Dictionary<string, string> customerData)
        {
            string addCustomerCommand = $@"INSERT INTO [dbo].[Customers] values (null, {customerData["FirstName"]}, {customerData["LastName"]}, {customerData["Adress"]}, {customerData["Email"]}, {customerData["Password"]})";
            
            SqlConnection dbConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(addCustomerCommand, dbConnection);

            command.
        }

        public void AddOrder()
        {
            throw new NotImplementedException();
        }

        public void AddProduct()
        {
            throw new NotImplementedException();
        }

        public void DelateCustomer(Customer customer)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand($@"DELETE FROM [dbo].[Customers] WHERE CustomerId ={customer.CustomerId}");

            command.;
        }

        public void DelateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void DelateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            SqlConnection dbConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(
                @"SELECT CustomerId, FirstName, LastName, Adress, Email, Password FROM [dbo].[Customers]", dbConnection);

            dbConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), 
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

                customers.Add(customer);
            }
            reader.Close();
            dbConnection.Dispose();

            return customers;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            SqlConnection dbConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(querryGetAllOrders, dbConnection);

            dbConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Order order = new Order(reader[1], reader[2], reader[3], reader[4]);

                orders.Add(order);
            }
            reader.Close();
            dbConnection.Dispose();

            return orders;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            SqlConnection dbConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(@"SELECT ProductId, ProductName, ProductPrice, Stock from [dbo].[Products]", dbConnection);

            dbConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product product = new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2], reader[4]);
            }
        }

        public Customer GetCustomer(string name, string surname)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(string orderId)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(string productName)
        {
            throw new NotImplementedException();
        }
    }
}