using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Repository
{
    public class Badge
    {

        public int Id { get; set; }

        //Any time you have collections aka Lists, dictionaries etc you have to new it up in this page like below
        public List<string> Doors { get; set; } = new List<string>();


        public Badge() { }

        public Badge(int id, List<string> doors)
        {
            Id = id;
            Doors = doors;
                 
        }
    }
}








