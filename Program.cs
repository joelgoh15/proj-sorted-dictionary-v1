using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("an applica");
            
            SortedDictionary<string, int> dictionary;
            string input; 
            input = "This  is & an& example & string";
            
            dictionary = ClassSortedDictionary.CollectWords(input);
            ClassSortedDictionary.DisplayDictionary(dictionary);

            //exit application
            Console.ReadLine();

        }//end-main

    }//end-class
}//end-namespace
