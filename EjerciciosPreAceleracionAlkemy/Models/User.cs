using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPreAceleracionAlkemy.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string  Email { get; set; }
        public ICollection<Post> Post { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
