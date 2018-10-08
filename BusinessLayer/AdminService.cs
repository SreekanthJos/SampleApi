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
    public class AdminService : IAdminService
    {

        private readonly IAutoMapper _autoMapper;
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAutoMapper autoMapper, IAdminRepository adminRepository)
        {
            this._autoMapper = autoMapper;
            this._adminRepository = adminRepository;
        }

        public async Task<AdminEntity> GetAdmin()
        {
            return await Task.FromResult<AdminEntity>(this._adminRepository.GetAdmin());
        }
    }
}
