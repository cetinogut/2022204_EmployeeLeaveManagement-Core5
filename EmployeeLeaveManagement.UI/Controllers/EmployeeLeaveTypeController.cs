using AutoMapper;
using EmployeeLeaveManagement.BusinessEngine.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2022204_EmployeeLeaveManagement_Core5.Controllers
{
    public class EmployeeLeaveTypeController : Controller
    {
        private readonly IEmployeeLeaveTypeBusinessEngine _employeeLeaveTypeBusinessEngine;
       

        public EmployeeLeaveTypeController(IEmployeeLeaveTypeBusinessEngine employeeLeaveTypeBusinessEngine)  // DI via constructor
        {
            _employeeLeaveTypeBusinessEngine = employeeLeaveTypeBusinessEngine;
            
        }
        public IActionResult Index()
        {
            var data = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveTypes();

            if (data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
                //return RedirectToAction("Creat"); // create sayfasına gönderir.
            }

            return View();
        }
    }
}
