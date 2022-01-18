using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<List<User>>> GetAll();
        Task<IDataResult<User>> GetById(long userId);
        Task<IResult> Delete(User user);
        Task<IResult> Update(User user);
        Task<IResult> Add(User user);
    }
}
