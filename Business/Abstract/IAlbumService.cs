using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAlbumService
    {
        IDataResult<List<Album>> GetAll();
        IDataResult<List<Album>> GetAlbumListByTitleAndArtistName(string title, string artistName);
        IDataResult<Album> GetById(int albumId);
        IResult Delete(Album album);
        IResult Update(Album album);
        IResult Add(Album album);
    }
}
