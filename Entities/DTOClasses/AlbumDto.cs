using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOClasses
{
    public class AlbumDto : IBaseDto
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public long Stock { get; set; }
        public AlbumType AlbumType { get; set; }
    }
}
