using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models
{
    public class Work
    {
        public int ID { get; set; }
        public int ParticipantID { get; set; }
        public int SeasonID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Path { get; set; }

        public string Text { get; set; }

        public virtual Participant Participant { get; set; }
        public virtual Season Season { get; set; }

    }
}