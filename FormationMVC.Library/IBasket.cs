using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationMVC.Library
{
    public interface IBasket
    {
        List<IProduct> Products { get; set; }

        void Add(IProduct product);

        void Remove(IProduct product);


    }
}
