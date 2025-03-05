using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmas.Models
{
    public class HomeAppliances : Product
    {
        public bool IsElectric { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"{Name} {UnitPrice} {Code} Is Electric: {(IsElectric ? "yes" : "no")} {Brand} {Model}";
        }
    }
}
