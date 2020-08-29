using System;

namespace WizardBib
{
    public interface IPlayer
    {
        public void setId(int id);
        public int getId();
        public string getName();
        public void giveCard(Card card);
        public Card playCard();
        public void playCardisNotValid(Card card);
        public void playCardIsValid(Card card);
        /**
	 * 
	 * Document the bid method 
	 *
	 * @param trump
	 * @param min 
	 * @param max 
	 * @param notAllowedToBid 
	 * @return int
	 */
        public int bid(Card trump, int min, int max, int notAllowedToBid);
        public Hand getHand();
        public Suit pickTrump();

    }
}
