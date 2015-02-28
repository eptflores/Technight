using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technight.Server.DataObjects.Adapters;

namespace Technight.Server.DataObjects
{
    public class GetRecipeResponse:Response
    {
        public List<Recipe> RecipeItems { get; set; }
    }
}
