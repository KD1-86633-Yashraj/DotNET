using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class WageEmp : Employee
    {
        private int hour;
        private int rate;
        public int Hour { get; set; }
        public int Rate { get; set; }

        public WageEmp(int hour, int rate)
        {
            Hour = hour;
            Rate = rate;

        }
        public WageEmp() { }

        public override void AcceptData()
        {
            base.AcceptData();
            base.Designation = "Wage";
            Console.WriteLine("Enter hours = ");
            Hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hourly rate = ");
            Rate = Convert.ToInt32(Console.ReadLine());
        }
        public override void Printdata()
        {
            base.Printdata();
            Console.WriteLine("Hours = " + Hour);
            Console.WriteLine("Rate = " + Rate);
        }
        public int CalculateWage()
        {
            return hour * rate;
        }
        public override string ToString()
        {
            return $"{{{nameof(Hour)}={Hour.ToString()}, {nameof(Rate)}={Rate.ToString()}, Total Wage: {CalculateWage()}, {nameof(Id)}={Id.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Department)}={Department}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(Birth)}={Birth}, {nameof(Address)}={Address}, {nameof(Age)}={Age.ToString()}}}";
        }
    }
}
