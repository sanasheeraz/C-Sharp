using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add(5, "Five");
            list.Add(2, "Two");
            list.Add(3, "Three");
            list.Add(1, "One");
            list.Add(6, "Six");
            Console.WriteLine("Original values stored in the sorted list");
            Console.WriteLine("Key \t\t Values");
            for (int i=0; i<list.Count; i++)
            {
            Console.WriteLine(list.GetKey(i) + " \t\t " + list.GetByIndex(i));
            }
            Console.ReadKey();
        }
    }
}
