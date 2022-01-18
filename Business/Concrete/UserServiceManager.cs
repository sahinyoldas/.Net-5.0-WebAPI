using Business.Abstract;
using DataAccess.Abstract;
using Entities.DBClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.Repositories;

namespace Business.Concrete
{
    public class UserServiceManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserServiceManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task<IResult> Add(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Delete(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<User>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<User>> GetById(long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
