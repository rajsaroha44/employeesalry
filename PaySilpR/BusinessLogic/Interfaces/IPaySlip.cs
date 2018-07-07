using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaySilpR.BusinessLogic.Interfaces
{
    public interface IPaySlip
    {
        double GrossInCome(double annualSalary);
        double TotalIncomeTax(double annualSalary);

    }
}