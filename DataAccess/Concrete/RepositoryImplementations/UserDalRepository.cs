using DataAccess.Abstract;
using Entities.DBClasses;
using DataAccess.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOClasses.ReturnResultsEntities;
using Microsoft.EntityFrameworkCore;
using Entities.DTOClasses;

namespace DataAccess.Concrete.RepositoryImplementations
{
    public class UserDalRepository : BaseEntityRepository<User, MusicalogContext>, IUserDal
    {
        public async Task<User> GetUserByEmailAndPassword(UserLoginDto userLoginDto)
        {
            using (MusicalogContext context = new MusicalogContext())
            {
                return await context.Users.
                    Include(a => a.UserRoles).ThenInclude(b => b.Role).Where(d => d.Email == userLoginDto.Email && d.Password == userLoginDto.Password).FirstOrDefaultAsync();
            }
        }
    }
}
