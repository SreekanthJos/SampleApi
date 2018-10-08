using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly IAutoMapper autoMapper;

        public PatientRepository(IAutoMapper autoMapper)
        {
            this.autoMapper = autoMapper;
        }

        public PatientEntity GetPatient()
        {
            Patient patient = new Patient() {PatientId = 1, PatientName ="xyz", MobileNo = "9999911111" };
            return this.autoMapper.Map<Patient, PatientEntity>(patient);
        }
    }
}

