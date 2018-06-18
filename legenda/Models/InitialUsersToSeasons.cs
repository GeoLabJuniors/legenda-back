using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace legenda.Models
{
    public class InitialUsersToSeasons
    {
        public int ID { get; set; }
        public int InitialUserID { get; set; }
        public int SeasonID { get; set; }
        public int CompetitionPosition { get; set; }


        public virtual InitialUser User { get; set; }
        public virtual Season Season { get; set; }
    }
}