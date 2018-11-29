using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciples.LiskovSubstitution.Interface;

namespace SOLIDPrinciples.LiskovSubstitution.Implemantation
{
    public class EmployeeContract : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EmployeeContract(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public decimal GetMinimunSalary()
        {
            return 500;
        }
    }
}
