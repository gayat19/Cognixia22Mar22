using System;
using System.Collections.Generic;

namespace UnderstandingCollectionApp
{
    internal class Program
    {
        void UnderstandingList()
        {
            int[] numArr = new int[10];
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(40);
            numbers.Add(89);
            numbers.Add(40);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Item in postion 2 "+numbers[2]);

        }
        void UndertsndingDictionary()
        {
            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(1, "One");
            keyValuePairs.Add(2, "One");
            keyValuePairs.Add(3, "Three");
            Console.WriteLine("Keys");
            foreach (var item in keyValuePairs.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Values");
            foreach (var item in keyValuePairs.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Values using Keys");
            foreach (var item in keyValuePairs.Keys)
            {
                Console.WriteLine(keyValuePairs[item]);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.UndertsndingDictionary();
            Console.WriteLine("Hello World!");
        }
    }
}
