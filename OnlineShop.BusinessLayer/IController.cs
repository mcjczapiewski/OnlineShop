﻿namespace OnlineShop.BusinessLayer
{
    public interface IController
    {
        int UserChoiceInt(string message);

        string UserInputString(string message);

        void DisplayMessage(string massage, int milliseconds);

        void WriteOutData(string message);

        string GetInput(string message);

        string GetPassword();

        void DisplayCustomer(Customer customer);

        void DisplayOrder(Order order);

        void DisplayCart(ShoppingCart shoppingCart);

        void DisplayProduct(Product product);
    }
}