using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }
       
        [MaxLength(80), Required]
        public string Name { get; set; }
       

        [MaxLength(50),Required]
        public string Email { get; set; }

        [MaxLength(100), Required]

        public string Subject { get; set; }
        [MaxLength(2000), Required]

        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        [ForeignKey("ParentCommentId")]
        public int? ParentCommentId { get; set; }
        public BlogComment ParentComment { get; set; }

    }
}
