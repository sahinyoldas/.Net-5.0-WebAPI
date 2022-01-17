using Business.Abstract;
using DataAccess.Abstract;
using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
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

        public IResult Add(Album album)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Album album)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Album>> GetAlbumListByTitleAndArtistName(string title, string artistName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Album>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Album> GetById(int albumId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
