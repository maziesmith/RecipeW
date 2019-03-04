using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain
{
    public class Meal
    {
        
        private long Id { get; set; }
        private String Name { get; set; }
        private List<Recipe> Recipes { get; set; }
        private double Quantity { get; set; }
        private String QunatityUnit { get; set; }
        private DateTime TimeStamp { get; set; }

    }
}
