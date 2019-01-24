﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string name, int numTimes = 5)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.numTimes = numTimes;
            return View();
        }
        /*public string Index()
        {
            return "This is my <b>default</b> action...";
        }*/

        // 
        // GET: /HelloWorld/Welcome/ 
        /*public string Welcome(string name, int numTimes = 1)
        {
            //return System.Web.HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
            return View(); 
        }*/
    }
}