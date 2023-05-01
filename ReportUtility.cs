namespace mis_221_pa_5_ncraig02
{
    public class ReportUtility
    {
        static int SESSION_MAXCOUNT = 100;
        private Booking [] bookings = new Booking[SESSION_MAXCOUNT];

        private Listing [] listings = new Listing[SESSION_MAXCOUNT];

        private Trainer [] trainers = new Trainer[SESSION_MAXCOUNT];

        private Reports [] reports = new Reports[SESSION_MAXCOUNT];

        static public int count;

        public ReportUtility(Reports [] repoorts){
            this.reports = repoorts;
        }

        static public void SetCount (int count){
            ReportUtility.count = count;
        }

        static public int GetCount (){
            return count;
        }

        static public void IncCount(){
            ReportUtility.count ++;
        } 

        public int FindCustomer(string searchVal){
            for(int i = 0; i < BookingUtility.GetCount(); i++){
                if(bookings[i].GetCustomerEmail() == searchVal ){
                    return i;
                }
            }

            return -1;
        }

        public void IndividualCustomerReport(){
            System.Console.WriteLine("Enter the customer email below:");
            string searchVal = Console.ReadLine();
            int foundIndex = FindCustomer(searchVal);

            if(foundIndex != -1){
                for(int i = 0; i < BookingUtility.GetCount(); i++){
                if(bookings[i].GetSessionStatus() == "Completed" || bookings[i].GetSessionStatus()== "Canceled" && bookings[i].GetCustomerEmail() == searchVal){
                    System.Console.WriteLine(bookings[i].ToString());
                }
            }

            }

        }
    }
}