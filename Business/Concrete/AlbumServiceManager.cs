using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    public class AlbumServiceManager : IAlbumService
    {
        private readonly IAlbumDal _albumDal;
        public AlbumServiceManager(IAlbumDal albumDal)
        {
            _albumDal = albumDal;
        }

        public async Task<IResult> Add(Album album)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Delete(Album album)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<Album>>> GetAlbumListByTitleAndArtistName(string title, string artistName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<Album>>> GetAll()
        {
            return new SuccessDataResult<List<Album>>(await _albumDal.GetAll(), ConstantMessages.AlbumListed);
        }

        public async Task<IDataResult<Album>> GetById(int albumId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
