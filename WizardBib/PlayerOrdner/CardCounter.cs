using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.PlayerOrdner
{
    public class CardCounter
    {
		private int[] Menschen = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
		private int[] Zwerge = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
		private int[] Riesen = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
		private int[] Elfen = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
		private int wizard = 4;
		private int narren = 4;
		private int cardsDealt = 0;
		private int cardsNotDealt = 60;
		private int cardsPlayed = 0;
		private int cardsRemainingInHands = 0;

		public void init(int numberOfPlayers, int cardsPerPlayer)
		{
			cardsDealt = numberOfPlayers * cardsPerPlayer;
			cardsNotDealt = cardsNotDealt - cardsDealt;
			cardsRemainingInHands = cardsDealt;
		}

		public void setTrump(Card card)
		{
			if (card == null)
			{
				return;
			}
			Value value = card.getValue();
			if (value == null)
			{
				return;
			}
			countCard(card);
			cardsDealt++;
			cardsNotDealt--;
			// undo the count for player played
			cardsRemainingInHands++;
			cardsPlayed--;
		}

		public void countCard(Card card)
		{
			Suit suit = card.suit;
			Value value = card.getValue();
			int index = findCardIndex(value);
			if (suit.Equals(Suit.Menschen))
			{
				Menschen[index] = 0;
			}
			else if (suit.Equals(Suit.Elfen))
			{
				Elfen[index] = 0;
			}
			else if (suit.Equals(Suit.Riesen))
			{
				Riesen[index] = 0;
			}
			else if (suit.Equals(Suit.Zwerge))
			{
				Zwerge[index] = 0;
			}
			else if (suit.Equals(Suit.Andere))
			{
				if (value.Equals(Value.Wizard))
				{
					wizard -= 1;
				}
				else
				{
					narren -= 1;
				}
			}

			cardsPlayed++;
			cardsRemainingInHands--;
		}

		private int findCardIndex(Value value)
		{
			return value.Index - 1;
		}

		public int getCardsDealt()
		{
			return cardsDealt;
		}
		public int getCardsNotDealt()
		{
			return cardsNotDealt;
		}
		public int getCardsPlayed()
		{
			return cardsPlayed;
		}
		public int getCardsRemainingInHands()
		{
			return cardsRemainingInHands;
		}
		public int[] getMenschen()
		{
			return Menschen;
		}
		public int[] getZwerge()
		{
			return Zwerge;
		}
		public int[] getRiesen()
		{
			return Riesen;
		}
		public int[] getElfen()
		{
			return Elfen;
		}
		public int getMenschenCount()
		{
			return getCounter(Menschen);
		}
		public int getZwergenCount()
		{
			return getCounter(Zwerge);
		}
		public int getElfenCount()
		{
			return getCounter(Elfen);
		}
		public int getRiesenCount()
		{
			return getCounter(Riesen);
		}

		private int getCounter(int[] cards)
		{
			int i = 0;
			foreach (var j in cards)
			{
				i += j;
			}
			
			return i;
		}
	}
}
