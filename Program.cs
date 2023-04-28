using mis_221_pa_5_ncraig02;

//start main
Console.Clear();
DisplayMenu();
//end main


 static void DisplayMenu(){
    System.Console.WriteLine(@"
     ░█▀▀░▀█▀░█▀▀░█░█░▀█▀░▀█▀░█▀█░█▀▀░░░▀█▀░█▀▄░▀█▀░█▄█░░░█▀▀░▀█▀░▀█▀░█▀█░█▀▀░█▀▀░█▀▀ 
     ░█▀▀░░█░░█░█░█▀█░░█░░░█░░█░█░█░█░░░░█░░█▀▄░░█░░█░█░░░█▀▀░░█░░░█░░█░█░█▀▀░▀▀█░▀▀█
     ░▀░░░▀▀▀░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░▀▀▀░░░░▀░░▀░▀░▀▀▀░▀░▀░░░▀░░░▀▀▀░░▀░░▀░▀░▀▀▀░▀▀▀░▀▀▀    oooooooooo
                                                                                          I ^  ^ I
                                                                                         CI @  @ ID
                                                                                      __  I  .L  I  __        -Nicquavious-
                                                                                    _I  I \  ~~  / I  I_
                                                                                   I I  I  ______  I  I I
                                                                              []    I I__I          I__I I    []
                                                                             [ ]    I I  Io        oI  I I    [ ]
                                                                            [  ]======OOOO==========OOOO======[  ]
                                                                            [ ]    I___I__\      /__I___I    [ ]
                                                                             []    (______)      (_______)   []"   );

    System.Console.WriteLine("Hi! Welcome to Fighting Trim Fitness, where we specialize in body creations. Press any key to view our main menu");
    string menu = Console.ReadLine();

    if(menu !="5"){
            System.Console.WriteLine("1:   Manage trainer data");     
            System.Console.WriteLine("2:   Manage listing data");
            System.Console.WriteLine("3:   Manage customer booking data");
            System.Console.WriteLine("4:   Run reports");
            System.Console.WriteLine("5:   Exit Application");
            menu = Console.ReadLine();
    }

    if(menu == "1"){
        trainerData();
    }
    else if(menu == "2"){
        listingData();
    }
    else if(menu == "3"){
        bookingData();
    }
    else if(menu == "4"){
        runReport();
    }
    else if(menu == "5"){
        Exit();
    }
    else Error();
 }

//  method to exit application
static void Exit(){
    System.Console.WriteLine("Thank you for visiitng us. We hope to see you again!");
}


// method to give the user an error when an option outside of the menu range is selected
static void Error(){
    System.Console.WriteLine("Sorry, you did not make a valid selecction. Restart the program and start over");
}

//tells each menu option to read in data from other classes
static void trainerData(){
    Trainer[] trainers = new Trainer[100];
    TrainerUtility utility = new TrainerUtility(trainers);
    TrainerReport report = new TrainerReport(trainers);
    string trainerMenu = Console.ReadLine();


    if(trainerMenu != "3"){
        System.Console.WriteLine("1:   Add Trainer To File");     
        System.Console.WriteLine("2:   Update Trainer From File");
        System.Console.WriteLine("3:   Delete Trainer From File");
        trainerMenu = Console.ReadLine();
    }

    
    if(trainerMenu == "1"){
        System.Console.WriteLine("Let's add a trainer");
        utility.GetAllTrainersFromFile();
        report.PrintAllTrainers();
        utility.AddTrainer();
        report.PrintAllTrainers();
    }
    else if(trainerMenu == "2"){
        utility.GetAllTrainersFromFile();
        report.PrintAllTrainers();
        utility.UpdateTrainer();
        report.PrintAllTrainers();
    }
    else if(trainerMenu == "3"){
        utility.GetAllTrainersFromFile();
        report.PrintAllTrainers();
        utility.DeleteTrainer();
        report.PrintAllTrainers();
    }
    else Error();

}


static void listingData(){

}

static void bookingData(){

}

static void runReport(){

}