using System;
using System.Collections.Generic;

using System.Security.Claims;
using Claims_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Claims_UnitTest
{
    [TestClass]
    public class ClaimsRepositoryTest
    {

        private Claims _claim = new Claims();
        private ClaimsRepository _repo = new ClaimsRepository();

        [TestMethod]
        public void AddClaimsToList_ShouldNotReturnNull()
        {
            //Arrange

            ClaimsRepository _repo = new ClaimsRepository();
            Claims newClaim = new Claims();
           


            //Act
            _repo.AddClaimsToList(newClaim);


            //Assert-----> 
            Assert.IsTrue(_repo.GetAllClaims().Count > 0);


        }



    }
}
