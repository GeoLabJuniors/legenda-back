using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace legenda.Models
{
    public class About
    {
        public int ID { get; set; }
        [StringLength(500)]
        public string Content { get; set; }
    }
}