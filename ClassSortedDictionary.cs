using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project11_2
{
    internal class ClassSortedDictionary
    {
        public ClassSortedDictionary() { }

        public static SortedDictionary<string, int> CollectWords(string input)
        {

            SortedDictionary<string, int> dictionary =
               new SortedDictionary<string, int>();


            //auto checks for any '&' or ' ' in a string in order to remove it
            if (input.Contains(" ") || input.Contains("&"))
            {
                
                string[] words = Regex.Split(input, @"[&\s]+");

                foreach (var word in words)
                {
                    string wordKey = word.ToLower();

                    if (dictionary.ContainsKey(wordKey))
                    {
                        ++dictionary[wordKey];
                    }
                    else
                    {
                        dictionary.Add(wordKey, 1);
                    }
                }
            }
            return dictionary;
        }


        public static void DisplayDictionary<K, V>(
           SortedDictionary<K, V> dictionary)
        {
            Console.WriteLine("\nSorted dictionary contains:\n{0,-12}{1,-12}",
               "Key:", "Value:");

            foreach (K key in dictionary.Keys)
                Console.WriteLine("{0,-12}{1,-12}", key, dictionary[key]);

            Console.WriteLine("\nsize: {0}", dictionary.Count);
        }

    }//end-class
}//end-namespace
