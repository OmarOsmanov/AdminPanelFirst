using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}
