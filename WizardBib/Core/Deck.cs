using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WizardBib.Core
{
    public class Deck
    {
        private ICardFinder cardFinder = null;

        public int CARDS_IN_DECK { get; private set; }
   

        private List<Card> unshuffledDeck = new List<Card>();

        public List<Card> shuffledDeck = new List<Card>();

        private List<Card> notInDeck = new List<Card>();

        private static long randomSeed;
        private static Random rnd = null;

        public Deck()
        {
            CARDS_IN_DECK = getCardFinder().getCardsInDeck();

            for (int i = 0; i < this.CARDS_IN_DECK; i++)
            {
                unshuffledDeck.Add(getCardFinder().findCard(i));
            }
        }

        public Deck(ICardFinder cardFinder)
        {
            setCardFinder(cardFinder);
            CARDS_IN_DECK = getCardFinder().getCardsInDeck();
            for (int i = 0; i < this.CARDS_IN_DECK; i++)
            {
                this.unshuffledDeck.Add(getCardFinder().findCard(i));
            }
        }

        /**
	 * Puts the cards into deckArray.
	 */
        public void shuffle()
        {
            if (rnd == null)
            {
                rnd = new Random();
               //TODO evtl.Shuffle anpassen
            }

            for (int i = 0; i < this.CARDS_IN_DECK; i++)
            {
                int randomCardNumber = (int)(rnd.NextDouble() * unshuffledDeck.Count);
                shuffledDeck.Add(unshuffledDeck[randomCardNumber]);
                this.unshuffledDeck.RemoveAt(randomCardNumber);
            }
        
        }

        /**
	 * Grabs a card from the top of the deck.
	 * @return Card
	 */
        public int getFirstCard()
        {
            Card card = this.shuffledDeck[0];
            this.notInDeck.Add(card);
            this.shuffledDeck.Remove(card);
            return CARDS_IN_DECK;
        }

        /**
	 * Answers the question "Are there more cards left in the deck"
	 * @return boolean
	 */
        public bool hasCards()
        {
            if(!shuffledDeck.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /**
	 * returns the number of cards that haven't been dealt out.
	 * @return int
	 */
        public int getCardsLeft()
        {
            return this.shuffledDeck.Count;
        }

        public void returnCard(Card card)
        {
            if (this.notInDeck.Contains(card) == false)
            {
               //card not out
            }

            this.notInDeck.Remove(card);
            this.unshuffledDeck.Add(card);
        }



        public void setCardFinder(ICardFinder cardFinder)
        {
            //findCard, getsCardsinDeck
            this.cardFinder = cardFinder;
        }

        private ICardFinder getCardFinder()
        {
            if (cardFinder == null)
            {
                cardFinder = new WizardCardFinder();
            }
            return cardFinder;
        }

    }
}
