using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Core
{
    public interface ICardFinder
    {
        public Card findCard(int i);
        public int getCardsInDeck();
    }
}
