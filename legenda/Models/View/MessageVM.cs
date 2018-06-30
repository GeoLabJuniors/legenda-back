using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace legenda.Models.View
{
    public class MessageVM
    {
        public bool Success { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Errors { get; set; }
        public string RedirectUrl { get; set; }
    }
}