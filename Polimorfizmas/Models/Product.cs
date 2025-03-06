using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmas.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Code { get; set; }

        public override string ToString()
        {
            return $"{Name} {UnitPrice} {Code}";
        }

        public override bool Equals(object? obj)
        {
            return ((Product)obj).Code == Code;
        }
        public virtual string ToCsvString() 
        { 
            return string.Empty; 
        }
    }
}
