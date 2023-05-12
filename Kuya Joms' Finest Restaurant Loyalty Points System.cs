//BSCpE 1-1 Holgado, Jomari A.

using System;
    
//Kuya Joms' Finest Restaurant Loyalty Points System

class HelloWorld {
//Main Menu    
    static void Main () {
        int jompoints =  25;
        
        
        Console.WriteLine(" Welcome to Kuya Joms' Finest Restaurant Loyalty Points System");
        Console.WriteLine("_______________________________________________________________________________");
        Console.WriteLine("                     ");
        Console.WriteLine("Press 1 to View jompoints");
        Console.WriteLine("Press 2 to Know how to get more jompoints");
        Console.WriteLine("Press 3 to Exchange your jompoints in to Bigboy Rewards ");
        Console.WriteLine("Press 4 to Exchange your jompoints in to Advantage Card/Ticket ");
        Console.WriteLine("Press 5 to Exit");
        Console.WriteLine("_______________________________________________________________________________");
//Input Order
        Console.WriteLine(" Select what you want:");
        int selectedOption = Convert.ToInt32 (Console.ReadLine ());
        Console.WriteLine("Your choice is:" +  selectedOption);
        while (true) {
//Viewing Points (1)
        
        if (selectedOption == 1){
            Console.WriteLine("______________________________");
            Console.WriteLine(" ");
            Console.WriteLine("Your jompoints is:" + jompoints);
            break;
        }
//Getting More JomPoints (2)
        if (selectedOption == 2){
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine(" ");
            Console.WriteLine(" 1. 5 jompoints with minimum spend of P300.00");
            Console.WriteLine(" 2. 10 jompoints each customers you invited using your loyalty card");
            Console.WriteLine(" 3. 50 jompoints for booking special events ");
            break;
        }

//Exchange into Bigboy Rewards (3)
        if (selectedOption == 3){
            Console.WriteLine(" Select what you wish to exchange: ");
            Console.WriteLine("__________________________________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Press 6 for 16 oz of Milk Shake ");
            Console.WriteLine(" Press 7 for Plant-Based Burger Steak");
            Console.WriteLine(" Press 8 for Beef-Mushroom Pizza");
            Console.WriteLine("__________________________________");
            Console.WriteLine(" ");
            Console.WriteLine(" Select what you want to exchange: ");
            int exchangeRewards = Convert.ToInt32(Console.ReadLine());
//Milk Shake (3.1)
        if (exchangeRewards == 6){
                    int milkshake = 20;
                    if (jompoints >= milkshake) {
                        Console.WriteLine("_________________________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" You've successfully exchange your jompoints in Milk Shake");
                        jompoints = jompoints - milkshake;
                        Console.WriteLine(" Your new balance jompoints is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("_________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine("Not enough jompoints, earn more!");
                    }
                }
                
//Plant-Based Burger Steak (3.2)
        if (exchangeRewards == 7){
                    int burgersteak = 25;
                    if (jompoints >= burgersteak) {
                        Console.WriteLine("_________________________________________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" You've successfully exchange your jompoints in Plant-Based Burger Steak");
                        jompoints = jompoints - burgersteak;
                        Console.WriteLine(" Your new balance jompoints is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("_________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" Not enough jompoints, earn more!");
                    }
                }
                
//Beef Mushroom Pizza (3.3)
        if (exchangeRewards == 8){
                    int bmpizza = 30;
                    if (jompoints >= bmpizza) {
                        Console.WriteLine(" _________________________________________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" You've successfully exchange your jompoints in Beef-Mushroom Pizza");
                        jompoints = jompoints - bmpizza;
                        Console.WriteLine(" Your new balance is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Not enough jompoints, earn more!");
                    }
                }
                
                
        }

//Exchange into Advantage Cards/Ticket (4)
        if (selectedOption == 4){
            Console.WriteLine(" Select what you wish to exchange: ");
            Console.WriteLine("__________________________________");
            Console.WriteLine(" ");
            Console.WriteLine(" Press 9 for 300-Peso Gift Voucher in any shopping stores ");
            Console.WriteLine(" Press 10 for Buy 9 Get 1 Free Card ");
            Console.WriteLine(" Press 11 for 1 Million Mega Raffle Draw Ticket");
            Console.WriteLine("__________________________________");
            Console.WriteLine(" Select what you want to exchange: ");
            int exchangeRewards = Convert.ToInt32(Console.ReadLine());
            
//300-Peso Voucher (4.1)
            if (exchangeRewards == 9){
                int voucher = 30;
                if (jompoints >= voucher) {
                    Console.WriteLine("_______________________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Exchange Complete, please proceed to the cashier to claim. ");
                    jompoints = jompoints - voucher;
                    Console.WriteLine(" Your new balance is " + jompoints);
                    break;
                }
                else
                {
                    Console.WriteLine("_____________________________________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Exchange failed, not enough jompoints, please try again soon");
                }
                
            }
            
//Buy 9 Get 1 Ticket (4.2)
            if (exchangeRewards == 10){
                int ticket = 25;
                if (jompoints >= ticket) {
                    Console.WriteLine("_______________________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Exchange Complete, please proceed to the cashier to claim. ");
                    jompoints = jompoints - ticket;
                    Console.WriteLine(" Your new balance is " + jompoints);
                    break;
                }
                else
                {
                    Console.WriteLine("_____________________________________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Exchange failed, not enough jompoints, please try again soon");
                }
                
            }
            
//Raffle Ticket (4.3)
            if (exchangeRewards == 11){
                int ticket = 15;
                if (jompoints >= ticket) {
                    Console.WriteLine("_______________________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Exchange Complete, please proceed to the cashier to claim. ");
                    jompoints = jompoints - ticket;
                    Console.WriteLine(" Your new balance is " + jompoints);
                    break;
                }
                else
                {
                    Console.WriteLine("_____________________________________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Exchange failed, not enough jompoints, please try again soon");
                }
                
            }
         
        }
//Exiting the System (5)
        if (selectedOption == 5){
            Console.WriteLine("_____________________________________");
            Console.WriteLine(" ");
            Console.WriteLine(" Thanks for visiting us, stay loyal!!!");
            break;
        }
    }}  
}
