
string Rock = "rock";
string Paper = "paper";
string Scissors = "scissors";

Console.WriteLine("Choose: [r]ock, [p]aper, or [s]cissors");
string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid input. Try Again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMove}.");

if (playerMove == Rock && computerMove == Scissors ||
    playerMove == Paper && computerMove == Rock ||
    playerMove == Scissors && computerMove == Paper)
{
    Console.WriteLine("You win");
}
else if (playerMove == computerMove)
{
    Console.WriteLine("This game was a draw.");
}
else
{
    Console.WriteLine("Computer win");
}
Console.WriteLine("it was a great game!");
Console.WriteLine("thanks for playing!");