using RecipeDomain;
using System;
using System.Collections.Generic;
using System.Text;
using RecipeRepository.RecipeProvider;

namespace RecipeApplication.RecipeControl
{
    class IncredientControl
    {
        private IncredientProvider provider;
        IncredientControl()
        {
            provider = new IncredientProvider();
        }
        public Incredient Add(Incredient newInc)
        {
            Incredient inc = null;
            if (newInc != null)
            {
                inc = provider.SaveIngredient(newInc);
            }
            return inc;
        }

        public List<Incredient> getListOff()
        {

            List<Incredient> incs = provider.GetListOf();

            return incs;

        }
        public Incredient FetchByName(String name)
        {
            Incredient inc; 
            if (name != "") & (name != null){
                inc = provider.
            }

            return inc;
        }

        public Incredient FetchByManufacture(String manufacture)
        {
            Incredient inc = new Incredient();

            return inc;
        }

        public IncredientMacros GetIncredientMacros(double index)
        {
            IncredientMacros incMacro = new IncredientMacros();

            return incMacro;
        }

        public int Remove(Incredient newInc)
        {
           
            return 1;
        }


    }
}
