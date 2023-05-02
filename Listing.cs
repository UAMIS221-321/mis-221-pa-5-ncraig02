namespace mis_221_pa_5_ncraig02
{
    public class Listing
    {
        // instance variable
        private int listingID;
        private string trainerName;
        private int trainerID;
        private string focus; 
        private string sessionDate;
        private string sessionTime;
        private string sessionCost;
        private bool sessionOpen;
        private bool live;

        // 1 count variable for the entire class variable
        static private int count;


        // no arg constructor
        public Listing(){

        }


        //arg constructor
        public Listing( int listingID, string trainerName, int trainerID, string focus, string sessionDate, string sessionTime, string sessionCost, bool sessionOpen, bool live){
            this.listingID = listingID;
            listingID++;
            this.trainerName = trainerName;
            this.trainerID = trainerID;
            this.focus = focus;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
            this.sessionOpen = sessionOpen;
            this.live = live;
        }

        static public void SetCount(int count){
            Listing.count = count;
        }

        static public int GetCount(){
            return count;
        }

        static public void IncCount(){
            Listing.count++;
        }

        public void SetListingID(int listingID){
            this.listingID = listingID;
        }

        public int GetListingId(){
            return listingID;
        }

        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }

        public string GetTrainerName(){
            return trainerName;
        }

        public void SetTrainerID(int trainerID){
            this.trainerID = trainerID;
        }

        public int GetTrainerID(){
            return trainerID;
        }

        public void SetFocus(string focus){
            this.focus = focus;
        }

        public string GetFocus(){
            return focus;
        }

        public void SetSessionDate(string sessionDate){
            this.sessionDate = sessionDate;
        }

        public string GetSessionDate(){
            return sessionDate;
        }

        public void SetSessionTime(string sessionTime){
            this.sessionTime = sessionTime;
        }

        public string GetSessionTime(){
            return sessionTime;
        }

        public void SetSessionCost(string sessionCost){
            this.sessionCost = sessionCost;
        }

        public string GetSessionCost(){
            return sessionCost;
        }

        public void SessionOpen(bool sessionOpen){
            this.sessionOpen = true;
        }

        public bool GetSessionOpen(){
            return sessionOpen;
        }

        public void SessionNotOpen(bool SessionOpen){
            this.sessionOpen = false;
        }

        public void SetLive(bool live){
            this.live = true;
        }

        public void SetNotLive(bool live){
            this.live = false;
        }

        public bool GetLive(){
            return live;
        }

        public override string ToString()
        {
            return $"Listing ID: {listingID}\tTrainer name: {trainerName}\tTrainer ID: {trainerID}\tSpeciality {focus}\tDate: {sessionDate}\tTime: {sessionTime}\tCost: ${sessionCost}\tAvaliability: {sessionOpen}";
        }

        public string ToFile(){
            return $"{listingID}#{trainerName}#{trainerID}#{focus}#{sessionDate}#{sessionTime}#{sessionCost}#{sessionOpen}#{live}";
        }
    }
}