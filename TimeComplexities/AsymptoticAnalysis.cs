using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TimeComplexities
{
    class AsymptoticAnalysis
    {
        private int[] thisAry = new int[10];
        private int n = 0;        

        //Just making a method to populate the array, in case I needed it. Works exactly like the one in the main class.
        public void populateAry()
        {
            for (int i = 0; i < thisAry.Length; i++)
            {
                thisAry[i] = i;                 //Populating the array with a for loop using index value

                //Write(ary[i] + " ");
            }
        }

        //Method prompts user for input and converts ReadLine() to int so I don't have to keep typing this
        private void userPrompt()
        {
            Write("Enter which value you wish to search for between 1 and 1,000,000: ");    //Prompt for input
            n = Convert.ToInt32(ReadLine());                                        //Converting ReadLine to an int
        }

        public int linear(int[] ary)
        {
            int steps = 0;

            WriteLine("Linear:");       //Identifies which method is currently being printed to user
            userPrompt();

            for (int i = 0; i < ary.Length; i++)
            {
                steps++;                //Count each iteration
                Write(ary[i] + " ");    //Print each element

                if (ary[i] == n)        //Break loop if the element is found
                {
                    break;
                }
            }
            return steps;
        }

        public int constant(int[] ary) 
        {
            int steps = 0;

            WriteLine("Constant:");
            userPrompt();
            
            int c = (n/2) * (1 + n); //constant formula
            steps++;

            return steps;
        }

        public int logarithm(int[] ary) //aka Binary search
        {
            int steps = 0;
            int mid = 0;      //Iteration starting point
            int low = 0;
            int high = ary.Length;
            
            WriteLine("Logarithmic:");
            userPrompt();

            try
            {
                while (high >= low)     //Looping through the ary
                {
                    steps++;                            //Count the iteration
                    mid = (low + high) / 2;             //Finding the middle ground

                    if (ary[mid] == n)                   //If n is found
                    {
                        Write("Element found at index: {0}", mid);
                        return steps;                     //Return that value
                    }
                    else if (ary[mid] > n)               //If n is less than mid
                    {
                        high = mid - 1;                 //Set new high to one less then old mid index
                    }
                    else if (ary[mid] < n)               //If n is greater than mid
                    {
                        low = mid + 1;                  //Set new low to one more than old mid index
                    }
                }
            }
            catch(Exception e)  //For out of bounds exceptions
            {
                Write(e);
            }

            Write("Element not found.");            //Occurs when element is not found in array.
            return steps;
        }

        public int quadratic(int[] ary)
        {
            int steps = 0;
            string[] letters = { "a", "b", "c" };       //Setting up a second array for the nested loop

            WriteLine("Quadratic:");
            userPrompt();

            for (int i = 0; i < ary.Length; i++)
            {
                Write(ary[i] + " ");                    //Printing out the first element in the loop

                if (n == ary[i])
                {
                    break;                              //Break out of loop if key is found
                }

                steps++;                                //Count iterations on each for loop

                for (int j = 0; j < letters.Length; j++) //Second loop
                {
                    Write(ary[i] + letters[j] + " ");
                    steps++;
                }
            }

            return steps;
        }
    }
}
