using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Repository
{

    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft
    }



    public class Claims
    {
        //Claim is an object 

        public int ClaimID { get; set; }


        public string Description { get; set; }

        public double Amount { get; set; }

        public DateTime DateOfAccident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public bool Invalid { get { return IsClaimValid(); } }

        public ClaimType TypeOfClaim { get; set; }



        public Claims() { }
        public Claims(int claimId,string desciption, double amount, DateTime dateOfAccident, DateTime dateOfclaim, ClaimType typeOfClaim)
        {
            ClaimID = claimId;
            Description = desciption;
            Amount = amount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfclaim;
            TypeOfClaim = typeOfClaim;

        }
        private bool IsClaimValid()
        {
            TimeSpan claimIsValid = DateOfClaim - DateOfAccident;

            if (claimIsValid.TotalDays <= 30)
            {

                return true;
            }
            else
            {
                return false;
            }


        }



    }
}



