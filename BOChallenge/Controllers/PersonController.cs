using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOChallenge.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IHttpActionResult Get()
        {
            return Ok(new {FirstName = "Deniz", LastName = "Said", Email = "deniz@dsitmanagement.com", Github = "DenizSaid"});
        }

    }
}
