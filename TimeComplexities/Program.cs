/* 
Dev: Zach Gilmore
Date: 2/5/22
For: Data Structures and Algorithms
Purpose: To demonstrate Time Complexities
*/

using System;
using static System.Console;

namespace TimeComplexities
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 1000001;              //Delcare array size as a var for easy typing
            int testSize = 10;
            int[] ary = new int[size];       //Use size variable for the ary

            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = i;                 //Populating the array with a for loop using index value

                //Write(ary[i] + " ");
            }

            //Instantiating class object
            AsymptoticAnalysis ace = new AsymptoticAnalysis();

            //Just testing the method
            //ace.populateAry();

            //Class method calls
            WriteLine("\nN found in {0} iterations.\n", ace.linear(ary));
            WriteLine("N found in {0} iterations.\n", ace.constant(ary));
            WriteLine("\nSolution found in {0} iterations.\n", ace.logarithm(ary));
            WriteLine("\nN found in {0} iterations.\n", ace.quadratic(ary));
        }
    }
}
