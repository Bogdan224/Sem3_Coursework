using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Coursework.Products
{
    public enum ProductGroup
    {
        FirstCourse, SecondCourse, Dessert, Drink, Snack, Pastry, Baking
    }

    /// <summary>
    /// Класс описывающий свойства готовой продукции
    /// </summary>
    public class FinalProduct
    {
        public string Name { get; set; }
        public ProductGroup Group { get; set; }
        private double price;
        public double Price {
            get
            {
                return price;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price out of range!");
                }
                price = value;
            }
        }
        public string Description { get; set; }
        public Uri Photo { get; set; }
        public List<Ingredient> Receipt { get; set; }
        
        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="group">Группа</param>
        /// <param name="price">Цена</param>
        /// <param name="description">Описание</param>
        /// <param name="photo">Uri фотографии</param>
        /// <param name="receipt">Список ингредиентов, использующихся в продукте</param>
        public FinalProduct(string name, ProductGroup group, double price, string description, Uri photo, List<Ingredient> receipt)
        {
            Name = name;
            Group = group;
            Price = price;
            Description = description;
            Photo = photo;
            Receipt = receipt;
        }

        public override string ToString()
        {
            string res = $"Название: {Name}\n" +
                $"Группа: {Group}\n" +
                $"Цена: {Price} руб.\n" +
                $"Описание: {Description}\n" +
                $"Uri фото: {Photo}\n" +
                $"Рецепт:\n";
            int x = 1;
            foreach (var item in Receipt)
            {
                res += $"Ингредиент {x}\n";
                res += item.ToString();
                x++;
            }
            return res;
        }
    }
}
