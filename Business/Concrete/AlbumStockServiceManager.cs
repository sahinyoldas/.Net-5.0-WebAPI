using Business.Abstract;
using DataAccess.Abstract;
using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
using DataAccess.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AlbumStockServiceManager : IAlbumStockService
    {
        private readonly IAlbumStockDal _albumStockDal;

        public AlbumStockServiceManager(IAlbumStockDal albumStockDal)
        {
            _albumStockDal = albumStockDal;
        }

        public async Task<IResult> Add(AlbumStock albumStock)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Delete(AlbumStock albumStock)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<AlbumStock>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<AlbumStock>> GetById(int albumStockId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(AlbumStock albumStock)
        {
            throw new NotImplementedException();
        }
    }
}
