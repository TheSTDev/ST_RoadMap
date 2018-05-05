﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Extensibility;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using STRoadMap.Models;

namespace STRoadMap.Controllers
{
    public class EmployeeController : Controller
    {        
        private readonly IEmployeeLogic employeeLogic;

        protected ApplicationDbContext ApplicationDbContext { get; set; }

        protected UserManager<ApplicationUser> UserManager { get; set; }

        public EmployeeController(IEmployeeLogic EmployeeLogic)
        {
            this.employeeLogic = EmployeeLogic;
        }
        // GET: Employee
        public string Index()
        {
            return "It works)";
        }

        [HttpGet]
        public ActionResult PerformanceReview()
        {            
            IEnumerable<Specialization> specs = employeeLogic.GetSpecializations();
            return View(specs);
        }

        [HttpPost]
        public ActionResult PerformanceReview(SkillMatrix position)
        {            
            if (position == null)
            {
                return HttpNotFound();
            }
            else
            {
                this.ApplicationDbContext = new ApplicationDbContext();
                this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.ApplicationDbContext));                
                if (employeeLogic.CreateSkillMatrix(position, UserManager.FindByName(HttpContext.User.Identity.Name).Id))
                {
                    return View("Employee", "Employee");                    
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }
    }
}