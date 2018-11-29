using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.OpenClose.WithOCP
{
    public abstract class EmployeeOCP
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EmployeeOCP() { }

        public EmployeeOCP(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("Id: {0} Name: {1}", this.Id, this.Name);
        }
    }

    public class EmployeeOCPType : EmployeeOCP
    {
        public string EmployeeType { get; set; }

        public EmployeeOCPType(int Id, string Name, string EmployeeType) : base(Id, Name)
        {
            this.EmployeeType = EmployeeType;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Temporary")
                return salary * .05M;
            else
                return salary * .1M;
        }
    }
}
