using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdEvent00
{
    /// <summary>
    /// 2014-05-19 Zhou Kai writes this program to 
    /// learn and practice the concepts of delegate, Event, 
    /// EventArgs and EventHandler
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            Stock stock = new Stock("EZhou");

            stock.PriceChanged += stock.Stock_PriceChanged;
            stock.NewPrice = 100;
            
        }
    }
}
