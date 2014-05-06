using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdDictionary00
{
    /// <summary>
    /// 2013-12-17 Zhou Kai creates class to test the 
    /// usage of Dictionary
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("One", "1");
            dict.Add("Two", "2");
            dict.Add("Three", null); // you can add null into dictionary
            dict.Add("Four", null);

            try
            {
                Console.WriteLine("One = {0}\nTwo = {1}\nThree = {2}\nFour = {3}.",
                    dict["One"], dict["Two"], dict["Three"], dict["Four"]);
            }
            catch (NullReferenceException ne) // no exception occurs
            {
                Console.WriteLine("NullReferenceException occurs.");
            }

            if (object.ReferenceEquals(dict["Three"], null)) // the value equals with null
            {
                Console.WriteLine("The value of dict[\"Three\"] is null.");
            }

            if (object.ReferenceEquals(dict["Four"], null))
            {
                Console.WriteLine("The value of dict[\"Four\"] is null.");
            }

            if (dict["Three"] == String.Empty)
            {
                Console.WriteLine("dict[\"Three\"] == String.Empty");
            }

            try
            {
                dict.Add("One", "I want to try if I can add to same keys.");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Sorry, you're not going to be allowed to insert duplicated keys.");
            }

            try
            {
                dict["One"] = "Now, I'm going to modify the value in dictionary by the key.";
                Console.WriteLine("Now, the value of \"One\" in dictionary is: {0}.", dict["One"]);
            }catch (Exception e)
            {
                Console.WriteLine("What? I even can't modify the value in dictionary?");
            }

            try
            {
                // trying to get a value from a non-existing key
                string tmp = dict["Hundred"];
            }catch (KeyNotFoundException knfe)
            {
                Console.WriteLine("Sorry, but the key doesn't exists yet.");
            }

            Console.ReadLine();
        }
    }
}
