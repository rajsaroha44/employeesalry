using System.Collections.Generic;
using System.Linq;
using PaySilpR.BusinessLogic.Interfaces;
using PaySilpR.Models.DTO;
using PaySilpR.Utility.SingletonUtility;

namespace PaySilpR.BusinessLogic.Classes
{
    public class PaySlip : IPaySlip
    {

        public double GrossInCome(double annualSalary)
        {
            return annualSalary / 12;
        }

        public double TotalIncomeTax(double annualSalary)
        {
            SingletonUtility objSingletonUtility = SingletonUtility.GetInstance();
            IList<TaxSlabTable> taxSlabDataList = objSingletonUtility.TaxSlabDataList();
            TaxSlabTable taxSlabData = taxSlabDataList.Count() > 0 ?
                taxSlabDataList.FirstOrDefault(x => annualSalary >= x.FromAmount && (annualSalary <= x.ToAmount || x.ToAmount == 0) && x.FromAmount > 0 && annualSalary > 0) : null;
            return taxSlabData != null ? taxSlabData.Percentage > 0 ? (((annualSalary - taxSlabData.RelaxAmount) * taxSlabData.Percentage / 100) + taxSlabData.FixedTaxAmount) / 12 : 0 : 0;
        }
    }
}