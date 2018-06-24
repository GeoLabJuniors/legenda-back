using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace legenda.Models.Entities
{
    public class ParticipantsToSeasons
    {
        public int ID { get; set; }
        public int ParticipantID { get; set; }
        public int SeasonID { get; set; }
        public int? CompetitionPosition { get; set; }
        public int? WorkID { get; set; }

        public virtual Participant Participant { get; set; }
        public virtual Season Season { get; set; }
        public virtual Work Work { get; set; }
    }
}