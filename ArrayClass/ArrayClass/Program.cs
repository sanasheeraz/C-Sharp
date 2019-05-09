using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = Array.CreateInstance(typeof(string), 2,2);
            array.SetValue("Ali", 0, 0);
            array.SetValue("Asad", 0, 1);
            array.SetValue("Anum", 1, 0);
            array.SetValue("Maryam", 1, 1);

            for (int i = 0; i < array.GetLength(0);i++ )
            {
                for(int j=0; j<array.GetLength(1);j++)
                {
                    Console.WriteLine(array.GetValue(i, j));
                }

            }

            bool b=array.IsFixedSize;
            Console.WriteLine("Array is of fixed Size :" + b);

            b = array.IsReadOnly;
            Console.WriteLine("Array is of Read Only :" + b);

            int a = array.Rank;
            Console.WriteLine("Array is of Rank :" + a);

            Console.ReadKey();
        }
    }
}
