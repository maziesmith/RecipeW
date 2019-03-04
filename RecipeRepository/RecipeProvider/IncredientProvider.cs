using RecipeDomain;
using RecipeRepository.RecipeDAO;
using System;

namespace RecipeRepository
{
    public class IncredientProvider
    {
        private IRecipeDOA<Incredient> IncDAO = null;

        public IncredientProvider()
        {
            IncDAO = new IncredientDOA();
        }
        public Incredient SaveIngredient(Incredient inc)
        {
            Incredient NewInc = new Incredient();

            try
            {
                NewInc = IncDAO.Add(inc);
            }
            catch(Exception Ex)
            {
                throw (Ex);
            }

            return NewInc;
        }
    }
}
