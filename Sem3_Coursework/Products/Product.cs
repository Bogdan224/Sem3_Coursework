using Sem3_Coursework.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Coursework.Products
{
    public class Product
    {
        public string Name { get; set; } 
        public Unit ProductUnit { get; set; }
        private double _price;
        public double Price
        {
            get { return _price; }
            set 
            {
                if (value < 0) throw new ArgumentException("Product.Price argument exception");
                _price = value; 
            }
        }
        
        public Product(string name, Unit unit, double price) 
        {
            Name = name;
            ProductUnit = unit;
            Price = price;
        }
    }
}
