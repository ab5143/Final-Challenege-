using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Repository
{
    public class BadgeRepository

    {
        private Dictionary<int, List<string>> _badgeList = new Dictionary<int, List<string>>();
        


        //CRUD
        //Create New Badge
        public void AddBadgesToTheList(Badge badge)
        {
            //count is the int part of it 
            
          _badgeList.Add(badge.Id, badge.Doors);
           
        }

        //Read 
        public Dictionary<int, List<string>> GetBadgeList()
        {
            return _badgeList;
        }

        //Add Method for door 
        public bool AddADoor(int Xid, string doorX)
        {
            foreach (KeyValuePair<int, List<string>> kvp in _badgeList)
            {
                if (kvp.Key == Xid)
                {
                    kvp.Value.Add(doorX);
                    return true;
                }

            }
            return false;


        }


        //Helper METHOD Get Badge By ID
        public KeyValuePair<int, List<string>> GetBadge(int numId)
        {
            KeyValuePair<int, List<string>> badgeNew = new KeyValuePair<int, List<string>>();
            foreach (KeyValuePair<int, List<string>> badge in _badgeList)
            {
                if (badge.Key == numId)
                {
                    return badge;
                }
            }
            return badgeNew;
        }

        //Delete Method

        public bool RemoveBadgeDoorFromList(int dictKey, string doorName)
        {
            foreach (KeyValuePair<int, List<string>> xObjectBadge in _badgeList)
            {
                if (xObjectBadge.Key == dictKey)
                {
                    foreach (string door in xObjectBadge.Value)
                    {
                        if (door == doorName)
                        {
                            xObjectBadge.Value.Remove(door);
                            return true;
                        }

                    }
                }
            }
            return false;



        }


    }
}

