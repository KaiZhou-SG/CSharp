using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cmdEvent00
{
    /// <summary>
    /// The Stock class.
    /// </summary>
    public class Stock : Asset
    {
        public decimal OldPrice { get; set; }
        public decimal NewPrice
        {
            get { return CurrentPrice; }
            set 
            {
                if (CurrentPrice == value)
                {
                    return;
                }
                else
                {
                    OldPrice = CurrentPrice;
                    CurrentPrice = value;
                    // 
                    OnPriceChanged(new PriceChangedEventArgs(OldPrice, CurrentPrice));
                }
            }
        }

        /// <summary>
        /// The constructor which only initialize the Name property.
        /// </summary>
        /// <param name="Name">The name of the Stock.</param>
        public Stock(string Name) : base(Name) { }

        /// <summary>
        /// The constructor which initialize all properties.
        /// </summary>
        /// <param name="oldPrice">The old price of this Stock.</param>
        /// <param name="newPrice">The new price of this Stock.</param>
        public Stock(string Name, decimal oldPrice, decimal newPrice)
        {
            this.Name = Name;
            this.OldPrice = oldPrice;
            this.NewPrice = newPrice;
        }

        /// <summary>
        /// The event: PriceChanged
        /// </summary>
        public EventHandler<PriceChangedEventArgs> PriceChanged;

        /// <summary>
        /// The delegate: OnPriceChanged.
        /// This delegate is used to invoke another function to
        /// do the actual work when the PriceChanged EventHandler
        /// is invoked.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            if (PriceChanged != null)
            {
                PriceChanged(this, e);
            }
        }

        public void Stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            Debug.WriteLine("Price changed.");
        }
    }
}
