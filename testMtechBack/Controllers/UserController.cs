using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using testMtechBack.Models;
using testMtechBack.Data;

namespace testMtechBack.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        [HttpGet]
        [Route("api/users")]
        public List<UserResponse> GetUsers()
        {
            return UserData.retrieveUsers();
        }
    }
}
