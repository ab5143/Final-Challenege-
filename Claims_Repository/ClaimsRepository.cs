using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Repository
{
    public class ClaimsRepository
    {
        private Queue<Claims> _listOfClaims = new Queue<Claims>();
      
        //CRUD

        //Create Claims

        public void AddClaimsToList(Claims claims)
        {
            _listOfClaims.Enqueue(claims);
        }


        //Read 


        public Queue<Claims> GetAllClaims()
        {
            return _listOfClaims;
        }


    }

}








