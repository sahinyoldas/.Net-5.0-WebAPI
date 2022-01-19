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
using Business.AutoFac.Aspects.Validation;
using Business.FluentValidation;

namespace Business.Concrete
{
    public class AlbumServiceManager : IAlbumService
    {
        private readonly IAlbumDal _albumDal;

        public AlbumServiceManager(IAlbumDal albumDal)
        {
            _albumDal = albumDal;
        }

        [ValidationAspect(typeof(AlbumValidator))]
        public async Task<IResult> Add(Album album)
        {
            var result = CheckIfAlbumExist(album);

            if (result.Result.Success)
            {
                return new ErrorResult(ConstantMessages.RecordAlreadyExist);
            }

            await _albumDal.Add(album);

            return new SuccessResult(ConstantMessages.AlbumAdded);
        }

        private async Task<Result> CheckIfAlbumExist(Album album)
        {
            return await _albumDal.CheckIfAlbumExist(album);
        }

        public async Task<IResult> Delete(Album album)
        {
            await _albumDal.Delete(album);
            return new SuccessResult(ConstantMessages.AlbumDeleted);
        }

        public async Task<IDataResult<IList<Album>>> GetAlbumListByTitleAndArtistName(string title, string artistName)
        {
            IList<Album> result = await _albumDal.GetAlbumListByTitleAndArtistName(title, artistName);
            return new SuccessDataResult<IList<Album>>(result, ConstantMessages.AlbumsListed);
        }

        public async Task<IDataResult<List<Album>>> GetAll()
        {
            return new SuccessDataResult<List<Album>>(await _albumDal.GetAll(), ConstantMessages.AlbumsListed);
        }

        public async Task<IDataResult<Album>> GetById(long albumId)
        {
            return new SuccessDataResult<Album>(await _albumDal.Get(d => d.Id == albumId));
        }

        public async Task<IResult> Update(Album album)
        {
            var result = CheckIfAlbumExist(album);

            if (result.Result.Success)
            {
                return new ErrorResult(ConstantMessages.RecordAlreadyExist);
            }

            await _albumDal.Update(album);

            return new SuccessResult(ConstantMessages.AlbumUpdated);
        }
    }
}
