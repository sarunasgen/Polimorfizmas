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

        public override string ToString()
        {
            return $"{Name} {UnitPrice} {Code} Fruit Weight: {WeightInGrams}g";
        }
    }
}
