using Entities.DBClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Repositories
{
    public interface IAlbumDal : IBaseEntityRespository<Album>
    {
        Task<IList<Album>> GetAlbumListByTitleAndArtistName(string title, string artistName);
        Task<Result> CheckIfAlbumExist(Album album);
    }
}
