using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Coursework.Products
{
    public enum Units
    {
        kg, pc
    }
    public class Product
    {
        public string Name { get; set; }
        public Units Unit { get; set; }
        private double pricePremium;
        public double PricePremium
        {
            get
            {
                return pricePremium;
            }
            set
            {
                if (value < 0) throw new ArgumentException("PricePremium argument exception!");
                pricePremium = value;
            }
        }
        private double stockBalance;
        public double StockBalance
        {
            get
            {
                return stockBalance;
            }
            set
            {
                if (value < 0) throw new ArgumentException("StockBalance argument exception!");
                stockBalance = value;
            }
        }
        public Provider Provider { get; set; }
        public Product(string name, Units unit, double pricePremium, double stockBalance, Provider provider)
        {
            Name = name;
            Unit = unit;
            PricePremium = pricePremium;
            StockBalance = stockBalance;
            Provider = provider;
        }
    }
}
