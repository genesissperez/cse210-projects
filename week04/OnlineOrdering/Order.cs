using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public decimal CalculateTotalCost()
        {
            decimal totalProducts = 0;

            foreach (Product item in _products)
            {
                totalProducts += item.GetTotalCost();
            }


            decimal shipping;
            if (_customer.LivesInUsa())
            {
                shipping = 5.00m;
            }
            else
            {
                shipping = 35.00m;
            }

            return totalProducts + shipping;
        }

        public string GetPackingLabel()
        {
            string label = "*PACKING LABEL*:\n";

            foreach (Product item in _products)
            {
                label += "- " + item.GetName() + " (ID: " + item.GetProductId() + ")\n";
            }

            return label;
        }

        public string GetShippingLabel()
        {
            string label = "*SHIPPING LABEL*:\n";
            label += _customer.GetName() + "\n";
            label += _customer.GetAddress().GetFormattedAddress() + "\n";

            return label;
        }
    }
}