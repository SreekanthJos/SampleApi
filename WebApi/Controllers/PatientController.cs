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
    public class PatientController : ApiController
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            this._patientService = patientService;
        }

        public JsonResult<PatientEntity> Get()
        {
            var patient = this._patientService.GetPatient();
            return Json<PatientEntity>(patient);
        }
    }
}
