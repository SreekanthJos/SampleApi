using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IAutoMapper autoMapper;

        public UserRepository(IAutoMapper autoMapper)
        {
            this.autoMapper = autoMapper;
        }

        public UserEntity GetUser()
        {
            User user = new User() {UserId = 1, UserName ="Ani", EmailId = "ani@gmail.com", MobileNo = "9999911111" };
            return this.autoMapper.Map<User, UserEntity>(user);
        }
    }
}

