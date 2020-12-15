using Cafe_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Console
{
    public class Cafe_UI
    {
        MealsRepository _meals = new MealsRepository();

        public void Run()
        {
            SeedMethod();
            Menu();
        }

        private void Menu()
        {

            bool keepRunning = true;
            while (keepRunning)
            {
                //Display the Options to the User 
                Console.WriteLine("Select the Meal Option:\n" +
                    "1. Create a New Meal\n" +
                    "2. View All Meals\n" +
                    "3. Delete Meals\n" +
                    "7. Exit");

                //get the user's Input
                string input = Console.ReadLine();

                //Evaluate the user Input and act accordingly 
                switch (input)
                {
                    case "1":
                        //create a new Meal  
                        CreateNewMeal();
                        break;
                    case "2":
                        // Display All Meals--View 
                        DisplayAllMeals();
                        break;
                    case "3":
                        //Delete Meals
                        DeleteMeals();
                        break;
                    case "4":
                        //Exit 
                        Console.WriteLine("Goodbye and Have a NiceDay");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Number. ");
                        break;
                }
                Console.WriteLine("Please Press any Key to Continue........");
                Console.ReadKey();
                Console.Clear();
                

            }
        }
        
        
        /// <summary>
        /// // 1. Create Meals 
        /// </summary>
        private void CreateNewMeal()
        {
            Console.Clear();
            Meals mealMenu = new Meals();

            //MealNumber 
            Console.WriteLine("What is the Meal Number");
            mealMenu.MealNumber = int.Parse(Console.ReadLine());


            //MealName 
            Console.WriteLine("What is the Name of the Meal");
            mealMenu.MealName = Console.ReadLine();


            //Meal Description
            Console.WriteLine("What is the Description of this Meal");
            mealMenu.Description = Console.ReadLine();

            //List of Ingrediants 
            Console.WriteLine("List of Ingredients");
            mealMenu.ListOfIngredients = Console.ReadLine();

            //Meal Price 
            Console.WriteLine("List the Price of the Meal");
            mealMenu.MealPrice = double.Parse(Console.ReadLine());

            _meals.AddMealsToList(mealMenu);
        }

        //2.    View All Meals
        private void DisplayAllMeals()
        {
            Console.Clear();
            List<Meals> allMeals = _meals.GetAllMeals();

            foreach (Meals meal in allMeals)
            {
                Console.WriteLine($"Meal Number: {meal.MealNumber}\n" +
                $"Meal Name: {meal.MealName}\n" + $"List of Ingredients: {meal.ListOfIngredients}\n" + $"Cost of the Meal is: ${meal.MealPrice}");


            }
        }
        //3.  Delete All Meals 

        private void DeleteMeals()
        {
            Console.WriteLine("Enter the Number of Meal to be deleted");
            string input = Console.ReadLine();
            int iNtgr = int.Parse(input);

            bool wasDeleted = _meals.RemoveMealsFromMenu(iNtgr);

            if (wasDeleted)
            {
                Console.WriteLine("The Meal was Successfully Deleted");
            }
            else
            {
                Console.WriteLine("The Meal could not be deleted");
            }
        }






        private void SeedMethod()
        {
            Meals Burger = new Meals(1, "CheeseBurger", "Juicy American Burger", "Onions, Tomato, cheese", 8.99);
            Meals ChikenTikka = new Meals(2, "Chricken Tikka Masala", " Yummy Indian Cuisine", "Chicken, spices, Naan", 12.99);
            Meals Shawarma = new Meals(3, "Shawarma", "Arabic Sandwich", "Minced Chicken, Beard, Ketcup", 6.99);

            _meals.AddMealsToList(Burger);
            _meals.AddMealsToList(ChikenTikka);
            _meals.AddMealsToList(Shawarma);
        }
    }
}
