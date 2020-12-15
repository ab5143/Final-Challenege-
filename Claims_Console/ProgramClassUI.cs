using Claims_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Console
{
    class ProgramClassUI
    {
        private readonly ClaimsRepository _ClaimsRepo = new ClaimsRepository();

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
                Console.WriteLine("Select the Claim Option:\n" +
                     "1. See All Claims\n" +
                     "2. Take Care of next claim\n" +
                     "3. Enter a new claim\n" +
                     "4. Exist");

                //Get the User's Input 
                string input = Console.ReadLine();

                //Evaluate the user Input and act accordingly
                switch (input)
                {
                    case "1":
                        // view All Claims
                        ViewAllClaims();
                        break;
                    case "2":
                        //Take Care of the Next Claim
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        //Add New Claims 
                        AddClaim();
                        break;
                    case "4":
                        //Exit
                        Console.WriteLine("Goodboye and have a Great Day");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Press any key to continue.....");
                        break;
                }

                Console.WriteLine("Please Press any KEY to continue....");
                Console.ReadKey();
                Console.Clear();


            }


        }

        // NeW CLAIM  Claims
        // /
        private void AddClaim()
        {
            Console.Clear();
            Claims newClaim = new Claims();

            // Claim ID 
            Console.WriteLine("What is the ClaimID");
            newClaim.ClaimID = int.Parse(Console.ReadLine());

            //Claim Type
            Console.WriteLine("Enter the Type of Claim:\n" +
                    "1. Car\n" +
                    "2. Home\n" +
                    "3. Theft\n");


            // allowing the user to input data about which type pf claim they want, stores it in a string called clainTypes
            string claimTypeX = Console.ReadLine();
            // Console.ReadLine() returns a string, but we need an int, so we are Parsing our string into an integer
            int claimAsInt = int.Parse(claimTypeX);
            // that integer is casted into selecting the index of our enum claintype
            newClaim.TypeOfClaim = (ClaimType)claimAsInt;


            //Claim Description
            Console.WriteLine("What is the Claim Description");
            newClaim.Description = Console.ReadLine();

            //ClaimAmount
            Console.WriteLine("List the ClaimAmount");
            newClaim.Amount = double.Parse(Console.ReadLine());

            //Date of Accident
            Console.WriteLine("Date of Accident (as mm/dd/yyyy): ");
            newClaim.DateOfAccident = DateTime.Parse(Console.ReadLine());

            //Date of Claim
            Console.WriteLine("Date of Claim (as mm/dd/yyyy): ");
            newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());

            //isvalid

            // due to negative number swtich the the subtraction below


            _ClaimsRepo.AddClaimsToList(newClaim);




        }

        //Take Care of Next Claim
        private void TakeCareOfNextClaim()
        {
            // Display Top Claim 
            Queue<Claims> claims = new Queue<Claims>();
            claims = _ClaimsRepo.GetAllClaims();
            Claims claim1 = claims.Peek();

            Console.WriteLine($"{claim1.ClaimID}\n" +
                $"{claim1.TypeOfClaim}\n" +
                $"{claim1.Description}\n" +
                $"{claim1.Amount}\n" +
                $"{claim1.DateOfAccident}\n" +
                $"{claim1.DateOfClaim}\n" +
                $"{claim1.Invalid}");

            Console.WriteLine("Do You want to take care of this claim");

            string input = Console.ReadLine();

            if (input == "y")
            {
                claims.Dequeue();
                if (claim1.Invalid)
                {
                    Console.WriteLine("This Claim has been taken cared of");
                }
                else
                {
                    Console.WriteLine("Th Claim has not been taken cared of");
                }
            }
                            
               
            
        }



        private void ViewAllClaims()
        {
            Console.Clear();
            Queue<Claims> allClaims = _ClaimsRepo.GetAllClaims();

            foreach (Claims claim in allClaims)
            {
                Console.WriteLine($"{claim.ClaimID}\n" +
                $"{claim.TypeOfClaim}\n" +
                $"{claim.Description}\n" +
                $"{claim.Amount}\n" +
                $"{claim.DateOfAccident}\n" +
                $"{claim.DateOfClaim}\n" +
                $"{claim.Invalid}");
            }


        }



        private void SeedMethod()
        {
            Claims ClaimOne = new Claims(1, "Car Accident On 465", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), ClaimType.Car);
            Claims ClaimTwo = new Claims(2, "House Fire in Kitchen", 4000.00, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12), ClaimType.Home);
            Claims ClaimThree = new Claims(3, "Car Accident On 465", 400.00, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01), ClaimType.Home);


            _ClaimsRepo.AddClaimsToList(ClaimOne);
            _ClaimsRepo.AddClaimsToList(ClaimTwo);
            _ClaimsRepo.AddClaimsToList(ClaimThree);

        }
         


    }



}

