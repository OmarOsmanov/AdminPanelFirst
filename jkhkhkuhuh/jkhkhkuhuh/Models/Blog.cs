using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        public string Content { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }

        [ForeignKey("user")]
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatTime { get; set; }
        public int Weius { get; set; }
        public List<Blogimage> Blogimages { get; set; }
        public List<Comment> Comments { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
