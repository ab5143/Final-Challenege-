using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Repository
{
    public class MealsRepository
    {
        private readonly List<Meals> _meals = new List<Meals>();




        //CRUD

        //Create Meals 

        // Atif once all Challenges are done please rename "Content".  
        public void AddMealsToList(Meals content)
        {
            _meals.Add(content);


        }






        //Menu Read
        //List of meal objects 
        public List<Meals> GetAllMeals()
        {
            return _meals;
        }






        //Delete 
        public bool RemoveMealsFromMenu(int mealNumber)
        {
            Meals mealToDelete = GetMealByNumber(mealNumber);

            if (mealToDelete == null)
            {
                return false;
            }
            //menuC is a check to see if it deleted it and if the number is greater than the number deleted 
            //it will return true because that means that it has carried out the function (True)

            int menuC = _meals.Count;
            //.remove (???) ? has to have an object inside. 
            _meals.Remove(mealToDelete);

            if (menuC > _meals.Count)
            {
                return true;
            }
            else
            {
                return false;
            }









        }
        //Meal Helper Method

        public Meals GetMealByNumber(int mealNumber)
        {
            //Foreach loop has to run and find it it has that number one by one using int mealNum

            //Meals is a class (it is my POCO, Meals Object), _meals is a list, mealNum is just a name for Meals 
            foreach (Meals mealNum in _meals)
            {
                //.MealNumber is a property of mealNum .  It is a method.  It is basically trying to see if its there 
                if (mealNum.MealNumber == mealNumber)
                {
                    return mealNum;
                }

            }
            return null;





        }





    }
}
