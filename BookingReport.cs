namespace mis_221_pa_5_ncraig02
{
    public class BookingReport
    {
         private Listing [] listings;

        private Booking [] bookings;

        public BookingReport(Listing[] listings, Booking [] bookings){
            this.listings = listings;
            this.bookings = bookings;
        }

        public void PrintAllAvailableSessions(Listing [] listings){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetLive() == true && listings[i].GetSessionOpen() == false){
                    System.Console.WriteLine(listings[i].ToString());
                }

            }
        }

        public void PrintAllBookings(Booking [] bookings){
            for(int i = 0; i < Booking.GetCount(); i++){
              
                 System.Console.WriteLine(bookings[i].ToString());

            }
        }

        public static void PrintAllCustomerSessions(Booking[] bookings){
            for(int i = 0; i < BookingUtility.GetCount(); i++){
                if(bookings[i].GetSessionStatus() == "Completed"){
                    System.Console.WriteLine(bookings[i].ToString());
                }
            }
        }
    }
}