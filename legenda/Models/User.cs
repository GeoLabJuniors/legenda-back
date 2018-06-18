using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace legenda.Models
{
    public class User
    {
        public User()
        {
            Works = new HashSet<Work>();
        }
        public int ID { get; set; }
        public int InitialUserID { get; set; }

        public virtual ICollection<Work> Works { get; set; }
        public virtual InitialUser InitialUser { get; set; }
    }
}