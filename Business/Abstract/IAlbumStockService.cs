using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAlbumStockService
    {
        Task<IDataResult<List<AlbumStock>>> GetAll();
        Task<IDataResult<AlbumStock>> GetById(int albumStockId);
        Task<IResult> Delete(AlbumStock albumStock);
        Task<IResult> Update(AlbumStock albumStock);
        Task<IResult> Add(AlbumStock albumStock);
    }
}
