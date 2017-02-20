using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            //this method sums and then averages the contents of an int array

            Console.WriteLine("Type the number of the method you want to run from the following list.\n");

            Console.WriteLine("1. ArrayAverage (Average of number in Array)\n");
            Console.WriteLine("2. ListAverage (Average of numbers in a list)\n");

            int UserInput = int.Parse(Console.ReadLine());

            if(UserInput == 1)
            {
                ArrayAverage();
            }

            if(UserInput == 2)
            {
                ListAverage();
            }

            else Console.WriteLine("\nThat is not a valid input. Please try again\n");
            {
                Menu();
            }
            Console.ReadLine();
        }

        static void ArrayAverage()
        {
            //this method sums and averages the contents of a list

            int[] array = { 10, 15, 20, 30 };
            int x = array.Sum() / 4;
            Console.WriteLine("The average of the sum of 10, 15, 20 and 30 is " + x);
            Console.WriteLine("\n Hit any enter to enter to menu\n");
            Console.ReadLine();
            Menu();
        }

        static void ListAverage()
        {

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Add(30);
            int x = list.Sum() / 4;
            Console.WriteLine("The average of the sum of 10, 15, 20 and 30 is " + x);
            Console.WriteLine("\n Hit any key to enter to menu\n");
            Console.ReadLine();
            Menu();
        }

    }
}
