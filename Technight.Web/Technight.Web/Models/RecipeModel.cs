using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Technight.Web.Models
{
    public class RecipeModel:BaseModel
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public string Origin { get; set; }
    }
}