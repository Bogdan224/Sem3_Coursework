using System;
using System.Collections.Generic;
using Newtonsoft.Json;
/*
    При регистрации поступления продуктов питания на склад требуется заносить следующую информацию по каждой поставке: поставщик; дата поставки;
    перечень полученных продуктов (с указанием названия, единицы измерения, закупочной цены и количества для каждой позиции).
*/

namespace Sem3_Coursework.Products
{
    /// <summary>Полученный продукт с поставки</summary>
    public class ObtainedProduct
    {
        /// <summary>Название продукта</summary>
        public string Name { get; set; }
        /// <summary>Единица измерения</summary>
        public Units Unit { get; set; }
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
        public ObtainedProduct(string name, Units unit, double totalPrice, int count)
        {
            Name = name;
            Unit = unit;
            TotalPrice = totalPrice;
            Count = count;
        }
    }
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
                if(value > DateTime.Now)
                {
                    throw new ArgumentException("Date argument exception!");
                }
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
