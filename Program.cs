using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);
            Console.WriteLine("LIST 1: " + numbers.Count);

            var numbers2 = new List<int>() { 2, 3, 5, 7 };
            Console.WriteLine("LIST 2: " + numbers2.Count);
            Console.WriteLine("--------");


            List<int> list = new List<int>() { 2, 3, 7 };
            foreach (int prime in list)
            {
                System.Console.WriteLine("PRIME ELEMENT: {0}", prime);

            }
            Console.WriteLine("--------");


            List<int> list1 = new List<int>(new int[] { 2, 3, 7 });
            Console.WriteLine($"FIRST ELEMENT: {list[0]}");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"{i} = {list1[i]}");
            }
            Console.WriteLine("--------");


            var votes = new List<bool> { false, false, true };
            for (int i = votes.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("DECREMENT LIST LOOP: {0}", votes[i]);
            }
            Console.WriteLine("--------");


            var animals = new List<string>() { "bird", "dog" };
            animals.InsertRange(1, new string[] { "frog", "snake" });
            foreach (string value in animals)
            {
                Console.WriteLine("RESULT: " + value);
            }
            Console.WriteLine("--------");


            List<bool> list2 = new List<bool>();
            list2.Add(true);
            list2.Add(false);
            list2.Add(true);
            Console.WriteLine(list.Count);
            list.Clear();
            Console.WriteLine(list.Count);
            Console.WriteLine("--------");


            int[] array = new int[] { 2, 3, 5 };
            List<int> copied = new List<int>(array);
            Console.WriteLine("COPIED COUNT: {0}", copied.Count);
            Console.WriteLine("--------");


            var values = new List<int>() { 200, 300, 500 };
            if (ContainsValue300(values))
            {
                Console.WriteLine("RETURNED TRUE");
            }

            static bool ContainsValue300(List<int> list)
            {
                foreach (int number in list)
                {
                    if (number == 300)
                    {
                        return true;
                    }
                }
                return false;
            }
            Console.WriteLine("--------");


            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Mumbai");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            string line = string.Join(",", cities.ToArray());
            Console.WriteLine(line);
            Console.WriteLine("--------");


            List<string> dogs = new List<string>();
            dogs.Add("spaniel"); 
            dogs.Add("beagle"); 
            dogs.Insert(1, "dalmatian");
            foreach (string dog in dogs)
            {
                Console.WriteLine(dog);
            }
            Console.WriteLine("--------");


            var numbers1 = new List<int>() { 10, 20, 30 };
            numbers.Remove(20);
            foreach (int number in numbers1)
            {
                Console.WriteLine("NOT REMOVED: {0}", number);
            }
            numbers1.Remove(2000);
            Console.WriteLine("--------");


            List<string> list3 = new List<string>();
            list3.Add("anchovy");
            list3.Add("barracuda");
            list3.Add("bass");
            list3.Add("viperfish");
            list3.Reverse();
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("--------");


            List<string> rivers = new List<string>(new string[]
        {
            "nile",
            "amazon", 
            "yangtze", 
            "mississippi",
            "yellow"
        });
            List<string> range = rivers.GetRange(1, 2);
            foreach (string river in range)
            {
                Console.WriteLine(river);
            }
            Console.WriteLine("--------");


            var numbers3 = new List<int> { 10, 20, 30 };
            var numbers4 = new List<int> { 10, 20, 30 };
            if (numbers3.SequenceEqual(numbers4))
            {
                Console.WriteLine("LISTS ARE EQUAL");
            }



        }
    }
}


