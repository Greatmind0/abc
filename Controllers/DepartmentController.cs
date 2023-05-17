using BAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiwithLayer.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IConfiguration _configuration;
        IDepartment _iDepartment;
        CompanyDbContext context = null;
        public DepartmentController(IConfiguration configuration, IDepartment iDepartment)
        {
            this._configuration = configuration;
            this._iDepartment = iDepartment;
            context = new CompanyDbContext();          
        }
        [HttpGet]       
        public IActionResult GetDepartmentList()
        {
            TableData tableData = new TableData();
            tableData.DepartmentListData = _iDepartment.DepartmentList();
            return Ok(tableData);
        }
    }
}
