using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Technight.Web.Models
{
    public class BaseModel
    {
        public bool success { get; set; }
        public bool error { get; set; }
        public string message { get; set; }
    }
}