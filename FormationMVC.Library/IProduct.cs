using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationMVC.Library
{
    public interface IProduct
    {
        int Id { get; set; }
        int StockCount { get; set; }
        double Price { get; set; }
    }
}
