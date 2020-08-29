using System;
using System.Collections.Generic;
using System.Text;
using WizardBib.Stats;

namespace WizardBib.PlayerOrdner
{
    public class ValidityChecker
    {

		public static bool checkValidity(TrickTracker trickTracker, Card trump, Card attemptedToPlayCard, IPlayer player)
		{
			// played a wizard or jester
			if (attemptedToPlayCard.suit.Equals(Suit.Andere))
			{
				return true;
			}

			// no cards have been played yet, so anything is available.
			if (trickTracker.isLead())
			{
				return true;
			}

			Card lead = null;
			
			foreach (Play play in trickTracker.getPlayCollection())
			{
				Card temp = play.getCard();
				if (temp.suit.Equals(Suit.Andere))
				{
					if (temp.getValue().Equals(Value.Null))
					{
						// jester played, so find the next non-jester for what's lead.
						continue;
					}
					// wizard lead so anything can be played
					return true;
				}
				lead = temp;
				break;
			}

			// only jesters have been led so far, so anything is allowed.
			if (lead == null)
			{
				return true;
			}

			// if you played the lead suit, that's fine.
			if (attemptedToPlayCard.suit.Equals(lead.suit))
			{
				return true;
			}

			foreach (Card otherCard in player.getHand())
			{
				if (otherCard.suit.Equals(lead.suit))
				{
					// has a card of the lead suit, but didn't play it and the card they played wasn't a jester or wizard.
				
					return false;
				}
			}

			return true;
		}
	}
}
