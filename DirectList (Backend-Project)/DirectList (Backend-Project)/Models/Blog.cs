using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(150),Required]
        public string Title { get; set; }
        [MaxLength(2000),Required]
        public string About { get; set; }
        [Column(TypeName ="ntext"),Required]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<BlogComment> Comments { get; set; }
    }
}
