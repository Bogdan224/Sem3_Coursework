using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Coursework.Products
{
    public class Ingredient : IComparable<Ingredient>
    {
        public string Name { get; set; }
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
                    throw new ArgumentException("NetWeight argument exception!");
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
                    throw new ArgumentException("GrossWeight argument exception!");
                }
                grossWeight = value;
            }
        }
        public Ingredient(string name, double netWeight, double grossWeight)
        {
            Name = name;
            NetWeight = netWeight;
            GrossWeight = grossWeight;
        }

        public int CompareTo(Ingredient other)
        {
            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return $"Название: {Name}\n" +
                $"Вес нетто: {NetWeight} г.\n" +
                $"Вес брутто: {GrossWeight} г.\n";
        }
    }
}
