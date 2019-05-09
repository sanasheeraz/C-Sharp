using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = new int[10];//array is created 
            int counter = 0; 
            for(int i = 0; i< 10; i++) 
            { 
            count[i] = counter++; 
                //values are assigned to the elements 
            Console.WriteLine("The count value is: " + count[i]); 
            //element values are printed 
            }


            Console.WriteLine("Multi Dimentional Array ");
            Console.WriteLine("*************************");
            int[,] dimension = new int [4, 5]; 
            int numOne = 0; 
            for (int i=0; i<4; i++) 
            { 
            for (int j=0; j<5; j++) 
            { 
            dimension [i, j] = numOne; 
            numOne++; 
            } 
            } 
            for (int i=0; i<4; i++) 
            { 
            for (int j=0; j<5; j++) 
            { 
            Console.Write(dimension [i, j] + " "); 
            } 
            Console.WriteLine(); 
            } 


            Console.ReadKey();
        }
    }
}
