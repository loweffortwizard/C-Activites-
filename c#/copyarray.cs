//importing libs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ArrayCopytoAnother
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
	            prog will be one array from 1 to 10.
	            and another array that copies from the original array.
            */

            //int type array arrary1 has value of defined numbers.
            int[] array1 = new int[] { 4, 5, 2, 3, 1, 0, 8, 9, 7, 6 };

            //int type array array2 has a lenght value of array1 but no assigned data. 
            int[] array2 = new int[array1.Length];

            //copying values from array1 to array2.

            //for every time array1value is less than the lenght of array1, do the loop, 
            //then increment array1value after loop completion.
            for (int indexno = 0; indexno < array1.Length; indexno++)
            {
                //array2 element number defiend by indexno has the 
                //same value as array1's element, based on indexno.
                array2[indexno] = array1[indexno];

                //print content of first array.
                foreach (int index in array1);
                {
                    Console.WriteLine("Array 1 Element value: " + array1[indexno] + "\n");
                    Thread.Sleep(600);
                }//end of foreach

                //print content of first array.
                foreach (int index in array2);
                {
                    Console.WriteLine("Array 2 Element value: " + array2[indexno] + "\n");
                    Thread.Sleep(600);
                }//end of foreach

            }//end of for

            //end console.
            Console.ReadKey();
        }
    }
}
