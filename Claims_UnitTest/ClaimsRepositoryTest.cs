using System;
using System.Collections.Generic;
using Claims_Repository;
using System.Security.Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Claims_UnitTest
{
    [TestClass]
    public class ClaimsRepositoryTest
    {
        private ClaimsRepository _repoOne = new ClaimsRepository();
        private Claims _claim = new Claims();
        
        
        [TestMethod]
        public void AddClaimsToList_ShouldNotReturnNull()
        {
            //Arrange
            Claims newClaim = new Claims();
            newClaim.ClaimID = 1;


            //Arrange
            _repoOne.AddClaimsToList(newClaim);













        }
    }
}
