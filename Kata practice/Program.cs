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
            Console.WriteLine("3. InputLetters (Input 3 letters and print in reverse order\n");

            int UserInput = int.Parse(Console.ReadLine());

            if(UserInput == 1)
            {
                ArrayAverage();
            }

            if(UserInput == 2)
            {
                ListAverage();
            }

            if(UserInput == 3)
            {
                InputLetters();
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

        static void InputLetters()
            //this method gets input from the user, verifies that it is valid, and prints it in reverse order.
        {
            Console.WriteLine("Input a letter");
            string l1 = Console.ReadLine();
            bool result = l1.All(Char.IsLetter);

            if(result == !true)
            {
                Console.WriteLine("Invalid input");
                InputLetters();
            }
            else

            Console.WriteLine("Input a letter");
            string l2 = Console.ReadLine();

            bool result2 = l2.All(Char.IsLetter);

            if (result2 == !true)
            {
                Console.WriteLine("Invalid input");
                InputLetters();
            }
            else
            Console.WriteLine("Input a letter");
            string l3 = Console.ReadLine();

            bool result3 = l3.All(Char.IsLetter);

            if (result3 == !true)
            {
                Console.WriteLine("Invalid input");
                InputLetters();
            }
            else
            Console.WriteLine("{0} {1} {2}", l3, l2, l1);

            Console.ReadLine();
            Menu();
        }

    }
}
