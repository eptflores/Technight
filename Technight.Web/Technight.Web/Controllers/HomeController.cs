using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Technight.Server;
using Technight.Web.Models;


namespace Technight.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Welcome()
        {
            return PartialView();
        }

        public ActionResult RecipeList()
        {
            return PartialView();
        }

        public ActionResult AddRecipe()
        {
            return PartialView();
        }

        public ActionResult Signin()
        {
            return PartialView();
        }

        public ActionResult Register()
        {
            return PartialView();
        }


        [HttpGet]
        //[Authorize]
        public JsonResult Recipes()
        {

            var list = Session["recipelist"] as List<RecipeModel>;
            var result = new List<RecipeModel>();


            if (list == null)
            {
                var server = new Server.Services.CookBook();
                var response = server.ReadRecipes();

                if (response.Success)
                {
                    foreach (var recipe in response.RecipeItems)
                    {
                        result.Add(new RecipeModel()
                        {
                            RecipeId = recipe.RecipeId,
                            Name = recipe.Name,
                            Author = recipe.Author,
                            Origin = recipe.Origin,
                            Rating = recipe.Rating,
                            success=true

                        });

                    }

                    Session.Add("recipelist", result);

                }

            }
            else
                result = list;

        
            return Json(new
            {
                recipes = result,              
                success = true
            }, JsonRequestBehavior.AllowGet);
                    
        }

        [HttpGet]
        public JsonResult Recipe(int index)
        {
            var list = Session["recipelist"] as List<RecipeModel>;

            return Json(new
            {
                recipe = list[index],
                success = true

            }, JsonRequestBehavior.AllowGet);
        }



    }
}
