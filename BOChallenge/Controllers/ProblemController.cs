using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOChallenge.Controllers
{
    public class ProblemController : ApiController
    {
        private bool fib(int number) {
            var a = 0;
            var b = 1;
            while (true)
            {
                if (a == number)
                    return true;
                if (a > number)
                    return false;
                var t = a;
                a = b;
                b = t + b;
            }
        }


        // GET: api/Problem/?number=5
        public bool Get(int number)
        {
            return fib(number);
        }
    }
}
