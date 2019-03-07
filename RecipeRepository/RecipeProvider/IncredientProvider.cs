using RecipeDomain;
using RecipeRepository.RecipeDAO;
using System;
using System.Collections.Generic;

namespace RecipeRepository.RecipeProvider
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
        public List<Incredient> GetListOf()
        {
            List<Incredient> Incredients = IncDAO.GetListOf();
            return Incredients;
        }

        public Incredient GetByName(String name)
        {
            Incredient fetchedInc;
            try
            {
                fetchedInc = IncDAO.getByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return fetchedInc; 

        }
    }
}
