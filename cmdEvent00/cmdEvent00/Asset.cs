using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdEvent00
{
    /// <summary>
    /// The Asset class.
    /// </summary>
    public class Asset
    {
        public string Name { get; set; }
        public decimal CurrentPrice { get; set; }

        public Asset()
        {
            this.Name = String.Empty;
        }

        public Asset(string Name)
        {
            this.Name = Name;
        }

        public Asset(string strName, decimal currentPrice)
        {
            this.Name = strName;
            this.CurrentPrice = currentPrice;
        }
    }
}
