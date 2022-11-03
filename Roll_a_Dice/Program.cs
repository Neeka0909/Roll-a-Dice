using System;


public class gamePlayer
{
    public int id;
    public String name;
    public int score;
    
    public gamePlayer(int id, String name)
    {
        this.id = id;
        this.name = name;
    }


    public String getName()
    {
        return name;
    }


    public int getScore()
    {
        return score;
    }

    public void setId(int newId)
    {
        id = newId;
    }


    public void setScore(int newScore)
    {
        score = newScore;
    }

    public static void Main(String[] args)
    {
        void programStart()
        {
            String title = @"
                    .______        ______    __       __              ___          _______   __    ______  _______ 
                    |   _  \      /  __  \  |  |     |  |            /   \        |       \ |  |  /      ||   ____|
                    |  |_)  |    |  |  |  | |  |     |  |           /  ^  \       |  .--.  ||  | |  ,----'|  |__   
                    |      /     |  |  |  | |  |     |  |          /  /_\  \      |  |  |  ||  | |  |     |   __|  
                    |  |\  \----.|  `--'  | |  `----.|  `----.    /  _____  \     |  '--'  ||  | |  `----.|  |____ 
                    | _| `._____| \______/  |_______||_______|   /__/     \__\    |_______/ |__|  \______||_______|
                                                                                               
                     ";
            Console.WriteLine(title);
            Console.WriteLine("Welcome to Roll A Dice Game...");
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Start the Game.");
            Console.WriteLine("2. Show the Game Rules.");
            Console.WriteLine("3. Exit");
        }

        void showRules()
        {
            Console.WriteLine("\nGame Rules \n");
            Console.WriteLine("* Number of Players: 02  \n* Number of Players: 02 \n* Winning Score: 100 \n");
            Console.WriteLine("* Each player will get a chance to roll two dices at the same time. The process given below will \r\ncontinues until one player reaches the winning score. \n* If 02 dices give the same result (except the dice value 1), the same player will get another \r\nchance to roll the dice.\n* Else other player gets the chance to roll 02 dices.");
            Console.WriteLine("\n \nCalculation of score: \n* If both dices give the value 1, the individual marks of the respective player will be \r\nreduced to 0.\r\n* Else sum of the two dice values will be added to individual scores of the respective \r\nplayer.\r\n");
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Start The Game");
            Console.WriteLine("2. Exit to main menu.");

            int optionRules = 0;

            do
            {
                try
                {
                    optionRules = int.Parse(Console.ReadLine());
                }
                catch 
                { 
                    Console.WriteLine("Please Enter the correct value.");
                    
                }
                if (optionRules == 1) { gamePlay();}
                else if (optionRules == 2) { break;}
            }while(optionRules != 2);
            {

            }

        }

        List<gamePlayer> player = new List<gamePlayer>();

        //Player Details saved
        void playerAdd()

        {
            String playerName = "";
            bool count = true;
            int i = 1;
            Console.WriteLine("\n");
            while (count == true)
            {
                Console.WriteLine("Please enter Player " + i + " Name :");
                playerName = Console.ReadLine();
                player.Add(new gamePlayer(i, playerName));
                i++;   
                if (i == 3)
                {
                    count=false;
                }
            }
            Console.WriteLine("Press any key to Continue and Play...");
            Console.ReadKey();
        }

        //Player score count function
        gamePlayer currentPlayer;

        void scoreCount(int j)
        {
            int x = 0;
            int y = 0;
            int playerScore = 0;

            currentPlayer = player[j];
            Console.WriteLine(currentPlayer.getName() + " Press Any key to Roll a dice.");
            Console.ReadKey();

            x = rollADice().Item1;
            y = rollADice().Item2;

            Console.WriteLine("\nDice 1 value : " + x);
            Console.WriteLine("Dice 2 value : " + y);

            if (x == 1 && y == 1)
            {
                currentPlayer.setScore(0);
                Console.WriteLine("\n" + currentPlayer.getName() + " Occures tie Event. Both Dices give same value. \r\nThen Set " + currentPlayer.getName() + " Score to 0.\n");
            }
            else if (x == y)
            {
                Console.WriteLine("\nBoth Dices gives the Same Value.");
                scoreCount(j);
            }
            else
            {
                playerScore = x + y;
                currentPlayer.setScore(playerScore + currentPlayer.getScore());
                Console.WriteLine("\nTotal Score of " + currentPlayer.getName() + " = " + currentPlayer.getScore());
            }

        }


        //Dice Role local function
        Tuple<int, int> rollADice()
        {
            Random rand = new Random();
            var x = rand.Next(1, 7);
            var y = rand.Next(1, 7);

            return Tuple.Create(x, y);
        }



        void gamePlay(){

            playerAdd();
            gamePlayer Player1 = player[0];
            gamePlayer Player2 = player[1];
            int i = 0;

            while (true)
            {

                if (Player1.getScore() > 100 || Player2.getScore() > 100)
                {
                   
                    if (Player1.getScore() > 100)
                    {
                        Console.WriteLine("The Winner is : " + Player1.getName());
                    }
                    else if (Player2.getScore() > 100)
                    {
                        Console.WriteLine("The Winner is : " + Player2.getName());
                    }
                    exit();
                    Player1.setScore(0);
                    Player2.setScore(0);
                    String gameOver = @"
                       _____                                 ____                        
                      / ____|                               / __ \                       
                     | |  __    __ _   _ __ ___     ___    | |  | | __   __   ___   _ __ 
                     | | |_ |  / _` | | '_ ` _ \   / _ \   | |  | | \ \ / /  / _ \ | '__|
                     | |__| | | (_| | | | | | | | |  __/   | |__| |  \ V /  |  __/ | |   
                      \_____|  \__,_| |_| |_| |_|  \___|    \____/    \_/    \___| |_|   
                                                                     
                                                                     
                    ";
                    Console.WriteLine(gameOver);
                    Console.WriteLine("\nPress any key to Start again...");
                    Console.ReadKey();
                    programRun();
                    break;
                }
                else
                {
                    scoreCount(i);
                    i++;

                }

                if (i == 2)
                {
                    //give 2nd player start
                    i = i - 2;
                }
            }
        }

        //game exit
        void exit()
        {
            gamePlayer gamePlayer1 = player[0];
            gamePlayer gamePlayer2 = player[1];
            Console.WriteLine(gamePlayer1.getName() + " Score is : " + gamePlayer1.getScore());
            Console.WriteLine(gamePlayer2.getName() + " Score is : " + gamePlayer2.getScore());
        }

        //Whole Program Start

        void programRun()
        {
            int startOption = 0;
            do
            {
                programStart();
                try
                {
                    startOption = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter valid entry");
                    
                }
                if (startOption == 1)
                {
                    gamePlay();
                }
                else if (startOption == 2)
                {
                    showRules();
                }
                else if (startOption == 3)
                {
                    break;
                }
                else
                {
                    startOption = 0;
                }
            } while (startOption != 3);
            {
                Console.WriteLine("Thank You For Playing. Have a Nice Day!....");
            }


        }
        programRun();
    }

}
        
