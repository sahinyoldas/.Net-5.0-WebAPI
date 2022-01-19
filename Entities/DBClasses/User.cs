using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DBClasses
{
    public class User : IBaseEntity
    {
        public long Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(250)]
        [Required]
        public string Email { get; set; }

        [StringLength(100)]
        [Required]
        public string Password { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Catalog> Catalogs { get; set; }
    }
}
