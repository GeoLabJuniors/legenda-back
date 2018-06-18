using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace legenda.Models
{
    public class Competition
    {
        public int ID { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Rules { get; set; }
        [StringLength(50)]
        public string Topic { get; set; }
  
    }
}