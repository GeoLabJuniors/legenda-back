using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace legenda.Models
{
    public class Image
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Path { get; set; }
    }
}