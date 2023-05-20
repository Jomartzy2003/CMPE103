using System;

//Kuya Joms' Finest Restaurant Loyalty Points System

class HelloWorld
{
    //Main Menu
    static void Main()
    {

        int jompoints = 25;

        Console.WriteLine("Welcome to Kuya Joms' Finest Restaurant Loyalty Points System");
        Console.WriteLine("Your balance Jom Points is:" + jompoints);
        Console.WriteLine("______________________________________________________________");
        Console.WriteLine(" ");
        Console.WriteLine("Press 1 to Exchange your Jom Points in to BigBoy Prizes");
        Console.WriteLine("Press 2 to exchange your Jom Points in to Advantage Card / Ticket");
        Console.WriteLine("Press 3 to Exit the System");
        Console.WriteLine("______________________________________________________________");
        //Input Order
        Console.WriteLine("Select what you want?");
        int selectedOption = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Your choice is " + selectedOption);
        while (true)
        {
            //Exchanging into BigBoy Rewards (1)
            if (selectedOption == 1)
            {
                Console.WriteLine(" Select what you wish to exchange?");
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine(" Press 4 for 16 oz of Milk Shake");
                Console.WriteLine(" Press 5 for Plant-Based Burger Steak");
                Console.WriteLine(" Press 6 for Beef-Mushroom Pizza");
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine(" ");
                Console.WriteLine(" Press :");
                int exchangeRewards = Convert.ToInt32(Console.ReadLine());
                //Milk Shake (1.1)
                if (exchangeRewards == 4)
                {
                    int milkshake = 20;
                    if (jompoints >= milkshake)
                    {
                        Console.WriteLine(" You've successfully exchange your Jom Points in Milk Shake");
                        jompoints = jompoints - milkshake;
                        Console.WriteLine(" Your new balance Jom Points is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Not enough Jom Points, earn more");
                    }
                }
                //Plant-Base Burger Steak (1.2)
                if (exchangeRewards == 5)
                {
                    int burgersteak = 25;
                    if (jompoints >= burgersteak)
                    {
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine(" You've successfully exchange your Jom Points in Plant-Based Burger Steak ");
                        jompoints = jompoints - burgersteak;
                        Console.WriteLine(" Your new balance Jom Points is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Not enough Jom Points, earn more");
                    }
                }
                //Beef Mushroom Pizza (1.3)
                if (exchangeRewards == 6)
                {
                    int bmpizza = 30;
                    if (jompoints >= bmpizza)
                    {
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine(" You've successfully exchange your Jom Points in Beef Mushroom Pizza ");
                        jompoints = jompoints - bmpizza;
                        Console.WriteLine(" Your new balance Jom Points is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Not enough Jom Points, earn more");
                    }
                }
            }
                //Exchanging Advantage Card / Ticket (2)
                if (selectedOption == 2)
            {
                Console.WriteLine(" Select what you wish to exchange");
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine(" ");
                Console.WriteLine(" Press 7 for 300-Peso Gift Voucher in any shopping stores");
                Console.WriteLine(" Press 8 for Buy 9 Get 1 Free Card");
                Console.WriteLine(" Press 9 for 1 Million Mega Raffle Draw Ticket");
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine(" ");
                Console.WriteLine("Press :");
                int exchangeRewards = Convert.ToInt32(Console.ReadLine());
                //300-Peso Gift Voucher (2.1)
                if (exchangeRewards == 7)
                {
                    int voucher = 30;
                    if (jompoints >= voucher)
                    {
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" Exchange complete, please proceed to the cashier");
                        jompoints = jompoints - voucher;
                        Console.WriteLine(" Your new balance Jom Points is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Exchange failed, not enough Jom Points");
                    }
                }
                //Buy 9 Get 1 Card (2.2)
                if (exchangeRewards == 8)
                {
                    int buygetcard = 30;
                    if (jompoints >= buygetcard)
                    {
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" Exchange complete, please proceed to the cashier");
                        jompoints = jompoints - buygetcard;
                        Console.WriteLine(" Your new balance Jom Points is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Exchange failed, not enough Jom Points");
                    }
                }
                //Raffle Ticket (2.3)
                if (exchangeRewards == 9)
                {
                    int raffleticket = 15;
                    if (jompoints >= raffleticket)
                    {
                        Console.WriteLine("_______________________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" Exchange complete, please proceed to the cashier");
                        jompoints = jompoints - raffleticket;
                        Console.WriteLine(" Your new balance Jom Points is " + jompoints);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Exchange failed, not enough Jom Points");
                    }
                }
            }
                //Exiting the System (3)
                if (selectedOption == 3)
                {
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine(" Thanks for visiting us, Stay Loyal!!!");
                break;
                }
        }
           
    }   }

            

    
    
