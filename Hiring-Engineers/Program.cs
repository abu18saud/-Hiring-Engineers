using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiring_Engineers
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> candidates = new HashSet<string>();

            candidates.Add("John");
            candidates.Add("Amelie");
            candidates.Add("Tom");
            candidates.Add("Richard");
            candidates.Add("Barbara");
            candidates.Add("Susan");
            candidates.Add("Charles");
            candidates.Add("Daniel");
            candidates.Add("Tamara");
            candidates.Add("Donald");

            HashSet<string> hiring = new HashSet<string>();

            while (hiring.Count < 3)
            {
                string hire = Console.ReadLine();
                //add the names to hiring hash set
                hiring.Add(hire);
            }
            //your code goes here
            if (hiring.IsSubsetOf(candidates))
            {
                Console.WriteLine("Starting hiring process");
            }
            else
            {
                Console.WriteLine("Something is wrong");
            }


            /*
            HashSet<int> hs = new HashSet<int>();
            
            hs.Add(5);
            hs.Add(10);
            hs.Add(15);
            hs.Add(20);
            Console.Write("\nHashSet: ");
            foreach (int i in hs)
                Console.Write(i + " ");  // 5  10  15  20  *elements may be in any order
            Console.Write("\nCount: " + hs.Count);  // 4
            
            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(1);
            hs2.Add(20);
            Console.Write("\n{15, 20} is a subset of {5, 10, 15, 20}: " + hs2.IsSubsetOf(hs)); // True 
             */
        }
    }
}
