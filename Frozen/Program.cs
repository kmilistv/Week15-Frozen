using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;
           

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;

            }

            public string Name
            {
                get { return name; }
            }
            public string Gift
            {
                get { return gift; }
            }
        }
        static void Main(string[] args)
        {
            List<SecretSanta> myWishes = new List<SecretSanta>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newWish = new SecretSanta(tempArray[0], tempArray[1]);
                myWishes.Add(newWish);
            }

            foreach (SecretSanta wishesFromList in myWishes)
            {
                Console.WriteLine($"{wishesFromList.Name} wants {wishesFromList.Gift} for Christmas");
            }
        }

        public static void DisplayElementFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\Kool\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
