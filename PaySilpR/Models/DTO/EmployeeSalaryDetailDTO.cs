using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PaySilpR.Models.DTO
{
    public class EmployeeSalaryDetailModel
    {
        [Required(ErrorMessage ="FirstName is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "AnnualSalary is required")]
        public double AnnualSalary { get; set; }
        [Required(ErrorMessage = "SuperRate is required")]
        public double SuperRate { get; set; }
        [Required(ErrorMessage = "PaymentStartDate is required")]
        public string PaymentStartDate { get; set; }
    }
    public class EmployeeSalaryDetailDTO
    {
        public string Name { get; set; }
        public string PayPeriod { get; set; }
        public double GrossIncome { get; set; }
        public double IncomeTax { get; set; }
        public double NetIncome { get; set; }
        public double SuperAmount { get; set; }
    }

    public class TaxSlabTable
    {
        public double FromAmount { get; set; }
        public double ToAmount { get; set; }
        public double Percentage { get; set; }
        public double FixedTaxAmount { get; set; }
        public double RelaxAmount { get; set; }
    }
}