using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L5_ClassesPtDuex
{
    public class AmazonOrder
    {
        // Fields
        string _orderId;
        string _name;
        List<Product> _products;
        decimal _tax;

        // Constructor
        public AmazonOrder(string orderId, string name, decimal tax)
        {
            _orderId = orderId;
            _name = name;
            _tax = tax;
            _products = new List<Product>();
        }

        // Properties

        public string OrderId { get => _orderId; set => _orderId = value; }
        public string Name { get => _name; set => _name = value; }
        public List<Product> Products { get => _products; set => _products = value; }
        public decimal Tax { get => _tax; set => _tax = value; }

        // Methods
        public decimal TotalPrice()
        {
            decimal totalPrice = 0m;

            // Looping through our product list
            foreach (Product product in _products)
            {
                // Adding the price of each individual proudct to our total product variable
                totalPrice += product.Price;
            }

            totalPrice *= (1 + _tax);

            // Return the total
            return totalPrice;
        }

    } // class

} // namespace
