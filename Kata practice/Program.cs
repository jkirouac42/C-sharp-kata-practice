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

            Console.WriteLine("\nType the number of the method you want to run from the following list.\n");

            Console.WriteLine("1. ArrayAverage() Average of number in Array\n");
            Console.WriteLine("2. ListAverage() Average of numbers in a list\n");
            Console.WriteLine("3. InputLetters() Input 3 letters and print in reverse order\n");
            Console.WriteLine("4. Profile() Create a user profile\n");
            Console.WriteLine("5. FizzBuzz()\n");

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
            if(UserInput == 4)
            {
                Profile();
            }
            if(UserInput == 5)
            {
                FizzBuzz();
            }

            else Console.WriteLine("\nThat is not a valid input. Please try again\n");
            {
                Menu();
            }
            Console.ReadLine();
        }

        static void ArrayAverage()
        {
            //this method sums and averages the contents of an array

            int[] array = { 10, 15, 20, 30 };
            int x = array.Sum() / 4;
            Console.WriteLine("The average of the sum of 10, 15, 20 and 30 is " + x);
            Console.WriteLine("\n Hit enter to return to menu\n");
            Console.ReadLine();
            Menu();
        }

        static void ListAverage()
        {
            //this method sums and averages the contents of a list

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
           
        {
            //this method gets input from the user, verifies that it is valid, and prints it in reverse order.
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
        static void Profile()
        {

            Console.WriteLine("Create your username\n");
            List<string> userProfile = new List<string>();
            userProfile.Add(Console.ReadLine());

            Console.WriteLine("Create your password\n");
            userProfile.Add(Console.ReadLine());
        
            Console.WriteLine("Enter your username\n");
            List<string> userProfile2 = new List<string>();
            userProfile2.Add(Console.ReadLine());

            Console.WriteLine("Enter your password\n");
            userProfile2.Add(Console.ReadLine());

            if (userProfile.SequenceEqual(userProfile2))
            {
                Console.WriteLine("\nIdentity confirmed\n");
            }

            else Console.WriteLine("\nIncorrect\n");

            }

        static void FizzBuzz()

        {
            for (int i = 1; i <= 100; i++)
            {
                bool Fizz = i % 3 == 0;
                bool Buzz = i % 5 == 0;

                if (Fizz && Buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }

               else if (Fizz)
                {
                    Console.WriteLine("Fizz");
                }

                else if (Buzz)
                {
                    Console.WriteLine("Buzz");
                }

                else Console.WriteLine(i);


            }


        }

        

        }


        

    }

