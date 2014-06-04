using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdEvent01
{
    /// <summary>
    /// The AgeChangedEventArgs class, which inherits from the
    /// EventArgs class. It's a customized EventArgs object type.
    /// </summary>
    public class AgeChangedEventArgs : EventArgs
    {
        public readonly int CurrentAge;
        public readonly int NewAge;

        public AgeChangedEventArgs(int currentAge, int newAge)
        {
            this.CurrentAge = currentAge;
            this.NewAge = newAge;
        }
    }
}
