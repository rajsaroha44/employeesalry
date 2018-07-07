using System.Collections.Generic;
using PaySilpR.Models.DTO;

namespace PaySilpR.Utility.SingletonUtility
{
    public class SingletonUtility
    {
        private SingletonUtility()
        {

        }
        public static SingletonUtility objSingletonUtility;
        private static readonly object lockobj = new object();
        public static SingletonUtility GetInstance()
        {
            lock (lockobj)
            {
                if (objSingletonUtility == null)
                {
                    objSingletonUtility = new SingletonUtility();

                }
            }
            return objSingletonUtility;

        }


        public IList<TaxSlabTable> TaxSlabDataList()
        {
            IList<TaxSlabTable> taxSlabDataList = new List<TaxSlabTable>();
            taxSlabDataList.Add(new TaxSlabTable { FromAmount = 0, ToAmount = 18200, Percentage = 0, FixedTaxAmount = 0, RelaxAmount = 0 });
            taxSlabDataList.Add(new TaxSlabTable { FromAmount = 18201, ToAmount = 37000, Percentage = 19, FixedTaxAmount = 0, RelaxAmount = 18200 });
            taxSlabDataList.Add(new TaxSlabTable { FromAmount = 37001, ToAmount = 87000, Percentage = 32.5, FixedTaxAmount = 3572, RelaxAmount = 37000 });
            taxSlabDataList.Add(new TaxSlabTable { FromAmount = 87001, ToAmount = 180000, Percentage = 37, FixedTaxAmount = 19822, RelaxAmount = 87000 });
            taxSlabDataList.Add(new TaxSlabTable { FromAmount = 180001, ToAmount = 0, Percentage = 45, FixedTaxAmount = 54232, RelaxAmount = 180000 });
            return taxSlabDataList;
        }
    }
}