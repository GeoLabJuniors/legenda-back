using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models
{
    public class ConfirmRole
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Key { get; set; }

        [Required]
        [ForeignKey("Role")]
        public string RoleID { get; set; }

        public virtual IdentityRole Role { get; set; }
    }
}