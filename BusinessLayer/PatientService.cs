using DAL;
using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class PatientService : IPatientService
    {

        private readonly IAutoMapper _autoMapper;
        private readonly IPatientRepository _patientRepository;

        public PatientService(IAutoMapper autoMapper, IPatientRepository patientRepository)
        {
            this._autoMapper = autoMapper;
            this._patientRepository = patientRepository;
        }

        public PatientEntity GetPatient()
        {
            return this._patientRepository.GetPatient();
        }
    }
}
