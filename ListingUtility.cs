namespace mis_221_pa_5_ncraig02
{
    public class ListingUtility
    {
        static int MAX_TRAINER = 100;

        private Listing[] listings = new Listing[MAX_TRAINER];
        
        static public int count;

        public ListingUtility(Listing[] listings){
            this.listings = listings;
        }

        static public void SetCount(int count){
            ListingUtility.count = count;
        }

        static public int GetCount(){
            return count;
        }

        static public void IncCount(){
            ListingUtility.count++;
        }

        public void GetAllListingsFromFile(){
            // open file
            StreamReader inFile = new StreamReader("listing.txt");
            // process file
            ListingUtility.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string[] temp = line.Split('#');
                listings[ListingUtility.GetCount()] = new Listing(int.Parse(temp[0]),temp[1],int.Parse(temp[2]),temp[3],temp[4],temp[5],temp[6],bool.Parse(temp[7]),bool.Parse(temp[8]));
                ListingUtility.IncCount();
                line = inFile.ReadLine();
            }
            // close file
            inFile.Close();
        }

        public int FindTrainer(string searchVal,Trainer[] trainers){
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                if(trainers[i].GetTrainerName() == searchVal){
                    return i;
                }
            }
            return -1;
        }

        public void AddListing(Trainer[] trainers){
            System.Console.WriteLine("Enter Trainer ID:");
            string searchVal = Console.ReadLine();
            int foundIndex = FindTrainer(searchVal, trainers);
            if(foundIndex != -1){
                Listing newListing = new Listing();
                newListing.SetTrainerName(trainers[foundIndex].GetTrainerName());
                System.Console.WriteLine("Enter your area of focus: (Ex: Muscle Building, Weight Loss, Yoga, ect)");
                newListing.SetFocus(Console.ReadLine());
                System.Console.WriteLine("Enter date of session:");
                newListing.SetSessionDate(Console.ReadLine());
                System.Console.WriteLine("Enter time of session:");
                newListing.SetSessionTime(Console.ReadLine());
                System.Console.WriteLine("Enter cost of the session: $");
                newListing.SetSessionCost(Console.ReadLine());
                newListing.SetTrainerID(trainers[foundIndex].GetTrainerID());
                newListing.SessionOpen(true);
                newListing.SetLive(true);

                listings[ListingUtility.GetCount()] = newListing;
                ListingUtility.IncCount();
                Listing.IncCount();

                SaveListing();
            }
            else{
                System.Console.WriteLine("Trainer was not found");
            } 
        }

        public void SaveListing(){
            // open file
            StreamWriter outFile = new StreamWriter("test.txt");
        }

        public int Find(string searchVal){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetListingId() == int.Parse(searchVal)){
                    return i;
                }
            }
            return -1;
        }

        public void UpdateListing(){
            System.Console.WriteLine("\tEnter the listing ID you would like to update:");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);
            if(foundIndex != -1){
                System.Console.WriteLine("Enter updated trainer name:");
                listings[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Enter your updated area of focus: (Ex: Musscle Building, Weight Loss, Yoga, ect.)");
                listings[foundIndex].SetFocus(Console.ReadLine());
                System.Console.WriteLine("Enter updated session date:");
                listings[foundIndex].SetSessionDate(Console.ReadLine());
                System.Console.WriteLine("Enter updated session time:");
                listings[foundIndex].SetSessionTime(Console.ReadLine());
                System.Console.WriteLine("Enter updated session cost: $");
                listings[foundIndex].SetSessionCost(Console.ReadLine());
                System.Console.WriteLine("Enter 1 if session is open\nEnter 2 if session is closed");
                string userChoice = Console.ReadLine();
                if(userChoice == "1"){
                    listings[foundIndex].SessionOpen(true);
                }
                if(userChoice == "2"){
                    listings[foundIndex].SessionNotOpen(true);

                SaveListing();    
                }
                else{
                    System.Console.WriteLine("\tListing was not found!");
                }
            }
        }

        public void DeleteLisitng(){
            System.Console.WriteLine("\tEnter ID of session you want to delete from system:");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                listings[foundIndex].SetNotLive(true);
                SaveListing();
            }
            else{
                System.Console.WriteLine("\tListing was not found!");
            }
        }
    }
}