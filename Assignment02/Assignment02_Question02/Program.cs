using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create a reference of Student’s array in Main. Write a function CreateArray() to
//allocate the array as per user’s requirement. Pass it to a function AcceptInfo() to
//accept student information. Print the array using PrintInfo() function.Also write a
//function ReverseArray() that reverse the array into a new array.Reprint the modified
//array in Main.
//Note: Do not return array from the function. All four functions mentioned above
//should be static functions in Main()’s class. 

namespace Assignment02_Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            Console.WriteLine("Enter size of array");
            Student[] studentsArray = CreateArray(int.Parse(Console.ReadLine()));

            PrintArray(studentsArray);

            Console.WriteLine("Reversed array");
            PrintArray(ReverseArray(studentsArray));





            
        }

        public static Student[] CreateArray(int count) { 

            Student[] array = new Student[count];

            for (int i = 0; i < count; i++) {

                array[i] = new Student();

                array[i].AcceptData();
            }

            return array;
        }

        public static void PrintArray(Student[] array) {
            foreach (Student i in array) {

                i.DisplayData();

            }
        }
        
        public static Student[] ReverseArray(Student[] arr)
        {

            Student[] reversedArray=new Student[arr.Length];

            for (int i = 0 ,j=arr.Length-1; i < reversedArray.Length && j>=0; i++, j--) {

                    reversedArray[i] = arr[j];
                
            }
            return reversedArray;

        }

    }
}
