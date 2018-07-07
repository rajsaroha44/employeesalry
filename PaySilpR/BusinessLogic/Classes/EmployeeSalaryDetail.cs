using System;
using PaySilpR.BusinessLogic.Interfaces;
using PaySilpR.Models.DTO;

namespace PaySilpR.BusinessLogic.Classes
{
    public class EmployeeSalaryDetail : IEmployeeSalaryDetail
    {
        IPaySlip _paySlip;
        public EmployeeSalaryDetail(IPaySlip paySlip)
        {
            _paySlip = paySlip;
        }
        public EmployeeSalaryDetailDTO GetEmployeeSalaryDetaill(EmployeeSalaryDetailModel Requestmodel)
        {
            EmployeeSalaryDetailDTO response = null;
            try
            {
                if (Requestmodel.AnnualSalary > 0)
                {
                    response = new EmployeeSalaryDetailDTO();
                    response.Name = string.Format("{0} {1}",  Requestmodel.FirstName, Requestmodel.LastName);
                    response.GrossIncome = Math.Round(_paySlip.GrossInCome(Requestmodel.AnnualSalary));
                    response.IncomeTax = Math.Round(_paySlip.TotalIncomeTax(Requestmodel.AnnualSalary));
                    response.PayPeriod = Requestmodel.PaymentStartDate;
                    response.NetIncome = Math.Round(response.GrossIncome - response.IncomeTax);
                    response.SuperAmount = Requestmodel.SuperRate > 0 ? Math.Round(response.GrossIncome * Requestmodel.SuperRate / 100) : 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
    }
}