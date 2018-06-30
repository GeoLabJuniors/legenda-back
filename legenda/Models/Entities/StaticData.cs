using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace legenda.Models.Entities
{
    public class StaticData
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string KeyWord { get; set; }
        //[Required]
        [AllowHtml]
        public string Value { get; set; }
    }
}