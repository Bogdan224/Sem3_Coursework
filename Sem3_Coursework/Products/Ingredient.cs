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
        public double NetWeight { get; set; }
        public double GrossWeight { get; set; }
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
