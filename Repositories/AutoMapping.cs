using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace Repositories
{
    public class AutoMapping : IAutoMapper
    {

        private static IMapper _mapper;
        private static MapperConfiguration _config;

        public IMapper Mapper
        {
            get
            {
                if (_mapper == null)
                {
                    AutoMapperRegistration();
                }
                return _mapper;
            }
        }

        public AutoMapping() { AutoMapperRegistration(); }


        private void AutoMapperRegistration()
        {
            if (_config != null) return;

            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserEntity>();
                cfg.CreateMap<UserEntity, User>();
                cfg.CreateMap<Admin, AdminEntity>();
                cfg.CreateMap<AdminEntity, Admin>();
                cfg.CreateMap<Patient, PatientEntity>();
                cfg.CreateMap<PatientEntity, Patient>();

            });
            _mapper = _config.CreateMapper();
        }

        /// <summary>
        /// Auto Mapping Attributes
        /// </summary>
        /// <typeparam name="T1">From</typeparam>
        /// <typeparam name="T2">To</typeparam>
        /// <param name="input">Source</param>
        /// <returns>T2</returns>
        public T2 Map<T1, T2>(T1 input)
        {
            AutoMapperRegistration();
            return Mapper.Map<T1, T2>(input);
        }

        /// <summary>
        /// Auto Mapping Attributes
        /// </summary>
        /// <typeparam name="T1">From</typeparam>
        /// <typeparam name="T2">To</typeparam>
        /// <param name="input">Collection</param>
        /// <returns>IEnumerable<T2></returns>
        public IEnumerable<T2> Map<T1, T2>(IEnumerable<T1> input)
        {
            AutoMapperRegistration();
            return Mapper.Map<IEnumerable<T1>, IEnumerable<T2>>(input);
        }
    }
}
