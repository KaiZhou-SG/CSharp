using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdRefToUnInitialized
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Program pg = new Program();
            if (ReferenceEquals(pg.nc, null))
            {
                Console.WriteLine(pg.msgNullRef); 
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(pg.GetHashCode());
            }
            
            Console.Read();
        }

        public Program()
        {
            msgNullRef = "Variable references to null.";
            id = 100;
        }

        private nestedClass nc;
        public string msgNullRef{get; set;}
        public int id;

        class nestedClass
        {
            private int nId;
            private int nKey;

            public int ID
            {
                get { return nId; }
                set { nId = value; }
            }
        }
    }


    
}
