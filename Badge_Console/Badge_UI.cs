using Badge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Console
{
    class Badge_UI
    {
        private BadgeRepository _badgeList = new BadgeRepository();

        public void Run()
        {
            Seedlist();
            Menu();
        }

        private void Menu()
        {

            //??
            bool keepRunning = true;
            while (keepRunning)
            {

                // Display the options to the user 
                Console.WriteLine("Select a Claims Menu:\n" +

                    "1. Add A Badge\n" +
                    "2. Edit A Badge\n" +
                    "3. List All Badges\n" +
                    "4. Exit");


                //Get the User's Input
                string input = Console.ReadLine();

                //Evaluate User's Input and act accordingly
                switch (input)
                {
                    case "1":
                        //See All Claims
                        AddABadge();
                        break;
                    case "2":
                        // writeout to the console what you want user to do
                        //paraemeter please enter the badged
                        AddDoorToBadge();
                        break;
                    case "3":
                        // 
                        ListAllBadges();
                        break;
                    case "4":
                        //Exit 
                        Console.WriteLine("Goodbye!");
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
        // 1..........................................................Add Badge
        private void AddABadge()
        {
            Console.Clear();
            Badge badge = new Badge();

            Console.WriteLine("Please input a badge Id");
            int inputBadgeId = int.Parse(Console.ReadLine());
            badge.Id = inputBadgeId;

            //to handle the collection here is use a while loop
            //set up a bool value first
            bool hasFilledDoorAccess = false;
            while (hasFilledDoorAccess == false)
            {
                Console.WriteLine("Do you have door access y/n");
                string inputDoorAccess = Console.ReadLine();

                if (inputDoorAccess == "Y" || inputDoorAccess == "y")
                {
                    Console.WriteLine("Please input the door name");
                    string inputDoorName = Console.ReadLine();
                    badge.Doors.Add(inputDoorName);
                }
                if (inputDoorAccess == "N" || inputDoorAccess == "n")
                {
                    hasFilledDoorAccess = true;
                }

            }

            _badgeList.AddBadgesToTheList(badge);
        }



        //3.......................................List All Badges 
        private void ListAllBadges()
        {
            Console.Clear();
            Dictionary<int, List<string>> listofBadges = _badgeList.GetBadgeList();
            Console.WriteLine("Badge #     Doors ");
            foreach (KeyValuePair<int, List<string>> item in listofBadges)
            {
                Console.WriteLine($"  {item.Key}      ");
                foreach (string doorN in item.Value)
                {
                    Console.WriteLine(doorN + ", ");
                }
                Console.WriteLine("\n");

            }

        }

        //2...............................Edit a Badge
        public void AddDoorToBadge()
        {
            Console.WriteLine("What Badge would you like to add too");

            int bId = int.Parse(Console.ReadLine());

            Console.WriteLine("What Door you want to add");
            string changeDoor = Console.ReadLine();

            _badgeList.AddADoor(bId, changeDoor);

        }





        public void Seedlist()
        {
            Badge badgeOne = new Badge(1, new List<string>() { "A1", "A2", "A3" });
            Badge badgeTwo = new Badge(2, new List<string>() { "B1", "B2", "B3", "B4", "B5" });
            Badge badgeThree = new Badge(3, new List<string>() { "C1", "C2", "C3", "C4", "C5" });
            Badge badgeFour = new Badge(4, new List<string>() { "D1", "D2", "D3", "D4" });
            Badge badgeFive = new Badge(5, new List<string>() { "E1", "E2", "E3", "E4", "E5" });
            _badgeList.AddBadgesToTheList(badgeOne);
            _badgeList.AddBadgesToTheList(badgeTwo);
            _badgeList.AddBadgesToTheList(badgeThree);
            _badgeList.AddBadgesToTheList(badgeFour);
            _badgeList.AddBadgesToTheList(badgeFive);



        }








    }
}
