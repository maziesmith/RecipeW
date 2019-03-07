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
            Incredient inc=null;

            try
            {
                if ((name != "") & (name != null))
                {
                    inc = provider.GetByName(name);

                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
                       

            return inc;
        }

        public Incredient FetchByManufacture(String manufacture)
        {
            Incredient inc = null;

            try
            {
                if ((manufacture != "") & (manufacture != null))
                {
                    inc = provider.GetManufacture(manufacture);

                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }


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
