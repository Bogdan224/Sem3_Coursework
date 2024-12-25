using System;

namespace Sem3_Coursework.Products
{
    public enum Unit
    {
        kg, pc, None
    }
    ///<summary>
    ///Запасы продуктов питания, которые хранятся на складе и используются в качестве 
    ///ингредиентов при приготовлении пищи
    ///</summary>
    public class ProductSuply : Product
    {
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
        public ProductSuply(string name, Unit unit, double price, double pricePremium, double stockBalance, Provider provider)
            : base(name, unit, price)
        {
            PricePremium = pricePremium;
            StockBalance = stockBalance;
            Provider = provider;
        }
    }
}
