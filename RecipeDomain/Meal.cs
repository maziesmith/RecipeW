using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain
{
    public class Meal
    {
        
        private long Id { get; set; }
        private String Name { get; set; }
        private List<Recipe> recipes { get; set; }

        private double quantity { get; set; }
        private DateTime timeStamp { get; set; }

    }
}
