using Entities.DBClasses;
using Entities.DTOClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using Entities.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<User>> Login(UserLoginDto userLoginDto);
        Task<AccessToken> CreateAccessToken(User user);
    }
}
