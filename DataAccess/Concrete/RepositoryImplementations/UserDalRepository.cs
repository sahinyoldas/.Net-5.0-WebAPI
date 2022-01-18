using DataAccess.Abstract;
using Entities.DBClasses;
using DataAccess.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.RepositoryImplementations
{
    public class UserDalRepository : BaseEntityRepository<User, MusicalogContext>, IUserDal
    {
    }
}
