using AutoMapper;
using EmployeeLeaveManagement.BusinessEngine.Contracts;
using EmployeeLeaveManagement.Common.ViewModels;
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

        public IActionResult Create() //empty form
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeLeaveTypeVM model) 
        {
            if (ModelState.IsValid) {

                var data = _employeeLeaveTypeBusinessEngine.CreateEmployeeLeaveType(model);
                if (data.IsSuccess)
                {
                    //return View(model);
                    return RedirectToAction("Index");
                }
                return View(model);
                
            }
            else {
                return View(model);
            }
            
        }

        [HttpGet]
        public ActionResult Edit(int id) // Bring the edit form
        {
            if (id < 0)
            {
                return View();
            }

            var data = _employeeLeaveTypeBusinessEngine.GetEmployeeLeaveType(id);
            if (data.IsSuccess) 
                return View(data.Data);
            else
            { 
                return View(data); 
            }
        }

        [ValidateAntiForgeryToken] // you cannot do a post before doing the get
        [HttpPost]
        public ActionResult Edit(EmployeeLeaveTypeVM model)
        {
            if (ModelState.IsValid)
            {
                var data = _employeeLeaveTypeBusinessEngine.EditEmployeeLeaveType(model);
                if (data.IsSuccess)
                {
                    //return View(model);
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            else
            {
                return View(model);
            }

        }

        [HttpDelete]
        public ActionResult Delete(int id)
         {
            if (id <= 0)
                return Json(new { success = false, message = "No record to delete" });

            var data = _employeeLeaveTypeBusinessEngine.RemoveEmployeeLeaveType(id);
            if (data.IsSuccess)
                //return Json(new { success = data.IsSuccess, message = data.Message });
                return RedirectToAction("Index"); //?????
            else
                return Json(new { success = data.IsSuccess, message = data.Message });
        }
    }
}
