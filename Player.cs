using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristinasTriviaGame1
{
    class Player
    {
        public string Name;
        public int Score;

        public Player(string PlayerName)
            {
            Name = PlayerName;
            Score = 0;
        }
    }
}
