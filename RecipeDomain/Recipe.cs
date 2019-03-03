using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain
{
    public class Recipe
    {
    
        private long Id { get; set; }
        private String Name { get; set; }
        private List<RecipeItem> recipeItems { get; set; }
        private Meal Meal { get; set; }
    }
}
