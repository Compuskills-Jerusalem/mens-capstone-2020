using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mens2020.Mvc.Controllers
{
    public class MailToApiController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "TEST STRING" };
        }
    }
}