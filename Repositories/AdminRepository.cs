using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly IAutoMapper autoMapper;

        public AdminRepository(IAutoMapper autoMapper)
        {
            this.autoMapper = autoMapper;
        }
        public AdminEntity GetAdmin()
        {
            Admin admin = new Admin() { AdminId = 1, AdminName = "Sri" };
            return this.autoMapper.Map<Admin, AdminEntity>(admin);
        }
    }
}
