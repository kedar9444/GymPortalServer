using GymPortal.Data;
using GymPortal.Data.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace GymPortal.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {

            _userService = userService;
        }

        public HttpResponseMessage GetUser()
        {
            var a = _userService.GetUsers();
            if (a == null)
            {
                //  return NotFound();
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, a);
        }

        public IHttpActionResult GetUser(int id)
        {
            User user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // POST: api/Users1
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            var userid = 0;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
               userid = _userService.Add(user);
            }
            catch
            {
                return BadRequest("Error While adding user.");
            }
            // userid `0` indicates duplicate user.
            if(userid == 0)
                return BadRequest("Duplicate user.");
            else
            return Ok(userid);
        }
    }
}

