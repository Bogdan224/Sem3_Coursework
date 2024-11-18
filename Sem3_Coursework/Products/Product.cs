using System;

namespace Sem3_Coursework.Products
{
    public enum Units
    {
        kg, pc
    }
    ///<summary>Запасы продуктов питания, которые хранятся на складе и используются в качестве ингредиентов при приготовлении пищи</summary>
    public class Product
    {
        ///<summary>Название продукта</summary>
        public string Name { get; set; }

        ///<summary>Единица измерения</summary>
        public Units Unit { get; set; }

        private double pricePremium;

        ///<summary>Ценовая надбавка (в процентах)</summary>
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

        /// <summary>Остаток на складе</summary>
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

        /// <summary>Поставщик</summary>
        public Provider Provider { get; set; }

        /// <param name="name">Название продукта</param>
        /// <param name="unit">Единица измерения</param>
        /// <param name="pricePremium">Ценовая надбавка (в процентах)</param>
        /// <param name="stockBalance">Остаток на складе</param>
        /// <param name="provider">Поставщик</param>
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
