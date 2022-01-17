using DataAccess.Abstract;
using Entities.DBClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CatalogDalRepository : BaseEntityRepository<Catalog, MusicalogContext>, ICatalogDal
    {
    }
}
