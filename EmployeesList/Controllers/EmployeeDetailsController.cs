using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesList.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        public List<EmployeeForm> Employees = new List<EmployeeForm>()
        {
            new EmployeeForm{EmployeeId=1,EmployeeName="Akhil",ReportsToId=6},
            new EmployeeForm{EmployeeId=2,EmployeeName="Priya",ReportsToId=6},
            new EmployeeForm{EmployeeId=3,EmployeeName="John",ReportsToId=6},
            new EmployeeForm{EmployeeId=4,EmployeeName="Nikhil",ReportsToId=6},
            new EmployeeForm{EmployeeId=5,EmployeeName="Mike",ReportsToId=0},
            new EmployeeForm{EmployeeId=6,EmployeeName="Ajay",ReportsToId=0},
            new EmployeeForm{EmployeeId=7,EmployeeName="Ram",ReportsToId=5},
            new EmployeeForm{EmployeeId=8,EmployeeName="Riya",ReportsToId=5},
            new EmployeeForm{EmployeeId=9,EmployeeName="Anil",ReportsToId=5},
            new EmployeeForm{EmployeeId=10,EmployeeName="Sam",ReportsToId=5}
        };

        public IActionResult Index()
        {
            //var Employee = new EmployeeForm()
            //{


            //};
            return View(Employees);
        }
        public IActionResult ChangeReports()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int Employeeid,int ReportTo)
        {


            return View();
        }


        //public IActionResult Index(EmployeeForm emp)
        //{

        //    return View("ChangeReports", emp);
        //}

    }
}