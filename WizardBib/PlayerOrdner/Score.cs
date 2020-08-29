using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Player
{
   public class Score
    {

        private List<IndividualScore> individualScoreCollection = 
            new List<IndividualScore>();

        public void displayScore()
        {
            //for (IndividualScore individualScore: this.individualScoreCollection) {
            //	_logger.info(individualScore.getPlayer().getName()
            //			+ " = " + individualScore.getScore() + " points");
            //}
        }

		public void addIndividualScore(IndividualScore individualScore)
		{
			IPlayer currentPlayer = individualScore.getPlayer();
			IndividualScore previousIndividualScore = null;
			foreach (IndividualScore tempIndividualScore in individualScoreCollection)
			{
				if (tempIndividualScore.getPlayer().Equals(currentPlayer))
				{
					previousIndividualScore = tempIndividualScore;
				}
			}
			if (previousIndividualScore == null)
			{
				this.individualScoreCollection.Add(individualScore);
			}
			else
			{
				this.individualScoreCollection.Remove(previousIndividualScore);
				IndividualScore combinedIndividualScore = new IndividualScore(
						currentPlayer, previousIndividualScore.getScore()
								+ individualScore.getScore());
				this.individualScoreCollection.Add(combinedIndividualScore);
			}
		}

		public List<IndividualScore> getIndividualScoreCollection()
		{
			return individualScoreCollection;
		}




	}
}

