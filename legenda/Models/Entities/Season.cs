using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace legenda.Models.Entities
{
    public class Season
    {
        public Season()
        {
            ProjectImages = new HashSet<SeasonsToImages>();
            UsersToSeasons = new HashSet<ParticipantsToSeasons>();
            JuriesToSeasons = new HashSet<JuriesToSeasons>();
            Works = new HashSet<Work>();
        }
        public int ID { get; set; }
        public int Year { get; set; }
        public int MainImageID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Topic { get; set; }
        

        public virtual Image MainImage { get; set; }
        public virtual ICollection<SeasonsToImages> ProjectImages { get; set; }
        public virtual ICollection<ParticipantsToSeasons> UsersToSeasons { get; set; }
        public virtual ICollection<JuriesToSeasons> JuriesToSeasons { get; set; }
        public virtual ICollection<Work> Works { get; set; }


    }
}