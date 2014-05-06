using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdEnum00
{
    class Program
    {
        static void Main(string[] args)
        {
            Seasons season = Seasons.Spring;
            // the enum is strange, it can be both int and string format
            Console.WriteLine("season in int is: {0}, in string is: {1}.", (int)season, season.ToString());
            // displays: season in int is: 1, in string is: Spring.
            Console.Read();
        }

    }

    public enum Seasons : int 
    {
        Spring = 1,
        Summer = 2,
        Autum = 3,
        Winter = 4
    }
}

