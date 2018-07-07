using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaySilpR.Controllers;
using PaySilpR.BusinessLogic;
using PaySilpR.BusinessLogic.Classes;
using PaySilpR.Models.DTO;

namespace PaySlipTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        public void TaxSlab_18k_0()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Andrew";
            requestModel.LastName = "Smith";
            requestModel.AnnualSalary = 0;
            requestModel.SuperRate = 9;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(null, response);
        }

        [TestMethod]
        public void TaxSlab_18k_15k()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Andrew";
            requestModel.LastName = "Smith";
            requestModel.AnnualSalary = 15000;
            requestModel.SuperRate = 9;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(1250, response.GrossIncome);
            Assert.AreEqual(0, response.IncomeTax);
            Assert.AreEqual(1250, response.NetIncome);
            Assert.AreEqual(112, response.SuperAmount);
        }

        [TestMethod]
        public void TaxSlab_37k_25k()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Andrew";
            requestModel.LastName = "Smith";
            requestModel.AnnualSalary = 25000;
            requestModel.SuperRate = 9;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(2083, response.GrossIncome);
            Assert.AreEqual(108, response.IncomeTax);
            Assert.AreEqual(1975, response.NetIncome);
            Assert.AreEqual(187, response.SuperAmount);
        }

        [TestMethod]
        public void TaxSlab_87k_60k()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Andrew";
            requestModel.LastName = "Smith";
            requestModel.AnnualSalary = 60050;
            requestModel.SuperRate = 9;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(5004, response.GrossIncome);
            Assert.AreEqual(922, response.IncomeTax);
            Assert.AreEqual(4082, response.NetIncome);
            Assert.AreEqual(450, response.SuperAmount);
        }

        [TestMethod]
        public void TaxSlab_180k_120k()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Claire";
            requestModel.LastName = "Wong";
            requestModel.AnnualSalary = 120000;
            requestModel.SuperRate = 10;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(10000, response.GrossIncome);
            Assert.AreEqual(2669, response.IncomeTax);
            Assert.AreEqual(7331, response.NetIncome);
            Assert.AreEqual(1000, response.SuperAmount);
        }

        [TestMethod]
        public void TaxSlab_180k_Above()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Claire";
            requestModel.LastName = "Wong";
            requestModel.AnnualSalary = 200000;
            requestModel.SuperRate = 10;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(16667, response.GrossIncome);
            Assert.AreEqual(5269, response.IncomeTax);
            Assert.AreEqual(11398, response.NetIncome);
            Assert.AreEqual(1667, response.SuperAmount);
        }

        [TestMethod]
        public void TaxSlab_180k_Above_SR0()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Claire";
            requestModel.LastName = "Wong";
            requestModel.AnnualSalary = 200000;
            requestModel.SuperRate = 0;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(16667, response.GrossIncome);
            Assert.AreEqual(5269, response.IncomeTax);
            Assert.AreEqual(11398, response.NetIncome);
            Assert.AreEqual(0, response.SuperAmount);
        }

        [TestMethod]
        public void TaxSlab_180k_Above_SR100()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Claire";
            requestModel.LastName = "Wong";
            requestModel.AnnualSalary = 200000;
            requestModel.SuperRate = 100;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(16667, response.GrossIncome);
            Assert.AreEqual(5269, response.IncomeTax);
            Assert.AreEqual(11398, response.NetIncome);
            Assert.AreEqual(16667, response.SuperAmount);
        }

        [TestMethod]
        public void TaxSlab_180k_Above_SR101()
        {
            EmployeeSalaryDetail empTestCase = new EmployeeSalaryDetail(new PaySlip());
            EmployeeSalaryDetailModel requestModel = new EmployeeSalaryDetailModel();
            requestModel.FirstName = "Claire";
            requestModel.LastName = "Wong";
            requestModel.AnnualSalary = 200000;
            requestModel.SuperRate = 101;
            requestModel.PaymentStartDate = "01 March – 31 March";
            EmployeeSalaryDetailDTO response = empTestCase.GetEmployeeSalaryDetaill(requestModel);
            Assert.AreEqual(16667, response.GrossIncome);
            Assert.AreEqual(5269, response.IncomeTax);
            Assert.AreEqual(11398, response.NetIncome);
            Assert.AreEqual(16834, response.SuperAmount);
        }
    }
}
