using System;

namespace DailySolution2
{
    class MainClass
    {
        const int THIRTY = 30;

        public static void Main(string[] args)
        {
            int[] vars = new int[THIRTY];
            string line;
            bool is_num;
            int count = 0;

            Console.WriteLine("Please enter your numbers, then type '!' to end.");

            while(!(line = Console.ReadLine()).Equals("!")) {
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

        public static void ArrayProduct(ref int[] vars, int count) {
            int[] temp_vars = new int[THIRTY];

            for (int i = 0; i < count; i++) {
                temp_vars[i] = vars[i];
            }

            int temp_num = 1;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (!(i == j))
                    {
                        temp_num *= temp_vars[j];
                    }

                    if(j == (count - 1)) {
                        vars[i] = temp_num;
                        temp_num = 1;
                    } 
                }
            }
        }
    }
}
