using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Entities;
using ServiceLayer;

namespace WebApi.Controllers
{
    public class AdminController : ApiController
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            this._adminService = adminService;
        }

        public JsonResult<AdminEntity> Get()
        {
            var admin = this._adminService.GetAdmin();
            return Json<AdminEntity>(admin);
        }
    }
}
