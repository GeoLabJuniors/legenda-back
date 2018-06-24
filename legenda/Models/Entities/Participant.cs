using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models.Entities
{
    public class Participant
    {
        public Participant()
        {
            Works = new HashSet<Work>();
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(9)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(100)]
        public string School { get; set; }

        [Required]
        [StringLength(100)]
        public string Faculty { get; set; }

        [Required]
        public int SchoolYear { get; set; }

        [Required]
        [StringLength(500)]
        public string HowFound { get; set; }

        [Required]
        [StringLength(500)]
        public string WhyParticipate { get; set; }

        public bool isFinalist { get; set; }
        
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Work> Works { get; set; }
    }
}