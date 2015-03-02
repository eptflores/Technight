using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technight.Server.DataObjects
{
    public class RecipeItem
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Origin { get; set; }
        public string Author { get; set; }
    }
}
