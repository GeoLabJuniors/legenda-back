using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace legenda.Models
{
    public class Contact
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Addresses { get; set; }
        [StringLength(200)]
        public string Mails { get; set; }
        [StringLength(200)]
        public string Mobiles { get; set; }
        [StringLength(200)]
        public string FBPage { get; set; }
    }
}