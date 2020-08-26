﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mens2020.Mvc.Controllers
{
    public class SignInRedirectController : Controller
    {
        // GET: SignInRedirect
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}