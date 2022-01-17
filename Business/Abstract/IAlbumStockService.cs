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
        IDataResult<List<AlbumStock>> GetAll();
        IDataResult<AlbumStock> GetById(int albumStockId);
        IResult Delete(AlbumStock albumStock);
        IResult Update(AlbumStock albumStock);
        IResult Add(AlbumStock albumStock);
    }
}
