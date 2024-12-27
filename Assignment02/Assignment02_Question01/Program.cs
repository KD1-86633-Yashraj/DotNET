using System;

//Write a structure Student with following members:
// string name; bool gender; int age; ----------------------------------DONE
//int std; char div; double marks; -------------------------------------DONE
//Provide following functionality:
//Default constructor(?) -----------------------------------------------DONE
//Parameterized constructor --------------------------------------------DONE
//Get and Set methods --------------------------------------------------DONE
//AcceptDetails() method to accept data from console. ------------------DONE
//PrintDetails() method to print data to console. ----------------------DONE
//Check the default access specifier for members of structure. ---------DONE
//Keep all data members private and all member functions public -------DONE

namespace Assignment02_Question01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            student.acceptData();
            student.displayData();

        }
    }

        public struct Student
        {

        private string _Name;
        private bool _Gender;
        private int _Age;
        private int _Std;
        private char _Div;
        private double _Marks;



        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            _Name = name;
            _Gender = gender;
            _Age = age;
            _Std = std;
            _Div = div;
            _Marks = marks;
        }





        public void acceptData()
        {
            Console.WriteLine("Enter name");
            _Name = Console.ReadLine();

            bool flag = true;
            while (flag)
            {

            Console.WriteLine("Enter 1.MALE 2.FEMALE");
                switch (int.Parse(Console.ReadLine())) {
                    case 1:
                        {
                            _Gender = true;
                            flag = false;
                            break;
                        }

                    case 2: { 
                            _Gender= false;
                            flag = false;
                            break;
                        }
                    default: {
                            Console.WriteLine("Wrong choice");
                            break;
                        }
                }
            }


            Console.WriteLine("Engter Age");
            _Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter std");
            _Std=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter div");
            _Div = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark");
            _Marks=int.Parse(Console.ReadLine());

        }

        public void displayData()
        {
            Console.WriteLine("Name: "+_Name);

            if (_Gender == true)
            {
                Console.WriteLine("Gender: Male");
            }
            else
            {
                Console.WriteLine("Gender: Female");
            }

            Console.WriteLine("Age: "+_Age);
            Console.WriteLine("Std: "+_Std);
            Console.WriteLine("Div: "+_Div);
            Console.WriteLine("Marks: "+_Marks);
        }






        public double Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }


        public char Div
        {
            get { return _Div; }
            set { _Div = value; }
        }


        public int Std
        {
            get { return _Std; }
            set { _Std = value; }
        }


        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }


        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }








    }
}
