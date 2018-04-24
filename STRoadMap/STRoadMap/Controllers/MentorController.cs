﻿using Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Service;

namespace STRoadMap.Controllers
{
    public class MentorController : Controller
    {
        private readonly IMentorLogic MentorLogic;

        public MentorController(IMentorLogic MentorLogic)
        {
            this.MentorLogic = MentorLogic;
        }
        // GET: Mentor
        public string Index()
        {
            return "It works)";
        }
        [HttpGet]
        public ActionResult EmployeeList()
        {
            IEnumerable<Employee> spec = MentorLogic.GetEmployeeList();
            if (spec == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(spec);
            }
        }
    }
}