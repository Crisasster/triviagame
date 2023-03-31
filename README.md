#triviagame

Hello! This is a fun little trivia I designed to test a players knowledge about animals they may not have heard of. Some of the animals featured such as Palla's Cat, are at the risk of extinction. So I'm hoping to bring some awareness to that issue as well. My trivia game plays like a traditional trivia game you would see during a game show, featuring a question with four possible answers. This project was pretty simple, although I did get stuck a bit, and was able to get unstuck by rewatching Pluralsite videos, youtube tutorials, and reading the book Head First C#. This project isn't very complicated, but it was easy for me to understand what I was doing and play around with code to make it run like I wanted.

#Here are some of the features that I have used you will see implemented in my project;

-My project features multiple classes. These classes inherit off each other and work with each other to keep the game running as it does. Most of the coding is done in the Game and Trivia classes.
-The Game class contains the questions as well as a title page and the method to display the questions to the user. 
The Player class contains the function for the player, it is a simple class that helps write the players name and answers into the Game and Trivia classes.
The Program class features the functions for a new game as well as the master loop and an ending page.
Finally the Trivia class generates call and responses for the players answers to the questions. This is where it reads the players answer and displays a right or
wrong response.

#Code Louisville feature requirements I have included;
-Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program
-Create an additional class which inherits one or more properties from its parent
-Use a LINQ query to retrieve information from a data structure (such as a list or array) or file

#Features
- Master loop that runs once the player reaches the last question, and ask if they want to play again This is in the Program class.
- This project heavily relies on OOP. There are multiple child Classes Player, and Trivia. Which inherit from the parent class of Game.
- The If/Else method in Trivia, lets the player know if they answered correctly. If the answer is correct, the console will return a correct reponse, while if the player answers wrongly, it will let them know the correct answer. 
- Because the Console function is used a lot I am using, "using static System.Console" in a few of the classes where the Console function is used a bit to make the code look cleaner.
- There is a title page at the beginning that welcomes the user to start the game, as well as an end screen after the player answers all questions.
- While not really a big deal to the overall program itself. I did have fun playing around with different colors and ASCII art.

#to do
-I would like to come back and find a way to add a player score to the game.
-I would also like to add a fact about the animal omce the player answers correctly. 

#to run
My project uses the, using static System.Console; feature in the classes Game and Trivia. So that way the Console feature is already implemeted and I don't have to type Console. multiple times. If you are having issues running my program on your device, this maight be why.
