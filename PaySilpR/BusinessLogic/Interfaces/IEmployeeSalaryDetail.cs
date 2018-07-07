using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaySilpR.Models.DTO;
namespace PaySilpR.BusinessLogic.Interfaces
{
    public interface IEmployeeSalaryDetail
    {
        EmployeeSalaryDetailDTO GetEmployeeSalaryDetaill(EmployeeSalaryDetailModel Requestmodel);
    }
}