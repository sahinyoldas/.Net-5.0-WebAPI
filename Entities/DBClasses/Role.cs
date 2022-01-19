using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DBClasses
{
    public class Role:IBaseEntity
    {
        public long Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
