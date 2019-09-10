using System;
using System.Collections.Generic;
using System.Data;

namespace NotePaDio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary poc
            Dictionary<int, string> someDictionary = new Dictionary<int, string>();
            someDictionary.Add(1, "One");
            someDictionary.Add(2, "Two");
            someDictionary.Add(3, "Three");

            Dictionary<int, string> secondDictionary = new Dictionary<int, string>();
            secondDictionary.Add(1, "One");
            secondDictionary.Add(2, "Two");
            secondDictionary.Add(3, "Three");

            Dictionary<string, Dictionary<int, string>> bigDictionary = new Dictionary<string, Dictionary<int, string>>();
            bigDictionary.Add("BigOne", someDictionary);
            bigDictionary.Add("BigTwo", secondDictionary);

            Dictionary<int, string> smallDictionary;
            if (bigDictionary.TryGetValue("BigOne", out smallDictionary))
            {
                smallDictionary.Remove(1);
            }

            foreach (var item in bigDictionary)
            {
                foreach (var smallItem in item.Value)
                {
                    Console.WriteLine(smallItem.Value);
                }
            }

            foreach (var item in smallDictionary)
            {
                Console.WriteLine(item.Value);
            }

            foreach (var item in someDictionary)
            {
                Console.WriteLine(item.Value);
            }

            // Out keyword poc
            Console.Write("Type a number: ");
            var userInput = Console.ReadLine();
            bool succeeded = int.TryParse(userInput, out int result);
            if (succeeded)
            {
                Console.WriteLine($"{result} + 4 = {result*4}");
            }

            GetUpdate();
        }

        /// <summary>
        /// To get some updates, call this method
        /// </summary>
        public static void GetUpdate()
        {
            Console.WriteLine("Helloooooow");
        }
    }
}
