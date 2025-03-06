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

        public HomeAppliances()
        {

        }
        public HomeAppliances(string line)
        {
            string[] values = line.Split(',');
            Name = values[0];
            UnitPrice = decimal.Parse(values[1]);
            Code = values[2];
            IsElectric = bool.Parse(values[3]);
            Brand = values[4];
            Model = values[5];
        }
        public string ToCsvString()
        {
            return $"{Name},{UnitPrice},{Code},{IsElectric},{Brand},{Model}";
        }
        public override string ToString()
        {
            return $"{Name} {UnitPrice} {Code} Is Electric: {(IsElectric ? "yes" : "no")} {Brand} {Model}";
        }
    }
}
