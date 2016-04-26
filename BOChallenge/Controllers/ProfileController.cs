using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOChallenge.Controllers
{
    public class ProfileController : ApiController
    {
        // GET: api/Profile
        public IHttpActionResult Get()
        {
            return Ok(new { Interests = new string[] {"coding", "HBO", "Netflix", "YouTube" }});
        }
    }
}
