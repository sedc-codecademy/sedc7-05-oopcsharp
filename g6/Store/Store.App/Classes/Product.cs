﻿using System;

namespace Store.App.Classes
{
    class Product
    {
        private static int count = 0;
        private string name;
        private double price;

        public Product(string productName, double productPrice)
        {
            name = productName;
            price = productPrice;
            count++;
        }

        public string getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }

        public static int Count()
        {
            return count;
        }
    }
}
