using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WizardBib.Stats;

namespace WizardBib.PlayerOrdner
{
    public class TrickTracker
    {
        private Card trump;

        private List<Play> playCollection = new List<Play>();

        private Play highPlay = null;

        public TrickTracker(Card trump)
        {
            this.trump = trump;
        }

        public bool isLead()
        {
			return playCollection.Any();
        }

        public void addCardPlayed(int playerId, Card card)
        {
            Play play = new Play(playerId, card);
            this.playCollection.Add(play);
            setHighPlay(play);
        }

		//WHO WINS?!
		private void setHighPlay(Play play)
		{
			// if nothing is high yet, then it's high.
			if (highPlay == null)
			{
				highPlay = play;
				// if the high card is a jester and the card played is a jester, then the first jester takes it.
			}
			else if (highPlay.getCard().getValue().Equals(Value.Wizard)
				  && play.getCard().getValue().Equals(Value.Wizard))
			{
				highPlay = play;
				// if the high card is the same suit as the card played, then the higher value is the high play.
			}
			else if (play.getCard().suit.Equals(highPlay.getCard().suit)
					  && play.getCard().getValue().Index > highPlay.getCard().getValue().Index)
			{
				highPlay = play;
				// if the high card isn't trump and the person played trump, then trump wins.
			}
			else if (this.trump != null && trump.suit.Equals(Suit.Andere) == false
				  && play.getCard().suit.Equals(this.trump.suit)
				  && highPlay.getCard().getValue().Equals(Value.Wizard) == false
				  && highPlay.getCard().suit.Equals(this.trump.suit) == false)
			{
				highPlay = play;
				// if the high card is not a wizard and someone played a wizard, then they win.
			}
			else if (highPlay.getCard().getValue().Equals(Value.Wizard) == false
				  && play.getCard().getValue().Equals(Value.Wizard))
			{
				highPlay = play;
			}
		}

		public Play winningPlay()
		{
			return highPlay;
		}

		public List<Play> getPlayCollection()
		{
			return playCollection;
		}
	}
}
