using mis_221_pa_5_ncraig02;
Trainer[] trainers = new Trainer[100];
Listing[] listings = new Listing[100];
//start main
Console.Clear();
DisplayMenu(listings, trainers);
//end main

 static void DisplayMenu(Listing[] listings, Trainer[] trainers){
    System.Console.WriteLine(@"
     ░█▀▀░▀█▀░█▀▀░█░█░▀█▀░▀█▀░█▀█░█▀▀░░░▀█▀░█▀▄░▀█▀░█▄█░░░█▀▀░▀█▀░▀█▀░█▀█░█▀▀░█▀▀░█▀▀ 
     ░█▀▀░░█░░█░█░█▀█░░█░░░█░░█░█░█░█░░░░█░░█▀▄░░█░░█░█░░░█▀▀░░█░░░█░░█░█░█▀▀░▀▀█░▀▀█
     ░▀░░░▀▀▀░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░▀▀▀░░░░▀░░▀░▀░▀▀▀░▀░▀░░░▀░░░▀▀▀░░▀░░▀░▀░▀▀▀░▀▀▀░▀▀▀    @@@@@@@@@@
                                                                                          I ^  ^ I
                                                                                         CI @  @ ID
                                                                                      __  I  .L  I  __        One more rep!
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
        listingData(trainers, listings);
    }
    else if(menu == "3"){
        bookingData(listings, trainers);
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

// directs each trainer associated menu option where to pull data from
static void trainerData(){
    Trainer[] trainers = new Trainer[100];
    TrainerUtility utility = new TrainerUtility(trainers);
    TrainerReport report = new TrainerReport(trainers);
    string trainerMenu = Console.ReadLine();


    if(trainerMenu != "3"){
        System.Console.WriteLine("1:   Add Trainer To System");     
        System.Console.WriteLine("2:   Update Trainer From System");
        System.Console.WriteLine("3:   Delete Trainer From System");
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

// directs each listing associated menu option where to pull data from 
static void listingData(Trainer[] trainers, Listing[] listings){
    Listing[] listing = new Listing[100];
    // Trainer[] trainers1 = new Trainer[100];
    ListingUtility utility = new ListingUtility(listings);
    ListingReport report = new ListingReport(listings);
    string listingMenu = Console.ReadLine();

    if(listingMenu != "3"){
        System.Console.WriteLine("1:   Add Listing To System");     
        System.Console.WriteLine("2:   Update Listing From System");
        System.Console.WriteLine("3:   Delete Listing From System");
        listingMenu = Console.ReadLine();
    }


    if(listingMenu == "1"){
        utility.GetAllListingsFromFile();
        report.PrintAllListingsFromFile();
        utility.AddListing(trainers);
        report.PrintAllListingsFromFile();
    }
    else if(listingMenu == "2"){
        utility.GetAllListingsFromFile();
        report.PrintAllListingsFromFile();
        utility.UpdateListing(listings);
        report.PrintAllListingsFromFile();
    }
    else if(listingMenu == "3"){
        utility.GetAllListingsFromFile();
        report.PrintAllListingsFromFile();
        utility.DeleteLisitng();
        report.PrintAllListingsFromFile();
    }
    else Error();

}

static void bookingData(Listing[] listings, Trainer[] trainers){
    Booking[] bookings = new Booking[100];
    BookingUtility utility = new BookingUtility(bookings);
    BookingReport report = new BookingReport(listings, bookings);
    ListingUtility utility3 = new ListingUtility(listings);
    ListingReport report2 = new ListingReport(listings);
    string bookingMenu = Console.ReadLine();

    if(bookingMenu != "3"){
        System.Console.WriteLine("1:   View available training session");     
        System.Console.WriteLine("2:   Book a session");
        System.Console.WriteLine("3:   Update session");
        bookingMenu = Console.ReadLine();
    }


    if(bookingMenu == "1"){
        report.PrintAllAvailableSessions(listings);
    }
    else if(bookingMenu == "2"){
        report.PrintAllAvailableSessions(listings);
        utility.BookSession(listings, trainers);
        report2.PrintAllListingsFromFile();
        // utility.UpdateListing();
        
    }
    else if(bookingMenu == "3"){
        utility3.UpdateListing(listings);
        utility3.GetAllListingsFromFile();
        report2.PrintAllListingsFromFile();
        utility3.DeleteLisitng();
        report2.PrintAllListingsFromFile();
    }
    else Error();
    

}

static void runReport(){
    Reports[] reports = new Reports[100];
    ReportUtility utility = new ReportUtility(reports);
    string reportMenu = Console.ReadLine();

    if(reportMenu != "3"){
        System.Console.WriteLine("1:   Individual Customer Sessions");     
        System.Console.WriteLine("2:   Historical Customer Sessions");
        System.Console.WriteLine("3:   Historical Revenue Report");
        reportMenu = Console.ReadLine();
    }

    if(reportMenu == "1"){
        utility.IndividualCustomerReport();
    }
    else if(reportMenu == "2"){
        
        
    }
    
    else if(reportMenu == "3"){
    }
    else Error();



}