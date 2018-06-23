using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models
{
    public partial class ApplicationUser
    {
        public ApplicationUser()
        {
            
            Posts = new HashSet<Post>();
        }

        [StringLength(100)]
        public string Firstname { get; set; }

        [StringLength(100)]
        public string Lastname { get; set; }

        [StringLength(500)]
        public string Biography { get; set; }

        [StringLength(100)]
        public string UserMail { get; set; }

        public int? ImageID { get; set; } 
        
        public virtual ICollection<Post> Posts { get; set; }
        public virtual Image Image { get; set; }

    }
}