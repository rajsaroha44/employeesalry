using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PaySilpR.BusinessLogic.Interfaces;
using PaySilpR.Models.DTO;

namespace PaySilpR.Controllers
{
    public class EmployeeSalaryDetailController : ApiController
    {
        IEmployeeSalaryDetail _employeeSalaryDetail;
        public EmployeeSalaryDetailController(IEmployeeSalaryDetail employeeSalaryDetail)
        {
            _employeeSalaryDetail = employeeSalaryDetail;
        }

        // Post: api/EmployeeSalaryDetail
        [HttpPost]
        [Route("api/EmployeeSalaryDetail/GetEmployeeSalaryDetaill")]
        public IHttpActionResult GetEmployeeSalaryDetaill(EmployeeSalaryDetailModel Requestmodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(_employeeSalaryDetail.GetEmployeeSalaryDetaill(Requestmodel));
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return InternalServerError();
            }

        }
    }
}
