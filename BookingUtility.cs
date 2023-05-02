namespace mis_221_pa_5_ncraig02
{
    public class BookingUtility
    {
        static int SESSION_MAXCOUNT = 100;
        private Booking [] bookings = new Booking[SESSION_MAXCOUNT];
        private Listing [] listings = new Listing[SESSION_MAXCOUNT];
        private Trainer [] trainers = new Trainer[SESSION_MAXCOUNT];
        static public int count;

        public BookingUtility(Booking [] bookings){
            this.bookings = bookings;
        }

        static public void SetCount (int count){
            BookingUtility.count = count;
        }

        static public int GetCount (){
            return count;
        }

        static public void IncCount(){
            BookingUtility.count ++;
        }

        public void GetAllBookingsFromFile(Booking [] bookings){
            StreamReader inFile = new StreamReader("transactions.txt");

            // BookingUtility.SetCount(0);
            Booking.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string [] temp = line.Split('#');
                bookings[BookingUtility.GetCount()] = new Booking(int.Parse(temp[0]),temp[1],temp[2],temp[3],int.Parse(temp[4]),temp[4],temp[5]);
                Booking.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();


        }

        private void SaveBooking(Booking [] bookings){
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for(int i = 0; i < Booking.GetCount(); i ++){
                outFile.WriteLine(bookings[i].ToFile());
            }
            
            outFile.Close();
        }

        public int Find(int searchVal,Listing [] listings){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetListingId() == searchVal){
                    return i;
                }
            }

            return -1;
        }

        public int FindBooking(string searchVal){
            for(int i = 0; i < BookingUtility.GetCount(); i++){
                if(bookings[i].GetSessionID() == int.Parse(searchVal)){
                    return i;
                }
            }
            return -1;
        }

        public void BookSession(Listing [] listings, Trainer [] trainers){
            
            System.Console.WriteLine("Please enter the Listing ID:");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal, listings);

            if(foundIndex != -1){
            Booking newSession = new Booking();
            newSession.SetSessionID(BookingUtility.GetCount());
            System.Console.WriteLine("Please enter the customer name:");
            newSession.SetCustomerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the customer email:");
            newSession.SetCustomerEmail(Console.ReadLine());
            newSession.SetTrainingDate(listings[foundIndex].GetSessionDate());
            newSession.SetTrainerID(listings[foundIndex].GetTrainerID());
            newSession.SetTrainerName(listings[foundIndex].GetTrainerName());
            System.Console.WriteLine("You are now booked for your session!");
            newSession.SetSessionStatus("Booked");
            

            bookings[Booking.GetCount()] = newSession;
            BookingUtility.IncCount();
            Booking.IncCount();

            SaveBooking(bookings);
            }
            else{
                System.Console.WriteLine("Session not found!");
            }
        }

        public void ChangeBooking(){
            System.Console.WriteLine("Enter the session ID that you would like to update:");
            string searchVal = Console.ReadLine();
            int foundIndex = FindBooking(searchVal);
            if(foundIndex != 1){
                System.Console.WriteLine("1:   Session was complete!");
                System.Console.WriteLine("2:   Session was canceled!");
                int userChoice = int.Parse(Console.ReadLine());
                if(userChoice == 1){
                    bookings[foundIndex].SetSessionStatus("Completed");
                }
                if(userChoice == 2){
                    bookings[foundIndex].SetSessionStatus("Canceled");
                }
                SaveBooking(bookings);
            }
            else{
                System.Console.WriteLine("Session was not found. Try again.");
            }
        }

    }
}