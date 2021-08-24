using System.Collections.Generic;
using System;

namespace EX14Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> ages = new List<int>();

            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);

            List<string> names = new List<string>();

            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");

            names.Insert(3, "Anders");
            names.Insert(3, "Lars");

            List<double> percentages = new List<double>() {0.75, 0.23, 0.86, 0.17};

            List<bool> areMarried = new List<bool>() {true, false, false, true, true};

            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (double percentage in percentages)
            {
                Console.WriteLine(percentage);
            }

            foreach (bool isMarried in areMarried)
            {
                Console.WriteLine(isMarried);
            }
            */

            //Opgave 14.5

            List<int> ages = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };

            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            ages.Remove(13);
            ages.Remove(15);

            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            ages.RemoveAt(3);

            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
        }
    }
}
