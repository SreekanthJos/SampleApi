using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Entities;
using ServiceLayer;
using WebApi.Filters;

namespace WebApi.Controllers
{
    //[CustomApiExceptionFilter]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;
        private readonly ILogger _log;
        public UserController(IUserService userService, ILogger log)
        {
            this._userService = userService;
            this._log = log;
        }

        public JsonResult<UserEntity> Get()
        {
            var user = this._userService.GetUser().Result;
            return Json<UserEntity>(user);
        }
    }
}
