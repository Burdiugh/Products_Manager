using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_Multi_forms
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Country { get; set; }
        public decimal Value { get; set; }
        public decimal Discount { get; set; }
        public Product()
        {

        }
        public Product(string n,decimal p,string c, decimal v, decimal d)
        {
            Name = n;
            Price = p;
            Country = c;
            Value = v;
            Discount = d;
        }
        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price}\n\n";
                
        }
    }   
}
