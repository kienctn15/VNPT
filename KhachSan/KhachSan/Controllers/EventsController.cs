﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Hello(Models.EventsModel Idmodel)
        {
            var Mess = new Models.EventsModel();
       
            Mess.hello = "Hellooooooooooooooooooooo";
            return View(Mess);
        }
    }
}