using System;
using System.Collections.Generic;

namespace WizardBib
{
    public class Hand : List<Card>
    {
        private List<Card> MenschenList = new List<Card>();
        private List<Card> ZwergeList = new List<Card>();
        private List<Card> ElfenList = new List<Card>();
        private List<Card> RiesenList = new List<Card>();
        private List<Card> WizardList = new List<Card>();
        private List<Card> NarrList = new List<Card>();

        public Hand() : base()
        {
           
        }

        public Hand(List<Card> cards) : base(cards)
        {
        }

        public bool add(Card card)
        {
            bool result = this.add(card);

            Suit suit = card.suit;
            Value value = card.value;

            if (suit.Equals(Suit.Menschen))
            {
                MenschenList.Add(card);
            }
            else if (suit.Equals(Suit.Zwerge))
            {
                ZwergeList.Add(card);
            }
            else if (suit.Equals(Suit.Elfen))
            {
                ElfenList.Add(card);
            }
            else if (suit.Equals(Suit.Riesen))
            {
                RiesenList.Add(card);
            }
            else if (suit.Equals(Value.Wizard))
            {
                WizardList.Add(card);
            }
            else if (suit.Equals(Value.Null))
            {
                NarrList.Add(card);
            }

            return result;
        }

        public bool remove(object obj)
        {
            bool result = this.remove(obj);
            if (obj is Card == false)
            {
                return result;
            }

            Card card = (Card)obj;
            Suit suit = card.suit;
            Value value = card.value;
            if (suit.Equals(Suit.Menschen))
            {
                MenschenList.Remove(card);
            }
            else if (suit.Equals(Suit.Zwerge))
            {
                ZwergeList.Remove(card);
            }
            else if (suit.Equals(Suit.Elfen))
            {
                ElfenList.Remove(card);
            }
            else if (suit.Equals(Suit.Riesen))
            {
                RiesenList.Remove(card);
            }
            else if (suit.Equals(Value.Wizard))
            {
                WizardList.Remove(card);
            }
            else if (suit.Equals(Value.Null))
            {
                NarrList.Remove(card);
            }
            return result;

        }

        /**
       * @return the clubList
       */
        public List<Card> getMenschenList()
        {
            return MenschenList;
        }

        /**
         * @return the diamondList
         */
        public List<Card> getZwergenList()
        {
            return ZwergeList;
        }

        /**
         * @return the heartList
         */
        public List<Card> getRiesenList()
        {
            return RiesenList; 
        }

        /**
         * @return the jesterList
         */
        public List<Card> getWizardList()
        {
            return WizardList;
        }

        /**
         * @return the spadeList
         */
        public List<Card> getNarrenList()
        {
            return NarrList;
        }

        /**
         * @return the wizardList
         */
       
    }


}