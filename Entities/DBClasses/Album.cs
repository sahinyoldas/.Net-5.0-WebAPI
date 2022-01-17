using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DBClasses
{
    public class Album : IBaseEntity
    {
        public long Id { get; set; }

        [StringLength(250)]
        [Required]
        public string Title { get; set; }

        [StringLength(100)]
        [Required]
        public string ArtistName { get; set; }

        public int Year { get; set; }

    }
}
