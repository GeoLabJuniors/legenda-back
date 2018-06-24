using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models.Entities
{
    public class Post
    {
        public int ID { get; set; }
       
        [Required]
        [StringLength(300)]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }

        //public int? ImageID { get; set; }
        //public virtual Image Image { get; set; }
        [StringLength(100)]
        public string PostImageName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}