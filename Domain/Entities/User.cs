using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Rol> Rols { get; set; } = new HashSet<Rol>();
        public ICollection<RefreshToKen> RefreshToKens { get; set; } = new HashSet<RefreshToKen>();
        public ICollection<UserRol> UserRols { get; set; }
    }
}