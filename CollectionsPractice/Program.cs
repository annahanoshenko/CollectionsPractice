using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List <T>

            //int[] ints = new int[] { 1, 2, 3 };
            List<int> intList = new List<int>() { 1, 2, 3 };
            intList.Add(4);

            Print(intList);
            Console.WriteLine(intList[3]);

            intList.Remove(2);
            Console.WriteLine();


            string[] socialNetworksArray = { "YouTube", "FaceBook", "Instagram" }; // adding elements in List from Array

            List<string> socialNetworksList = new List<string>();
            socialNetworksList.AddRange(socialNetworksArray); //AddRange = adding all array elements in List

            List<string> socialNetworks = new List<string>();  

            socialNetworks.Add("YouTube");
            socialNetworks.Add("FaceBook");
            socialNetworks.Add("Instagram");

            socialNetworks.Insert(1, "TikTok");
            socialNetworks.Remove("FaceBook");
            socialNetworks.RemoveAt(3);
            socialNetworks.Sort();

            Console.WriteLine(socialNetworks[0]);

            foreach (string socialNetwork in socialNetworks)
            {
                Console.WriteLine(socialNetwork);
            }

            Console.WriteLine();


                Dictionary<string, int> ages = new Dictionary<string, int>
        {
            {"Alice", 25 },
            {"Bob", 30 }
        };

            ages["Charlie"] = 35;

            foreach (var age in ages)
            {
                Console.WriteLine($"{age.Key}: {age.Value}");
            }

            //LinkedList

            var employees = new List<string> { "Tom", "Sam", "Bob" };

            LinkedList<string> people = new LinkedList<string>(employees);

            var currentNode = people.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            currentNode = people.Last;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine(people.Count); //3
            Console.WriteLine(people.First?.Value); //Tom
            Console.WriteLine(people.Last?.Value); //Bob
            foreach (var employee in people)
            {
                Console.WriteLine(employee);
            }


            var people1 = new LinkedList<string>();
            people1.AddLast("Tom");
            people1.AddFirst("Bob");
            if (people1.First != null) people1.AddAfter(people1.First, "Mike");

            foreach (var person1 in people1) Console.WriteLine(person1);



        }
    }
    static void Print(List<int> list)
    {
        string result = "";
        foreach (int item in list)
        {
            result += item + "";

        }

        Console.WriteLine(result + "");

    }
}

