using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create a basic four-function calculator. Take two numbers input from console along
//with the operation to be performed. Make a menu driven program, which will
//continue to execute according to user choice. Use do-while loop.


namespace Assignment01_Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {

                char choice = '+';

                Console.WriteLine("Enter operation to be performed (eg- +, -, *, /), press e to EXIT");
                 choice= char.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 'e':
                        Environment.Exit(0);
                        break;

                    case '+':
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Sum of " + num1 + " and " + num2 + " : " + (num1 + num2));
                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Sum of " + num1 + " and " + num2 + " : " + (num1 - num2));

                            break;
                        }

                    case '/':
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Sum of " + num1 + " and " + num2 + " : " + (num1 / num2));

                            break;
                        }

                    case '*':
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Sum of " + num1 + " and " + num2 + " : " + (num1 * num2));

                            break;
                        }

                    

                }

            }



        }
    }
}
