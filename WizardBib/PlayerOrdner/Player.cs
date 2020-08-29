using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Player
{
    public class Player
    {
        private int playerID = -1;
        public string playerNameinGame = "New Player";

        public Player(int playerNumber, string playerName)
        {
            playerID = playerNumber;
            playerNameinGame = playerName;

        }

    }
}
