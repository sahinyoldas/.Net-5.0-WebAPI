using Entities.DBClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAlbumDal : IBaseEntityRespository<Album>
    {
        Task<List<Album>> GetAlbumListByTitleAndArtistName(string title, string artistName);
    }
}
