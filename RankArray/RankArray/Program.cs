using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = Array.CreateInstance(typeof(string), 2, 3);
            array.SetValue("Ali", 0, 0);
            array.SetValue("Owais", 0, 1);
            array.SetValue("Abdullah", 0, 2);
            array.SetValue("Asad", 1, 0);
            array.SetValue("Hamza", 1, 1);
            array.SetValue("Usman", 1, 2);

            //Console.WriteLine("No of rows:" +array.GetLength(0));
            //Console.WriteLine("No of Columns:" + array.GetLength(1));
            //Console.WriteLine("Enter names :");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        string name = Console.ReadLine();
            //        array.SetValue(name, i, j);
            //    }
            //}

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array.GetValue(i, j));

                }
            }
            Console.WriteLine("Rank of array :"+array.Rank);
            Console.ReadLine();
       
        }
    }
}
