using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L5_ClassesPtDuex
{
    public class Product
    {

        // Fields
        private int _uId;
        private string _title;
        private string _director;
        private double _rating;
        decimal _price;

        // Constructor
        public Product(string title, string director)
        {
            Random rand = new Random();
            UId = rand.Next(100000000, 1000000000);
            _title = title;
            Director = director;
            Rating = 0.0;
            Price = 0.0m;
        }

        public Product(string title, string director, double rating, decimal price)
        {
            Random rand = new Random();
            UId = rand.Next(100000000, 1000000000);
            _title = title;
            Director = director;
            Rating = rating;
            Price = price;
        }

        // Properties
        // Getters 
        // Setters
        public string GetTitle()
        {
            return _title;
        } // GetTitle()

        public void SetTitle(string title)
        {
            _title = title;
        }

        // Getter and setter
        // No Parenthese
        // Same return type as field
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Director { 
            get => _director; 
            set => _director = value; }

        public int UId { 
            get => _uId; 
            private set => _uId = value; }

        public double Rating { 
            get => _rating; 
            set => _rating = value; }

        public decimal Price { 
            get => _price; 

            set
            {
                if (value >= 0)
                {
                    _price = value;
                }else
                {
                    throw new Exception("Enter a value Greater Than 0");
                }           
            }
                
        }


        // Methods


    } // class

} // namespace
