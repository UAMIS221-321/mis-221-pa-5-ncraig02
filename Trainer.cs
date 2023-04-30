namespace mis_221_pa_5_ncraig02
{
    public class Trainer
    {
        // instance variable
        private int trainerID;
        private string trainerName;
        private string mailingAddress;
        private string trainerEmail; 
        private string focus;
        private bool live;
        static private int editTrainerID;

        // no arg constructor
        public Trainer() 
        {

        }

           // arg constructor 
        public Trainer(string trainerName, int trainerID, string mailingAddress, string trainerEmail, string focus, bool live){
            this.trainerID = trainerID;
            trainerID++;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmail = trainerEmail;
            this.focus = focus;  
            this.live = live;
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
        
        public void SetMailingAddress(string mailingAddress){
            this.mailingAddress = mailingAddress;
        }

        public string GetMailingAddress(){
            return mailingAddress;
        }
        
        public void SetTrainerEmail(string trainerEmail){
            this.trainerEmail = trainerEmail;
        }

        public string GetTrainerEmail(){
            return trainerEmail;
        }

        public void SetFocus(string focus){
            this.focus = focus;
        }

        public string GetFocus(){
            return focus;
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

        public override string ToString(){
            return $"Trainer name: {trainerName}\tTrainer ID: {trainerID}\tTrainer mailing address: {mailingAddress}\tTrainer email: {trainerEmail}\tSpeciality: {focus}";
        }
        
        public string ToFile(){
            return $"{trainerName}#{trainerID}#{mailingAddress}#{trainerEmail}#{focus}#{live}";
        }
    }  
}