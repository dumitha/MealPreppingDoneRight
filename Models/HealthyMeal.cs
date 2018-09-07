using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MealPreppingDoneRight.Models
{
    public class HealthyMeal
    {
        public int HealthyMealID { get; set; }
        public string HealthyMealName { get; set; }
        public string HealthyMealDescription { get; set; }
        public enum HealthyMealCategories
        {
            Vegetarian,
            Vegan,
            Pescetarian,
            Paleo,
            Keto,
            DiabeticDiet
        }
    }
}