using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.DBClasses;
using Entities.DTOClasses.ReturnResultsEntities;
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
            var result = CheckIfAlbumExist(album);

            if (result.Result.Success)
            {
                return new ErrorResult("sahin Amca bu kayittan zaten  var");
            }

            await _albumDal.Add(album);

            return new SuccessResult("sahin album eklendi");
        }

        private async Task<Result> CheckIfAlbumExist(Album album)
        {
            return await _albumDal.CheckIfAlbumExist(album);
        }

        public async Task<IResult> Delete(Album album)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IList<Album>>> GetAlbumListByTitleAndArtistName(string title, string artistName)
        {
            IList<Album> result = await _albumDal.GetAlbumListByTitleAndArtistName(title, artistName);
            return new SuccessDataResult<IList<Album>>(result, "sahin albumler listelendi");
        }

        public async Task<IDataResult<List<Album>>> GetAll()
        {
            return new SuccessDataResult<List<Album>>(await _albumDal.GetAll(), ConstantMessages.AlbumListed);
        }

        public async Task<IDataResult<Album>> GetById(long albumId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(Album album)
        {
            var result = CheckIfAlbumExist(album);

            if (result.Result.Success)
            {
                return new ErrorResult("sahin guncelleme yapacaginiz kayittan zaten var");
            }

            await _albumDal.Update(album);

            return new SuccessResult("sahin album guncellendi");
        }
    }
}
