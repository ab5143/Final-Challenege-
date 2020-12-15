using System;
using Cafe_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cafe_UnitTest
{
    [TestClass]
    public class CafeRepositoryTests
    {

        // Add Nethod 
        [TestMethod]

        //Test Helper Method

        public void GetMealByNumber_ShouldNotNull()
        {
            //Arrange --->  setting up the plain field 
            Meals menuOne = new Meals();
            menuOne.MealNumber = 1;
            MealsRepository repository = new MealsRepository();

            //Act ---> Get/RuntimeArgumentHandle the code we want to Test
            repository.AddMealsToList(menuOne);
            Meals menuFromList = repository.GetMealByNumber(1);

            //Assert---> Use the assert class to verify the expected outcome
            Assert.IsNotNull(menuFromList);

        }

        //Test Create and read  Method Together
        [TestMethod]
        public void AddMealsToList_ShouldNotNull()
        {
            Meals menuTwo = new Meals();
            menuTwo.MealName = "Taco";
            MealsRepository repository = new MealsRepository();

            //This is what we are testing below
            repository.AddMealsToList(menuTwo);

           // Assert.IsNotNull(repository.GetAllMeals());
            Assert.IsTrue(repository.GetAllMeals().Contains(menuTwo));

        }

        [TestMethod]
        public void RemoveMealsFromMenu()
        {

            Meals menuThree = new Meals();
            menuThree.MealNumber = 1;
            MealsRepository repository = new MealsRepository();

            repository.RemoveMealsFromMenu(menuThree.MealNumber);

            Assert.IsNotNull(repository);

            
        }




    }
}
