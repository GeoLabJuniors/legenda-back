using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models
{
    public class Jury
    {
        public Jury()
        {
            JuriesToSeasons = new HashSet<JuriesToSeasons>();
        }
        
        public int ID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<JuriesToSeasons> JuriesToSeasons { get; set; }
    }
}