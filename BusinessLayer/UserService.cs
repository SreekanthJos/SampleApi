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
    public class UserService : IUserService
    {

        private readonly IAutoMapper _autoMapper;
        private readonly IUserRepository _userRepository;

        public UserService(IAutoMapper autoMapper, IUserRepository userRepository)
        {
            this._autoMapper = autoMapper;
            this._userRepository = userRepository;
        }

        public async Task<UserEntity> GetUser()
        {
            return await Task.FromResult<UserEntity>(this._userRepository.GetUser());
        }
    }
}
