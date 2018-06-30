using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace legenda.Models.View
{
    public class AboutVM
    {
        public string Title { get; set; }
        [AllowHtml]
        public string Description { get; set; }
    }
}