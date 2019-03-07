using System;
using System.Collections.Generic;
using RecipeDomain;

namespace RecipeRepository.RecipeDAO

{
    public class RecipeDAO : IRecipeDOA<Recipe>
    {
        public RecipeDAO()
        {
        }

        public Recipe Add(Recipe obj)
        {
            throw new NotImplementedException();
        }

        public Recipe getById(double Id)
        {
            throw new NotImplementedException();
        }

        public Recipe getByName(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetListOf()
        {
            throw new NotImplementedException();
        }

        public int Remove(Recipe obj)
        {
            throw new NotImplementedException();
        }
    }
}
