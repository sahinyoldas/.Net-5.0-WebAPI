using Business.Abstract;
using DataAccess.Abstract;
using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.Repositories;

namespace Business.Concrete
{
    public class CatalogServiceManager : ICatalogService
    {
        private readonly ICatalogDal _catalogDal;

        public CatalogServiceManager(ICatalogDal catalogDal)
        {
            _catalogDal = catalogDal;
        }

        public async Task<IResult> Add(Catalog catalog)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Delete(Catalog catalog)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<Catalog>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<Catalog>>> GetByUserId(long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(Catalog catalog)
        {
            throw new NotImplementedException();
        }
    }
}
