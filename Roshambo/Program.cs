using System.Numerics;
using Roshambo;
HumanPlayer playerOne = new HumanPlayer();
HumanPlayer playerTwo = new HumanPlayer();
RandomPlayer randy = new RandomPlayer("Randy");
RockPlayer rocky = new RockPlayer("Rocky");
int pOneWinCounter = 0;
int pTwoWinCounter = 0;


Console.WriteLine("Welcome To Rock,Paper,Scissor");
Console.WriteLine("please enter your name");
playerOne.Name = Console.ReadLine();
SetGame();











void SetGame()
{
    bool playAgain = true;
    while (playAgain)
    {
        Console.WriteLine("your Opponents are rocky, randy or enter a name to create your own opponent");
        Console.WriteLine("please Choose your opponent");
        string opponent = Console.ReadLine().ToLower();
        switch(opponent)
        {
            case "rocky":
                playerOne.GenerateRoshambo();
                rocky.GenerateRoshambo();
                Play(playerOne, rocky);
                break;
            case "randy":
                playerOne.GenerateRoshambo();
                randy.GenerateRoshambo();
                Play(playerOne, randy);
                break;
            default:
                playerTwo.Name = opponent;
                Console.WriteLine($"{playerOne.Name}:");
                playerOne.GenerateRoshambo();
                Console.WriteLine($"{playerTwo.Name}:");
                playerTwo.GenerateRoshambo();
                Play(playerOne, playerTwo);
                break;      
        }

        playAgain = Validator.GetYN();

        if (!playAgain)
        {
            Console.WriteLine("Thank you for playing");
            Console.WriteLine($"The final socore is:");
            Console.WriteLine($"{playerOne.Name}: {pOneWinCounter}");
            Console.WriteLine($"{opponent}: {pTwoWinCounter}");
            break;
        }
    }
}

 void Play(Player firstPlayer, Player secondPlayer)
{
    string pOneName = firstPlayer.Name;
    string pTwoName = secondPlayer.Name;
    Roshambo.Roshambo pOneValue = firstPlayer.Value;
    Roshambo.Roshambo pTwoValue = secondPlayer.Value;

    Roshambo.Roshambo rock = Roshambo.Roshambo.Rock;
    Roshambo.Roshambo paper = Roshambo.Roshambo.Paper;
    Roshambo.Roshambo scissors = Roshambo.Roshambo.Scissors;
     
    switch (pOneValue)
    {
        case Roshambo.Roshambo.Rock:
            if(pTwoValue == rock)
            {
                Console.WriteLine($"both {pOneName} and {pTwoName} selected {firstPlayer.Value} which resulted in a tie");
            }
            else if (pTwoValue == paper)
            {
                Console.WriteLine($"{pOneName}: {pOneValue}");
                Console.WriteLine($"{pTwoName}: {pTwoValue}");
                Console.WriteLine($"{pTwoValue} beats {pOneValue} {pOneName} wins");
                pTwoWinCounter++;
            }
            else if (pTwoValue == scissors)
            {
                Console.WriteLine($"{pOneName}: {pOneValue}");
                Console.WriteLine($"{pTwoName}: {pTwoValue}");
                Console.WriteLine($"{pTwoValue} beats {pOneValue} {pTwoName} wins");
                pTwoWinCounter++;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            break;
        case Roshambo.Roshambo.Paper:
            if (pTwoValue == paper)
            {
                Console.WriteLine($"both {pOneName} and {pTwoName} selected {firstPlayer.Value} which resulted in a tie");
            }
            else if (pTwoValue == scissors)
            {
                Console.WriteLine($"{pOneName}: {pOneValue}");
                Console.WriteLine($"{pTwoName}: {pTwoValue}");
                Console.WriteLine($"{pTwoValue} beats {pOneValue} {pTwoName} wins");
                pTwoWinCounter++;
            }
            else if (pTwoValue == rock)
            {
                Console.WriteLine($"{pOneName}: {pOneValue}");
                Console.WriteLine($"{pTwoName}: {pTwoValue}");
                Console.WriteLine($"{pOneValue} beats {pTwoValue} {pOneName} wins");
                pOneWinCounter++;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            break;
        case Roshambo.Roshambo.Scissors:
            if (pTwoValue == scissors)
            {
                Console.WriteLine($"both {pOneName} and {pTwoName} selected {firstPlayer.Value} which resulted in a tie");
            }
            else if (pTwoValue == rock)
            {
                Console.WriteLine($"{pOneName}: {pOneValue}");
                Console.WriteLine($"{pTwoName}: {pTwoValue}");
                Console.WriteLine($"{pTwoValue} beats {pOneValue} {pTwoName} wins");
                pTwoWinCounter++;
            }
            else if (pTwoValue == paper)
            {
                Console.WriteLine($"{pOneName}: {pOneValue}");
                Console.WriteLine($"{pTwoName}: {pTwoValue}");
                Console.WriteLine($"{pOneValue} beats {pTwoValue} {pOneName} wins");
                pOneWinCounter++;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            break;
            
    }
}

   









