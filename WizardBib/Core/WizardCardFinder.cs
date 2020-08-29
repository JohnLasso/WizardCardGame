using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Core
{
    public class WizardCardFinder : ICardFinder
    {
        public Card findCard(int i)
        {
            Value value = Value.findValueByIndex(i % 15);
            Suit suit;
            int index;
            if (value.Index == Value.Null.Index || value.Index == Value.Wizard.Index)
            {
                suit = Suit.Andere;
                index = ((i / 15) % 4) + 1;
            }
            else
            {
                suit = Suit.findSuitByIndex((i / 15) % 4);
                index = ((i / 15) % 4) + 1;
            }
            return new Card(value, suit, index);
        }

        public int getCardsInDeck()
        {
            //60 Karten im Game
            return 60;
        }
    }
}
