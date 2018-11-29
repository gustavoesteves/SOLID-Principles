using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciples.LiskovSubstitution.Interface;

namespace SOLIDPrinciples.LiskovSubstitution.Abstract
{
    public abstract class Employee: IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee() { }

        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public abstract decimal GetMinimunSalary();
    }
}
