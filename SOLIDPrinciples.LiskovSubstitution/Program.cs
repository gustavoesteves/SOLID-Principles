using System;
using System.Collections.Generic;
using SOLIDPrinciples.LiskovSubstitution.Abstract;
using SOLIDPrinciples.LiskovSubstitution.Implemantation;
using SOLIDPrinciples.LiskovSubstitution.Interface;

namespace SOLIDPrinciples.LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lEmp = new List<Employee>
            {
                new EmployeeType(1, "Zé", "Temporary"),
                new EmployeeType(2, "Tunico", "Effective")
            };
            // lEmp.Add(new EmployeeContract());
            foreach (var emp in lEmp)
            {
                Console.WriteLine("Employee: {0}, Bonus: {1} Minimum Salary: {2}",
                    emp.Name,
                    emp.CalculateBonus(800),
                    emp.GetMinimunSalary()
                    );
            }

            Console.WriteLine();

            List<IEmployee> iEmp = new List<IEmployee>
            {
                new EmployeeType(1, "Zé", "Temporary"),
                new EmployeeType(2, "Tunico", "Effective"),
                new EmployeeContract(3, "Carlao")
            };
            foreach (var emp in iEmp)
            {
                Console.WriteLine("Employee: {0}, Minimum Salary: {1}",
                    emp.Name,
                    emp.GetMinimunSalary()
                    );
            }
        }
    }
}
