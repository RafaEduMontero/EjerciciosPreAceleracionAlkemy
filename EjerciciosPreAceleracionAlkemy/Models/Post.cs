using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosPreAceleracionAlkemy.Models
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
    }
}
