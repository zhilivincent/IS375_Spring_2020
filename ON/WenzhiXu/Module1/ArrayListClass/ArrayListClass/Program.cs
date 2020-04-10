using System;
using System.Collections;

namespace ArrayListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            a1.Add(45);
            a1.Add(78);
            a1.Add(33);
            a1.Add(56);
            a1.Add(12);
            a1.Add(23);
            a1.Add(9);

            Console.WriteLine("Capacity:{0}", a1.Capacity);
            Console.WriteLine("Count:{0}", a1.Count);

            Console.Write("Content: ");

            foreach (int i in a1)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sorted Content: ");
            a1.Sort();

            foreach (int i in a1)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}
