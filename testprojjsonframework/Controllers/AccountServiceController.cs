using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testprojjsonframework.Controllers
{
    public class RequestLoginModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class RequestRegisterModel
    {
        public string username { get; set; }
        public string emailaddress { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string referralcode { get; set; }
    }
    public class RequestActivateModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string uniquecode { get; set; }
    }

    public class AccountServiceController : ApiController
    {
        [Route("api/account/login")]
        public IHttpActionResult Login(RequestLoginModel request)
        {
            return Ok(request);
        }

        [Route("api/account/register")]
        public IHttpActionResult Register(RequestRegisterModel request)
        {
            return Ok(request);
        }

        [Route("api/account/activate")]
        public IHttpActionResult Activate(RequestActivateModel request)
        {
            return Ok(request);
        }
    }
}