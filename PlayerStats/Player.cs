using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;

        //properties:
        public float HighScore 
        {
            get 
            {
                return highScore;
            }
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }

        }
        public string Name { get;}
        public float WinRate
        {
            get 
            {
                if (playedGames == 0)
                {
                    return 0f;
                } 
                else
                {
                    return ((float)wonGames/playedGames);
                }
                
            }
        }

        public Player(string name)
        {
            Name = name;
            playedGames = 0;
            wonGames = 0;

        }
        public void PlayGame (bool win)
        {
            playedGames++;
            if (win) wonGames++;
        }


        
        


    }
}