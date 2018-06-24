using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models.Entities
{
    public class JuriesToSeasons
    {
        public int ID { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public int SeasonID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Season Season { get; set; }
    }
}