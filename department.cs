using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkk2.homeworkk
{
    public class department
    {
        employee[] employees = new employee[0];
        employee employee;
        public int EmployeLimit;
        public int SalaryLimit;
        public department(int limit,int limit2)
        {
            EmployeLimit = limit;
            SalaryLimit = limit2;
        }

         public void AddEmploye()
        {
            Console.WriteLine("enter the name of employee");
            string namee=Console.ReadLine();
            for (int i = 0; i < namee.Length; i++)
            {
                if (char.IsDigit(namee[i]))
                {
                    Console.WriteLine("name of employee can't have any digit number");
                    Console.WriteLine("please try again");
                    namee = Console.ReadLine();
                }
            }
            if (!char.IsUpper(namee[0]))
            {
                Console.WriteLine("name of employee has to get started with upper letter");
                Console.WriteLine("please try again");
                namee = Console.ReadLine();
            }
            Console.WriteLine("enter the surname of employee");
            string surname=Console.ReadLine();
            for (int i = 0; i < surname.Length; i++)
            {
                if (char.IsDigit(surname[i]))
                {
                    Console.WriteLine("surname of employee can't have any digit number");
                    Console.WriteLine("please try again");
                    namee = Console.ReadLine();
                }
            }
            if (!char.IsUpper(surname[0]))
            {
                Console.WriteLine("first letter of surname of employee has to upper");

            }
            Console.WriteLine("enter the salary of employee");
            double salary1=Convert.ToDouble(Console.ReadLine());
            if (salary1 > SalaryLimit)
            {
                Console.WriteLine("an employee can't have this amount of salary");
            }
            employee=new employee(namee,surname,salary1);
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
            if (employees.Length > EmployeLimit)
            {
                Console.WriteLine("stop");
            }
        }

        public void ShowEmploye()
        {
            if (employees.Length == 0)
            {
                Console.WriteLine("an employee was not added yet");
            }
            else
            {
                foreach (var item in employees)
                {
                    Console.WriteLine($"name: {item.name}--- surname: {item.surname}--- salary: {item.salary}");
                }
            }
        }
    }
}
