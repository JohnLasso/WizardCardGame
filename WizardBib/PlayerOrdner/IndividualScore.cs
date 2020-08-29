using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Player
{
    public class IndividualScore
    {
        private IPlayer player;

        private int score;

        public IndividualScore(IPlayer player, int score)
        {
            this.player = player;
            this.score = score;
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public int getScore()
        {
            return this.score;
        }

        public IPlayer getPlayer()
        {
            return this.player;
        }
    }
}
