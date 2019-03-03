using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain
{
    public class RecipeItem
    {
        private long Id { get; set; }
        private int Quantity { get; set; }
        private Incredient ingredient { get; set; }
        private Recipe Recipe { get; set; }
    }
}
