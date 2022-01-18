using Entities.DBClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICatalogAlbumService
    {
        Task<IDataResult<List<CatalogAlbum>>> GetByCatalogId(long catalogId);
        Task<IResult> Delete(CatalogAlbum catalogAlbum);
        Task<IResult> Add(CatalogAlbum catalogAlbum);
    }
}
