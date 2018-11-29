using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciples.LiskovSubstitution.Abstract;

namespace SOLIDPrinciples.LiskovSubstitution.Implemantation
{
    public class EmployeeType : Employee
    {
        public string Type { get; set; }

        public EmployeeType(int Id, string Name, string Type) : base(Id, Name)
        {
            this.Type = Type;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            if (Type != "Temporary")
                return salary * .1M;
            else
                return salary * .05M; ;
        }

        public override decimal GetMinimunSalary()
        {
            if (Type != "Temporary")
                return 4000;
            else
                return 1000;
        }
    }
}
