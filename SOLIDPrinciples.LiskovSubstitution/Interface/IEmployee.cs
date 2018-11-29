using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.LiskovSubstitution.Interface
{
    interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal GetMinimunSalary();
    }
}
