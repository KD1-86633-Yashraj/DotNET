using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create a basic four-function calculator. Take two numbers input from command line
//along with the operation to be performed. Use switch case.

namespace Assignment01_Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                int choice = 0;

                Console.WriteLine("0.EXIT\n1.ADD \n2.SUBSTRACT \n3.DIVIDE\n4.MULTIPLY");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Addition of " + num1 + " and " + num2 + " : " + (num1 + num2));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Subtraction of " + num1 + " and " + num2 + " : " + (num1 - num2));

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            double num2 = double.Parse(Console.ReadLine());

                            if (num2==0)
                            {
                                Console.WriteLine("Num2 cant be zero");
                            }
                            Console.WriteLine("Division of " + num1 + " and " + num2 + " : " + (num1 / num2));

                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Multiplication of " + num1 + " and " + num2 + " : " + (num1 * num2));

                            break;
                        }


                }

            }

        }
    }
}
