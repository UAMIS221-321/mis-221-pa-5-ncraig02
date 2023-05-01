namespace mis_221_pa_5_ncraig02
{
    public class Booking
    {
        private int sessionID;
        private string customerName;
        private string customerEmail;
        private string trainingDate;
        private int trainerID;
        static private int ID;
        private string trainerName;
        private string sessionStatus = "";
        static private int count;

        static public void SetCount(int count){
            Booking.count = count;
        }

        static public int GetCount(){
            return count;
        }

        static public void IncCount(){
            Booking.count ++;
        }


        public Booking(){

        }

        public Booking(int sessionID, string customerName, string customerEmail, string trainingDate,int trainerID, string trainerName, string sessionStatus){
            this.sessionID = sessionID;
            sessionID++;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.sessionStatus = sessionStatus;
        }

        public void SetSessionID(int sessionID){
            this.sessionID = sessionID;
        }

        public int GetSessionID(){
            return sessionID;
        }

        public void SetCustomerName(string customerName){
            this.customerName = customerName;
        }

        public string GetCustomerName(){
            return customerName;
        }

        public void SetCustomerEmail(string customerEmail){
            this.customerEmail = customerEmail;
        }

        public string GetCustomerEmail(){
            return customerEmail;
        }

        public void SetTrainingDate(string trainingDate){
            this.trainingDate = trainingDate;
        }

        public string GetTrainingDate(){
            return trainingDate;
        }

        public void SetTrainerID(int trainerID){
            this.trainerID = trainerID;
        }

        public int GetTrainerID(){
            return trainerID;
        }

        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }

        public string GetTrainerName(){
            return trainerName;
        }

        public void SetSessionStatus(string sessionStatus){
            this.sessionStatus = sessionStatus;
        }

        public string GetSessionStatus(){
            return sessionStatus;
        }

        public override string ToString()
        {
            return $"Session Id: {sessionID}\tCustomer Name: {customerName}\tCustomer Email: {customerEmail}\tTraining Date: {trainingDate}\tTrainer Id: {trainerID}\tTrainer Name: {trainerName}\tSession Status: {sessionStatus}";
        }

        public string ToFile(){
            return $"{sessionID}#{customerName}#{customerEmail}#{trainingDate}#{trainerID}#{trainerName}#{sessionStatus}";
        }

    }
}