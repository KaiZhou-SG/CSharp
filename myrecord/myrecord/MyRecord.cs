using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace nsMyRecord
{
    public class MyRecord
    {
        public Int32 ID { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }

        public MyRecord(Int32 id, string name, string country)
        {
            ID = id;
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return ID.ToString() + "," + Name + "," + Country;
        }
    }
}
