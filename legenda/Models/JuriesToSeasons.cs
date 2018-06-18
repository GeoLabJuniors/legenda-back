using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace legenda.Models
{
    public class JuriesToSeasons
    {
        public int ID { get; set; }
        public int JuryID { get; set; }
        public int SeasonID { get; set; }

        public virtual Jury Jury { get; set; }
        public virtual Season Season { get; set; }
    }
}