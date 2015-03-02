using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technight.Server.Interface;
using Technight.Server.DataObjects;

namespace Technight.Server.Services
{
    public class CookBook:Base,ICookBook
    {
        public ReadRecipeResponse ReadRecipe(Request request)
        {
            return (this as ICookBook).Read(request);
        }

        public GetRecipeResponse ReadRecipes()
        {
            return (this as ICookBook).ReadAll();
        
        }

        ReadRecipeResponse ICookBook.Read(Request request)
        {
            var response = new ReadRecipeResponse();

            if (request.RecipeId==0)
            {
                response.Success = false;
                response.Message = "RecipeId is Required.";
                return response;
            }

            try {

                using (var db = this.DBConnection)
                {
                    var qry = from recipe in db.Recipes
                              select new RecipeItem() { 
                               RecipeId = recipe.RecipeId,
                               Author= recipe.Author,
                               Rating = recipe.Rating.Value,
                               Origin= recipe.Origin
                              
                              };

                    qry = qry.Where(r => r.RecipeId == request.RecipeId);

                    response.RecipeItem = qry.FirstOrDefault();
                    response.Success = true;
                
                }
            
            }
            catch (Exception ex)
            {
                response.Error = true;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        GetRecipeResponse ICookBook.ReadAll()
        {
            var response = new GetRecipeResponse();

            try
            {

                using (var db = this.DBConnection)
                {
                    var qry = from recipe in db.Recipes
                              select new RecipeItem()
                              {
                                  RecipeId = recipe.RecipeId,
                                  Author = recipe.Author,
                                  Rating = recipe.Rating.Value,
                                  Origin = recipe.Origin

                              };


                    response.RecipeItems = qry.ToList();
                    response.Success = true;
                }

            }
            catch (Exception ex)
            {
                response.Error = true;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        AddResponse ICookBook.Add(AddRequest request)
        {
            var response = new AddResponse();

            return response;
        }
    }
}
