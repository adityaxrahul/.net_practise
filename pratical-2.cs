using System;

namespace EmployeePayrollSystem
{
    interface IPayable
    {
        double CalculateSalary();
        void DisplayDetails();
    }

    class Employee
    {
        public int Id;
        public string Name;

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class FullTimeEmployee : Employee, IPayable
    {
        private double MonthlySalary;

        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name)
        {
            MonthlySalary = salary;
        }

        public double CalculateSalary()
        {
            return MonthlySalary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n----- Full Time Employee -----");
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Monthly Salary : ₹" + CalculateSalary());
        }
    }

    class PartTimeEmployee : Employee, IPayable
    {
        private double HoursWorked;
        private double HourlyRate;

        public PartTimeEmployee(int id, string name, double hours, double rate)
            : base(id, name)
        {
            HoursWorked = hours;
            HourlyRate = rate;
        }

        public double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n----- Part Time Employee -----");
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Hours Worked : " + HoursWorked);
            Console.WriteLine("Hourly Rate : ₹" + HourlyRate);
            Console.WriteLine("Salary : ₹" + CalculateSalary());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPayable emp1 = new FullTimeEmployee(101, "Aditya", 50000);
            IPayable emp2 = new PartTimeEmployee(102, "Rahul", 120, 250);

            emp1.DisplayDetails();
            emp2.DisplayDetails();

            Console.ReadLine();
        }
    }
}