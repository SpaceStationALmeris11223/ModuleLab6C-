// See https://aka.ms/new-console-template for more information
using Module6Lab;//Similar to import on Python will pull all of the other classes from namespace

//Create new player with no life and add poiont to the players scroe
Player player = new Player("Frankenstein", 1);
player.AddPoints(100);

//Display the player'score
Console.WriteLine("Welcome to the game! Your score is : " + player.GetScore() +
    "You have " + player.GetLivesLeft() + " Lives Left");

//Kill off the player char
player.kill();

//Lets the player know their character died
Console.WriteLine(" The Black Knight attacks, you were slain.... You have" + player.GetLivesLeft() + " lives left!");



//Create a heroic chamption
HeroicChampion Iliana = new HeroicChampion();

Iliana.AddPoints(200);
Iliana.Fly();//Demonstrats child class special ability
Console.WriteLine($" Iliana score: {Iliana.GetScore()}, lives left: {Iliana.GetLivesLeft()}");
internal class HeroicChampion : Player //== Heroic champion is the child of player
{
    //additonal propertires
    //This method is specific to SuperPlayer (it doesn't exist in the parent class of player)
    public void Fly()
    { // void because it doesn't return a value
        Console.WriteLine(" HeroicChampion is Flying!");
    }//end Method
}

