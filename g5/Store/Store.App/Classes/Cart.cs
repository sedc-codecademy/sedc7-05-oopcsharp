using System;

namespace Store.App.Classes
{
    class Cart
    {
        private Product[] items;
        private double totalPrice;
        private int discountPercent;

        public Cart()
        {
            items = new Product[0];
            totalPrice = 0;
            discountPercent = 0;
        }

        public void AddItem(Product product)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = product;

            totalPrice += product.getPrice();
            Console.WriteLine(product.getName() + " added to cart.");
        }

        public void PrintTotalPrice()
        {
            Console.WriteLine("Your total price is: " + totalPrice);
        }

        public void CheckOut()
        {
            if (items.Length >= 3)
            {
                discountPercent = 10;
            }

            totalPrice -= CalculateDiscount(discountPercent);

            Console.WriteLine("You have a discount of " + discountPercent + "%");
            Console.WriteLine("Your final price is: " + totalPrice);
            Console.WriteLine("Thank you for shopping at our store");

            ClearCart();
        }

        private double CalculateDiscount(int discount)
        {
            return ((totalPrice / 100) * discount);
        }

        private void ClearCart()
        {
            Array.Resize(ref items, 0);
            totalPrice = 0;
            discountPercent = 0;
        }
    }
}
