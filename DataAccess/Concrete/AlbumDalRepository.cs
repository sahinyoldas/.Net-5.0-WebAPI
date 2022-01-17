using DataAccess.Abstract;
using Entities.DBClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class AlbumDalRepository : BaseEntityRepository<Album, MusicalogContext>, IAlbumDal
    {
        public void GetAlbumListByTitleAndArtistName(string title, string artistName)
        {
            throw new NotImplementedException();
        }
    }
}
