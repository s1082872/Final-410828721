﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_410828721.Controllers
{
    public class WeekController : Controller
    {
        // GET: Week
        public ActionResult Index(float? number)
        {
            var result = "";
            if (number.Value = 1)
            {
                result = 星期一;
            }

            ViewBag.Result = result;
            
            
            return View();
        }
    }
}