using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {

        DateTime startDate = new DateTime(1990, 01, 12);
        DateTime endDate = new DateTime(2000, 12, 09);
        double thisSalary = 2000;
        public int GetEmployeeCount(DateTime startDate, DateTime endDate, double salary)
        {
            var employees = GetAll();
            int count = 0;  

            foreach (var item in employees)
            {
                if (item.Birthday > startDate && item.Birthday < endDate && item.Salary > thisSalary)
                {
                    count++;
                }
            }
            return count;
            

        }

        private Employee[] GetAll()
        {
            Employee emp1 = new Employee()
            {
                Name = "Konul",
                Surname = "Ibrahimova",
                Birthday = new DateTime(1996, 03, 08),
                Salary = 2100
            };

            Employee emp2 = new Employee()
            {
                Name = "Jale",
                Surname = "Isayeva",
                Birthday = new DateTime(1995, 09, 09),
                Salary = 1600
            };

            Employee emp3  = new Employee()
            {
                Name = "Shaiq",
                Surname = "Kazimov",
                Birthday = new DateTime(1993, 10, 12),
                Salary = 2500
            };

            Employee emp4  = new Employee()
            {
                Name = "Alekber",
                Surname = "Hesenov",
                Birthday = new DateTime(1998, 07, 20),
                Salary = 1800
            };

            Employee emp5  = new Employee()
            {
                Name = "Cavid",
                Surname = "Ismayilzade",
                Birthday = new DateTime(2002, 10, 02),
                Salary = 2000
            };

            Employee[] employees = { emp1, emp2, emp3, emp4, emp5 };
            return employees;   
        }
    }
}
