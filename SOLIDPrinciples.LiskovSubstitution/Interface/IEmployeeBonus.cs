using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.LiskovSubstitution.Interface
{
    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
