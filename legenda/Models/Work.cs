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
        public int InitialUserID { get; set; }
        public int SeasonID { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string Topic { get; set; }
        [Required]
        [StringLength(100)]
        public string Path { get; set; }

        public virtual InitialUser InitialUser { get; set; }
        public virtual Season Season { get; set; }

    }
}