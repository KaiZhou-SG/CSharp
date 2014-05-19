using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdEvent00
{
    /// <summary>
    /// The PriceChangedEventArgs, which inherites from EventArgs. 
    /// It will serve as 
    /// </summary>
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal OldPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal oldPrice, decimal newPrice)
        {
            this.OldPrice = oldPrice;
            this.NewPrice = newPrice;
        }
    }
}
