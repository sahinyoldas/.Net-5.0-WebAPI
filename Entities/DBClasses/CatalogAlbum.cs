using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DBClasses
{
    public class CatalogAlbum : IBaseEntity
    {
        public long Id { get; set; }

        [ForeignKey("AlbumId")]
        public virtual Album Album { get; set; }

        public long AlbumId { get; set; }


        [ForeignKey("CatalogId")]
        public virtual Catalog Catalog { get; set; }

        public long CatalogId { get; set; }
    }
}
