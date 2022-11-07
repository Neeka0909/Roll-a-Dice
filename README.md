# Roll-a-Dice

                    .______        ______    __       __              ___          _______   __    ______  _______ 
                    |   _  \      /  __  \  |  |     |  |            /   \        |       \ |  |  /      ||   ____|
                    |  |_)  |    |  |  |  | |  |     |  |           /  ^  \       |  .--.  ||  | |  ,----'|  |__   
                    |      /     |  |  |  | |  |     |  |          /  /_\  \      |  |  |  ||  | |  |     |   __|  
                    |  |\  \----.|  `--'  | |  `----.|  `----.    /  _____  \     |  '--'  ||  | |  `----.|  |____ 
                    | _| `._____| \______/  |_______||_______|   /__/     \__\    |_______/ |__|  \______||_______|

Roll a Dice game Developed using the C#

## 1. Game rules
Number of Players: 02
Number of Dices: 02
Winning Score: 100 

Each player will get a chance to roll two dices at the same time. The process given below will 
continues until one player reaches the winning score.
  - If 02 dices give the same result (except the dice value 1), the same player will get another 
  chance to roll the dice.
  - Else other player gets the chance to roll 02 dices.

Calculation of score:
  - If both dices give the value 1, the individual marks of the respective player will be 
  reduced to 0.
  - Else sum of the two dice values will be added to individual scores of the respective 
  player.

## 2.	Approach to coding 
In the beginning of the building the given game, create the use-case diagram to understand the user’s possible interaction with the system.  Then identify some of the basic functions which will be useful for user’s when using this application. The whole program is developed using OOP concepts. This game based on game players, so the main class of the program created based on game player and create the attributes which are related to game player. Then the objects were created referring this main class and this object acts as players. These objects use to save and retrieve each players respective data.  The code splits into several methods and several local functions to follows the OOP concepts. Which helps to reduce the coding time and program efficiency. To simulate the dice the random number generator uses and its limit range to 1 to 6. The player rolls two dices in a single instance the 2 random numbers were generated. The score calculated using the given instruction and game stop after one of each player will score 100 points.

## 3.	Game Logic
### 3.1	Start Screen. 
The start screen is used to navigate through the game window, and it will display the 3 user selectable options. As given bellow. 

![Figure 1 - Start Screen ](https://user-images.githubusercontent.com/50359663/200342279-518820a9-9dc0-4c29-a428-7e72b98bbc12.png)

The above image shows that the game start screen. This screen shows the 3 options to choose the users. If player wants to start the game, he can choose option 1 and then program allows to player to play the game. If player needs to read game instruction, he can choose 2nd options and if player needs to exit, he can choose 3rd option.  Inside the program each option follows a local function which wrote inside of the main method. As the example when the player select the show game rules option the program called the  `showRules()` function and execute it. To the option selection uses do-while loop and if…else code block. To handle exceptions try catch block uses when checking user inputs. The start screen is wrote inside of the  `programStart()` local functions. and The `showRules()` functions work same as the `programStart()` functions. 

![Figure 2 - Show rules screen ](https://user-images.githubusercontent.com/50359663/200342975-7fa2a058-345b-4e86-ab9e-080c192f73fe.png)

### 3.2	Gameplay logic
When the starting of the game play, each player name was saved into list which was crated based on main class in this step program add id into player, which helps to call the respective player attributes and properties later functions. The players entered name used to identify the players while playing the game.  This player name add function called `playerAdd()`. 

![Figure 3 - Add player screen](https://user-images.githubusercontent.com/50359663/200342946-5bbd70c3-c9e5-4011-af98-2bf7665cc905.png)

Then start playing game, the dices roll event simulates the random number generator functions and it is wrote inside of the `rollADice()` local function. This function returns the randomly generated two dices value at same time using the tuple. The tuple enables the retrieve the 2 return values. Then check those generated values are equal or both equal to 1 or both are not equal. These incidents were checked using the if…else code block. Then execute the corresponding event and calculation of the scores using the values of the dices. `scoreCount()` local function used to calculate each player’s  current game play score,  total score of his/her. 

`gamePlay()` local function used to maintain the flow of the game play. It constantly checks each players total score using the while loop and if one of each player score 100 points or above stop the game and display game over text. `programRun()` function control the game start to end. This function used to show the start screen (as figure 1) and respond to the user select options on each stage. In the development of the game try and catch block use in user inputs to handle exceptions. 

#### Screenshots of Game play

![When both dices give the same value ](https://user-images.githubusercontent.com/50359663/200343605-b7013ba0-54f0-4847-898c-629ae3fd99f1.png)

![When both dices give the value 1 ](https://user-images.githubusercontent.com/50359663/200343632-1287ee8d-29fb-44d6-b85b-79a4d17882ad.png)

![Game end Screen :](https://user-images.githubusercontent.com/50359663/200343657-95229372-5df9-41e5-981e-2f6a9fcf828a.png)




