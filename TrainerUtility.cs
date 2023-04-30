namespace mis_221_pa_5_ncraig02
{
    public class TrainerUtility
    {
         static int MAX_TRAINER = 100;
        private Trainer[] trainers = new Trainer[MAX_TRAINER];

        // 1 count variable for class
        static public int count;

        public TrainerUtility(Trainer[] trainers){
            this.trainers = trainers;
        }

        static public void SetCount(int count){
            TrainerUtility.count = count;
        }

        static public int GetCount(){
            return count;
        }

        static public void IncCount(){
            TrainerUtility.count++;
        }

        // public void GetAllTrainers(){
        //     TrainerUtility.SetCount(0);
        //     System.Console.WriteLine("Please enter trainer ID or stop to stop");
        //     string userInput = Console.ReadLine();
        //     while(userInput.ToUpper() != "STOP"){
        //         trainers[TrainerUtility.GetCount()] = new Trainer();
        //         trainers[TrainerUtility.GetCount()].SetTrainerID(int.Parse(userInput));
        

        //         System.Console.WriteLine("Trainer, please enter your name");
        //         trainers[TrainerUtility.GetCount()].SetTrainerName(Console.ReadLine());


        //         System.Console.WriteLine("Enter your mailing address");
        //         trainers[TrainerUtility.GetCount()].SetMailingAddress(Console.ReadLine());


        //         System.Console.WriteLine("Enter your email address");
        //         trainers[TrainerUtility.GetCount()].SetTrainerEmail(Console.ReadLine());
        //         TrainerUtility.IncCount();

        //         System.Console.WriteLine("Enter your area of focus. (Ex: Muscle building, Weight loss, Yoga, ect)");
        //         trainers[TrainerUtility.GetCount()].SetFocus(Console.ReadLine());


        //         System.Console.WriteLine("Please enter trainer ID or stop to stop");
        //         userInput = Console.ReadLine();
        //     }
        // }

        public void GetAllTrainersFromFile(){
            //open file
            StreamReader inFile = new StreamReader("trainer.txt");
            //process file
            TrainerUtility.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string[] temp = line.Split('#');
                trainers[TrainerUtility.GetCount()] = new Trainer(temp[0],int.Parse(temp[1]),temp[2],temp[3],temp[4],bool.Parse(temp[5]));
                TrainerUtility.IncCount();
                line = inFile.ReadLine();
            }

            // close file 
            inFile.Close();
        }

        public void AddTrainer(){
            System.Console.WriteLine("Trainer, please enter your name:");
            Trainer myTrainer = new Trainer();
            myTrainer.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter trainer ID: ");
            myTrainer.SetTrainerID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Enter your mailing address:");
            myTrainer.SetMailingAddress(Console.ReadLine());
            System.Console.WriteLine("Enter your email address:");
            myTrainer.SetTrainerEmail(Console.ReadLine());
            System.Console.WriteLine("Enter your area of focus: (Ex: Muscle Building, Weight Loss, Yoga, ect)");
            myTrainer.SetFocus(Console.ReadLine());
            myTrainer.SetLive(true);
            myTrainer.GetTrainerID();

            trainers[TrainerUtility.GetCount()] = myTrainer;
            TrainerUtility.IncCount();
            
            SaveTrainer();
        }
        


        public void SaveTrainer(){
            // open file
            StreamWriter outFile = new StreamWriter("trainer.txt");
            // file process
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                outFile.WriteLine(trainers[i].ToFile());
            }

            // close file
            outFile.Close();

        }

        public int Find(string searchVal){
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                if(trainers[i].GetTrainerName().ToUpper() == searchVal.ToUpper()){
                    return i;
                }
            }
            return -1;
        }

        public void UpdateTrainer(){
            System.Console.WriteLine("\tWhat is the name of the trainer you'll like to update?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                System.Console.WriteLine("Please enter updated trainer name:");
                trainers[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Enter updated trainer ID:");
                trainers[foundIndex].SetTrainerID(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Enter updated trainer mailing address:");
                trainers[foundIndex].SetMailingAddress(Console.ReadLine());
                System.Console.WriteLine("Enter updated trainer email address:");
                trainers[foundIndex].SetTrainerEmail(Console.ReadLine());
                System.Console.WriteLine("Enter your updated area of focus: (Ex: Muscle Building, Weight Loss, Yoga, ect)");
                trainers[foundIndex].SetFocus(Console.ReadLine());

                SaveTrainer();
            }
            else{
                System.Console.WriteLine("\tTrainer not found!");
            }
        }

        public void DeleteTrainer(){
            System.Console.WriteLine("\tWhat is the name of the trainer you'd like to delete from system?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                trainers[foundIndex].SetNotLive(true);

            SaveTrainer();
            }
            else{
                System.Console.WriteLine("\tTrainer not found!");
            }
        }
    }
}