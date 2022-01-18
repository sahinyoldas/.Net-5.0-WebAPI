using DataAccess.Abstract;
using DataAccess.Abstract.Repositories;
using Entities.DBClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.RepositoryImplementations
{
    public class AlbumDalRepository : BaseEntityRepository<Album, MusicalogContext>, IAlbumDal
    {
        public async Task<Result> CheckIfAlbumExist(Album album)
        {
            using (MusicalogContext context = new MusicalogContext())
            {
                bool result = await context.Albums.Where(d => d.Id != album.Id && d.ArtistName == album.ArtistName
                                                 && d.Title == album.Title
                                                 && d.AlbumType == album.AlbumType).AnyAsync();

               return new Result(result);       
            }       
        }

        public async Task<IList<Album>> GetAlbumListByTitleAndArtistName(string title, string artistName)
        {
            using (MusicalogContext context = new MusicalogContext())
            {
                return await context.Albums.Where(d => d.ArtistName == artistName && d.Title == title).ToListAsync();
            }
        }
    }
}
