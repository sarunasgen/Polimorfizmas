using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmas.Models
{
    public class Fruit : Product
    {
        public int WeightInGrams { get; set; }
        public Fruit()
        {

        }
        public Fruit(string line)
        {
            string[] values = line.Split(',');
            Name = values[0];
            UnitPrice = decimal.Parse(values[1]);
            Code = values[2];
            WeightInGrams = int.Parse(values[3]);
        }
        public string ToCsvString()
        {
            return $"{Name},{UnitPrice},{Code},{WeightInGrams}";
        }

        public override string ToString()
        {
            return $"{Name} {UnitPrice} {Code} Fruit Weight: {WeightInGrams}g";
        }
    }
}
