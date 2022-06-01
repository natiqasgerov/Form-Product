using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class Product
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Cost { get; set; }
        public Product()
        {

        }

        public override string ToString() => $"{Name}";
    }
}
