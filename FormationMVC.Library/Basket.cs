using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationMVC.Library
{
    public class Basket : IBasket
    {
        public List<IProduct> Products { get; set; }

        public Basket()
        {
            Products = new List<IProduct>();
        }

        public void Add(IProduct product)
        {
            Products.Add(product);
        }

        public void Remove(IProduct product)
        {
            Products.Remove(product);
        }
    }
}
