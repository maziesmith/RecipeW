using System;
using Xunit;
using RecipeApplication.RecipeControl;
using RecipeDomain;

namespace RecipeTest
{
    public class RecipeIncredienTest : IRecipeIncredientTest
    {
        private IncredientControl control;
        public void AddIncredientTest()
        {
            Incredient actula = null;
            actula = control.Add()
        }
        [Theory]
        [InlineData("Maito")]
        [InlineData("Olut")]
        [InlineData("Pasta")]
        public void GetIncredientByNameTest()
        {

        }
        private Incredient createIncredient()
        {
            Incredient inc = new Incredient();
            inc.Manufacturer = "Valio";
            return inc;
        }
    }
}
