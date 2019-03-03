using RecipeDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApplication.RecipeControl
{
    class IncredientControl
    {
        public Incredient Add(Incredient newInc)
        {
            Incredient inc = new Incredient();

            return inc;
        }

        public List<Incredient> getListOff()
        {
            List<Incredient> incs = new List<Incredient>();

            return incs;

        }
        public Incredient FetchByName(String name)
        {
            Incredient inc = new Incredient();

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
