using System;

namespace Quiz_Q
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver d = new Driver();
            PartTimeEmployee p = new PartTimeEmployee(12,5);
            FullTimeEmployee f = new FullTimeEmployee(300);
            d.calculate(p);
            d.calculate(f);

        }
        class Employee
        {
            protected int salary;
            protected int hrs;
            public Employee(int s)
            {
                salary = s;
            }
            public Employee(int s, int h)
            {
                salary = s;
                hrs = h;
            }
            public virtual int CalculateSalary()
            { 
                return 0; 
            }
        }
        class PartTimeEmployee: Employee
        {
            public PartTimeEmployee(int salary, int hrs) : base(salary, hrs) { }
            public override int CalculateSalary()
            {
                Console.WriteLine("Salary of Part time Employee is: ");
                return salary * hrs;    
            }

        }
        class FullTimeEmployee : Employee
        {
            public FullTimeEmployee(int salary) : base(salary) { }

            public override int CalculateSalary()
            {
                Console.WriteLine("Salary of Full time Employee is: ");
                return salary;
            }
        }
        class Driver
        {
            public void calculate(Employee e)
            {
                int s;
                s = e.CalculateSalary();
                Console.WriteLine(s);
            }
        }
    }
}
