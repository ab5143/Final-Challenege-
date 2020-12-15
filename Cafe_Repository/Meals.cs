using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Repository
{
    //Meals is an object 
    public class Meals
    {
        public int MealNumber { get; set; }

        public string MealName { get; set; }

        public string Description { get; set; }

        public string ListOfIngredients { get; set; }
        public double MealPrice { get; set; }

        public Meals() { }
        public Meals(int mealnumber, string mealname, string desciption, string listofingredients, double price)
        {
            MealNumber = mealnumber;
            MealName = mealname;
            Description = desciption;
            ListOfIngredients = listofingredients;
            MealPrice = price;
        }














    }
}
