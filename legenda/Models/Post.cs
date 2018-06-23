using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models
{
    public class Post
    {
        public int ID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public int? ImageID { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Text { get; set; }
        
        public virtual Image Image { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}