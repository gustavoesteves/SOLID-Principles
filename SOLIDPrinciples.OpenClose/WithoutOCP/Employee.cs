using System;

namespace SOLIDPrinciples.OpenClose
{
    /*
    Let's suppose that we need a new property called EmployeeType and
    that property it'll be used to calculate the bonus.
    Without Open Close Principles we just add the property bellow,
    change the Employee to add the property and finally add a if in 
    CalculateBonus function
    */
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // add new property
        public string EmployeeType { get; set; }
        public Employee() { }
        
        // add new property in parameters
        public Employee(int Id, string Name, string employeeType)
        {
            this.Id = Id;
            this.Name = Name;
            // add parameter value to class
            this.EmployeeType = employeeType;
        }
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
        public override string ToString()
        {
            return string.Format("Id: {0} Name: {1}", this.Id, this.Name);
        }
    }
}