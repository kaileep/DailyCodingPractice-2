//Kailee Parkinson
//Daily Coding Practice #2
//07-22-2018
//------------------------

using System;

namespace DailySolution2
{
    class MainClass
    {
        //number used to initialize array size
        const int THIRTY = 30;

        public static void Main(string[] args)
        {
            int[] vars = new int[THIRTY];
            string line;
            bool is_num;
            int count = 0;

            //program takes numbers by each line until a '!' is typed
            Console.WriteLine("Please enter your numbers, then type '!' to end.");

            while(!(line = Console.ReadLine()).Equals("!") && count < THIRTY) {
                //makes sure that the user enters a number, keeps trying until number is entered 
                is_num = Int32.TryParse(line, out vars[count]);
                if(!is_num) {
                    Console.WriteLine("Invalid input. Please enter a number or '!' to end!");
                }
                else {
                    count++;
                }
            }

            ArrayProduct(ref vars, count);

            Console.Write("[ " + vars[0]);

            for (int i = 1; i < count; i++) {
                Console.Write(", " + vars[i]);
            }

            Console.Write(" ]");

        }

        /*ArrayProduct method
        *Parameters: reference to array of integers, optional integer count - number of elements in array
        *Description: Takes each element in the array and replaces value with product of all other elements in the array
        */
        public static void ArrayProduct(ref int[] vars, int count = vars.Length) {
            //temporary array to store original values
            int[] temp_vars = new int[THIRTY];

            for (int i = 0; i < count; i++) {
                temp_vars[i] = vars[i];
            }
            
            int temp_num = 1;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    //only run if value is not itself
                    if (!(i == j))
                    {
                        //ends up being the product of all values in the array besides i
                        temp_num *= temp_vars[j];
                    }

                    //replaces value in reference array to product of every other value in array once all values have been stepped through
                    if(j == (count - 1)) {
                        vars[i] = temp_num;
                        temp_num = 1;
                    } 
                }
            }
        }
    }
}
