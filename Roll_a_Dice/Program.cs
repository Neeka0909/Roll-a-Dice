using System;


public class gamePlayer
{
    public int id;
    public String name;
    public int turn;
    public int score;
    
    public gamePlayer(int id, String name)
    {
        this.id = id;
        this.name = name;
    }

    public gamePlayer(int id, string name, int turn, int score)
    {
        this.id = id;
        this.name = name;
        this.turn = turn;
        this.score = score;
    }

    public int getId()
    {
        return id;
    }

    public String getName()
    {
        return name;
    }

    public int getTurn()
    {
        return turn;
    }

    public int getScore()
    {
        return score;
    }

    public void setId(int newId)
    {
        id = newId;
    }

    public void setName(String newName)
    {
        name = newName;
    }

    public void setTurn(int newTurn)
    {
        turn = newTurn;
    }

    public void setScore(int newScore)
    {
        score = newScore;
    }

    public static void Main(String[] args)
    {
        void programStart()
        {
            Console.WriteLine("Welcome to Roll A Dice Game...");
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Start the Game.");
            Console.WriteLine("2. Show the Game Rules.");
            Console.WriteLine("3. Exit");
        }

        void showRules()
        {
            Console.WriteLine("* Number of Players: 02  \n* Number of Players: 02 \n* Winning Score: 100 \n");
            Console.WriteLine("* Each player will get a chance to roll two dices at the same time. The process given below will \r\ncontinues until one player reaches the winning score. \n* If 02 dices give the same result (except the dice value 1), the same player will get another \r\nchance to roll the dice.\n* Else other player gets the chance to roll 02 dices.");
            Console.WriteLine("\n \nCalculation of score: \n* If both dices give the value 1, the individual marks of the respective player will be \r\nreduced to 0.\r\n* Else sum of the two dice values will be added to individual scores of the respective \r\nplayer.\r\n");
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Back to Start window.");
            Console.WriteLine("2. Exit the Game");

            int optionRules = 0;

            do
            {
                try
                {
                    optionRules = int.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Please Enter the correct value."); }
                if (optionRules == 1) { programStart(); }
                else if (optionRules == 2) { break; }
            }while(optionRules != 2);
            {
                Console.WriteLine("Thank You, have a Nice Day!!");
            }

        }

        List<gamePlayer> player = new List<gamePlayer>();

        //Player Details saved
        void playerAdd()
        {
            String playerName = "";
            bool count = true;
            int i = 1;
            while (count == true)
            {
                Console.WriteLine("Please enter Player " + i + " Name :");
                playerName = Console.ReadLine();
                player.Add(new gamePlayer(i, playerName, 0 , 0));
                i++;   
                if (i == 3)
                {
                    count=false;
                }
            }
            

        }
        //Player selection do not need player 1 start the game
        gamePlayer currentPlayer;
        void playerSelect()
        {
            Console.WriteLine("Please Select Player :");
            int j;
            for (int i = 0; i < player.Count; i++)
            {
                currentPlayer = player[i];
                j = i + 1;
                Console.WriteLine(j + ". "+ currentPlayer.getName() +".");
            }
            int playerOption = 0;

            do
            {
                try
                {
                    playerOption = int.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Incorrect input !!!"); }

                if (playerOption==1)
                {
                    currentPlayer = player[1];
                    Console.WriteLine("Press any Key to Roll a Dice...");
                    Console.ReadKey();
                    rollADice(currentPlayer);

                }

            }while (playerOption != 0);

        }

        var x = 0;
        var y = 0;
        //Dice Role local function
        void rollADice(gamePlayer currentPlayer)
        {
            Random rand = new Random();
            x = rand.Next(0, 7);
            y = rand.Next(0, 7);

            Console.WriteLine("\nDice 1 Result: " + x);
            Console.WriteLine("Dice 1 Result: " + y + "\n");

            if (x == 1 && y ==1)
            {

            }

        }

    }
}