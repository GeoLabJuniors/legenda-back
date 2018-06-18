using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace legenda.Models
{
    public class SeasonsToImages
    {
        public int ID { get; set; }
        public int SeasonID { get; set; }
        public int ImageID { get; set; }

        public virtual Season Season { get; set; }
        public virtual Image Image { get; set; }
    }
}