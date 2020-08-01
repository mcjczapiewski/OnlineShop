﻿using System;
using System.Collections.Generic;

namespace OnlineShop.BusinessLayer
{
    public class Shop
    {
        bool isRunning = true;

        private IDatabase database;

        private IControler controler;

        public Shop(IDatabase database, IControler controler)
        {
            this.database = database;
            this.controler = controler;
        }

        private void DisplayStartingMenu()
        {
            throw new NotImplementedException();
        }

        public bool IsEmployee()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<string> ShowAllProducts()
        {
            List<Product> products = database.GetAllProducts();
            foreach (var product in products)
            {
                yield return
                    $"ID: {product.ProductId}, Type: {product.Type}, " +
                    $"Name: {product.ProductName}, Price: {product.Price}, " +
                    $"In stock: {product.Stock}";
            }
        }

        private void ShowProduct(Product product)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<string> ShowAllCustomers()
        {
            List<Customer> allCustomers = database.GetAllCustomers();
            foreach (var customer in allCustomers)
            {
                yield return
                    $"ID: {customer.CustomerId}, {customer.Name} {customer.Surname}\n" +
                    $"e-mail: {customer.Email}";
            }
        }

        private void ShowCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<string> ShowAllOrders()
        {
            List<Order> orders = database.GetAllOrders();
            foreach (var order in orders)
            {
                yield return
                    $"ID: {order.OrderId}, Date: {order.DateOfOrder}, " +
                    $"Product: {order.Products}, Count: {order.OrderCount}, " +
                    $"Customer: {order.Customer}, Sent: {order.IsSend}";
            }
        }

        private void FindOrder(Order order)
        {
            throw new NotImplementedException();
        }

        private void CreateAccount()
        {
            throw new NotImplementedException();
        }

        public void ProgramRunning()
        {
            while (isRunning)
            {
                DisplayStartingMenu();

                if (IsEmployee())
                {
                    switch (controler.UserChoice())
                    {
                        case 1:
                            ShowAllOrders();
                            
                            break;
                        case 2:
                            

                            break;

                        default:
                            controler.DisplayError("Wrong choice!", 1000);

                            break;
                    }

                }
                else
                {
                    switch (controler.UserChoice())
                    {
                        case 1:

                            break;
                        default:
                            controler.DisplayError("Wrong choice!", 1000);

                            break;
                    }

                }
            }
        }













    }
}
