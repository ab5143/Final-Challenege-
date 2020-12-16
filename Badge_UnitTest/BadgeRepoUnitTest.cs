using System;
using System.Collections.Generic;
using Badge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Badge_UnitTest
{
    [TestClass]
    public class BadgeRepoUnitTest
    {
        private BadgeRepository _badgeRepo;
        private Badge _badge;

        [TestInitialize]
        public void TestMetAddBadgesToTheList_Test()
        {
            BadgeRepository _badgeRepo = new BadgeRepository();
            Badge _badge = new Badge();

        }

        //Create/Read Method Testing 
        [TestMethod]
        public void AddBadgesToTheList_IsNotNullTest()
        {
            //Arrange
            Badge badgeOne = new Badge();
            badgeOne.Id = 2;
            BadgeRepository repository = new BadgeRepository();

            //Act
            repository.AddBadgesToTheList(badgeOne);

            //Assert 
            Assert.IsNotNull(repository.GetBadgeList().Count > 0);

        }

        //Helper Method Testing 
        [TestMethod]
        public void GetBadge_Helper_IsNotNull()
        {
            //Arrange
            Badge badgeOne = new Badge();
            badgeOne.Id = 2;
            BadgeRepository repository = new BadgeRepository();


            //Act
            repository.AddBadgesToTheList(badgeOne);
            
            KeyValuePair<int, List<string>> saveBadge = repository.GetBadge(2);


            //Assert 
            Assert.IsNotNull(saveBadge);

        }



        //Add Method Testing 
        [TestMethod]
        public void AddADoor_IsNotNullTest()
        {
            //Arrange
            Badge badgeOne = new Badge();
            //this is how you add a string to a list below line 69
            badgeOne.Id = 1;
            BadgeRepository repository = new BadgeRepository();
            repository.AddBadgesToTheList(badgeOne);

            //Act
            repository.AddADoor(1, "NewDoor");

            

            //Assert 
            Assert.IsNotNull(badgeOne.Doors);

        }




        //Delete Method Testing 
        [TestMethod]
        public void RemoveBadgeDoorFromList_IsNotNullTest()
        {
            //Arrange
            Badge badgeOne = new Badge();
            //this is how you add a string to a list below line 69
            badgeOne.Id = 1;
            BadgeRepository repository = new BadgeRepository();
            repository.AddBadgesToTheList(badgeOne);

            //Act
            repository.RemoveBadgeDoorFromList(1, "NewDoor");



            //Assert 
            Assert.IsNotNull(badgeOne.Doors);

        }




    }
}
