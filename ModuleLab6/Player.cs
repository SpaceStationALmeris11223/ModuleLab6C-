using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Module6Lab
{
    internal class Player
    { //Internal means anyone in the program can use the class. No outside however
        private string name;
        private int score;
        private int livesLeft;
//Construtors are down below
        public Player(string name)
        {
            this.name = name;
        }
        public Player(string name, int startingLives)
        {
            this.name = name; //Sets the name of the player
            livesLeft = startingLives;
        }// ends constructor metheod

        public int GetScore()
        {
            return score;
        }// end get score method
        public Player()
        {

        }
        //adds points to the players score

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        } //end add points method

        //kill method alllows you to kill of the player
        public void kill()
        {
            //need to make sure that player can't get -lives
            if (livesLeft > 0)
            {
                livesLeft--;
            }// end if
        }// end kill method

        //get the lives left for the player

        public int GetLivesLeft()
        {
            return livesLeft;
        }
    }
}
//methods for the player class - actions the player can perform

//returns the players current score
