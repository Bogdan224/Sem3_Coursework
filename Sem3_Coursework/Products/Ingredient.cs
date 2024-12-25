using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Coursework.Products
{
    public class Ingredient : IComparable<Ingredient>
    {
        private double netWeight;
        public double NetWeight 
        {
            get
            {
                return netWeight;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException();
                }
                netWeight = value;
            }
        }
        private double grossWeight;
        public double GrossWeight 
        {
            get
            {
                return grossWeight;
            }
            set
            {
                if( value < 0 )
                {
                    throw new ArgumentException();
                }
                grossWeight = value;
            }
        }

        public ProductSuply IngredientProduct { get; set; }
        public Ingredient(double netWeight, double grossWeight, ProductSuply product)
        {
            NetWeight = netWeight;
            GrossWeight = grossWeight;
            IngredientProduct = product;
        }

        public int CompareTo(Ingredient other)
        {
            if (other == null) throw new ArgumentNullException();
            return IngredientProduct.Name.CompareTo(other.IngredientProduct.Name);
        }
        public override string ToString()
        {
            return $"Название: {IngredientProduct.Name}\n" +
                $"Вес нетто: {NetWeight} г.\n" +
                $"Вес брутто: {GrossWeight} г.\n";
        }
    }
}
