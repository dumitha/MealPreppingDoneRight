using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MealPreppingDoneRight.Models
{
    public class YummyFood
    {
        public string YummyFoodName { get; set; }
        public string YummyFoodDescription { get; set; }
        public int YummyFoodNameID { get; set; }
        public enum YummyFoodCategory {
            Vegetables,
            Protein,
            PlantProtein,
            Dairy,
            Carbs,
            Fruits,
            Grains
        }

        
    }
}