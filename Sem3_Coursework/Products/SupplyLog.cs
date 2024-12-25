using System;
using System.Collections.Generic;

namespace Sem3_Coursework.Products
{
    [Serializable]
    /// <summary>Полученный продукт с поставки</summary>
    public class ObtainedProduct
    {
        public ProductSuply ProductSuply { get; set; }
        private double totalPrice;
        /// <summary>Общая цена</summary>
        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                totalPrice = value;
            }
        }
        private int count;
        /// <summary>Кол-во поставленных продуктов</summary>
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                count = value;
            }
        }
        public ObtainedProduct(ProductSuply productSuply, double totalPrice, int count) 
        {
            TotalPrice = totalPrice;
            Count = count;
        }
    }
    [Serializable]
    /// <summary>Класс для регистрации поступления продуктов питания на склад</summary>
    public class SupplyLog
    {
        /// <summary>Поставщик</summary>
        public Provider Provider { get; set; }
        private DateTime date;
        /// <summary>Дата и время поставки</summary>
        public DateTime Date 
        {
            get
            {
                return date;
            }
            set
            {
                if(value > DateTime.Now) throw new ArgumentException("SupplyLog.Date argument exception");
                date = value;
            } 
        }
        /// <summary>Поставленные продукты</summary>
        public List<ObtainedProduct> ObtainedProducts { get; set; }
        public SupplyLog(Provider provider, DateTime date, List<ObtainedProduct> obtainedProducts)
        {
            Provider = provider;
            Date = date;
            ObtainedProducts = obtainedProducts;
        }

    }
}
