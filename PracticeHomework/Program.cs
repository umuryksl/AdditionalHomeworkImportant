using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double avg = 0;
            double total = 0;

            int[] myarrays = new int[16];



            do
            {

                Console.WriteLine("Please enter a number...");

                String line = Console.ReadLine();

                if (line == "Quit")
                {

                    Console.WriteLine("You are quiting the system");
                    System.Environment.Exit(0);

                }

                int readed_number = int.Parse(line);

                int checked_number = check_number_greater(readed_number);

                myarrays[i] = checked_number;

                i++;


            } while (i <= 15);






            for (int y = 1; y <= myarrays.Length - 1; y++)
            {

                Console.WriteLine(myarrays[y]);

                total = total + myarrays[y];


            }

            avg = total / myarrays.Length - 1;

            Console.WriteLine("Average of array is" + " " + avg);



            Console.ReadKey();

        }





        static int check_number_greater(int z)
        {

            if (z > 80)
            {

                z += 7;

            }
            if (z < 50)
            {

                z -= 10;
            }

            return z;

        }
    }
}

