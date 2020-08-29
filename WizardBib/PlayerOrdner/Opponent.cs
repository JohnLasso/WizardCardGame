using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.PlayerOrdner
{
    public class Opponent : AbstractOpponent
    {
        private int numberOfTricksNeeded = 0;
        private bool playedTrick = false;
        private bool needToBid = false;
        private int score = 0;
        private int cardsRemaining = 0;

        public Opponent(int id, String name)
        {
            setId(id);
            setName(name);
        }

        public override void setRound(int round)
        {
            base.setRound(round);
            this.playedTrick = false;
            setMenschen(0);
            setZwerge(0);
            setRiesen(0);
            setElfen(0);
            setNarren(0);
            setWizards(0);
        }

        public void setBid(int bid)
        {
            base.setBid(bid);
            this.numberOfTricksNeeded = bid;
            this.needToBid = false;
        }

        public void tookTrick()
        {
            this.numberOfTricksNeeded -= 1;
        }

        public bool isPlayedTrick()
        {
            return playedTrick;
        }

        public void setPlayedTrick(bool playedTrick)
        {
            this.playedTrick = playedTrick;
        }

        public void played(Card lead, Card highCard, Card played)
        {
            Suit suit = played.suit;
            Value value = played.getValue();
            if (suit.Equals(Suit.Menschen))
            {
                setMenschen(getMenschen() + 1);
            }
            else if (suit.Equals(Suit.Zwerge))
            {
                setZwerge(getZwerge() + 1);
            }
            else if (suit.Equals(Suit.Elfen))
            {
                setElfen(getElfen() + 1);
            }
            else if (suit.Equals(Suit.Riesen))
            {
                setRiesen(getRiesen() + 1);
            }
            else if (value.Equals(Value.Wizard))
            {
                setWizards(getWizards() + 1);
            }
            else if (value.Equals(Value.Null))
            {
                setNarren(getNarren() + 1);
            }
            if (suit.Equals(Suit.Andere))
            {
                return;
            }
            if (lead == null)
            {
                return;
            }
            Suit leadSuit = lead.suit;
            if (leadSuit.Equals(Suit.Andere))
            {
                return;
            }
            // -1 means out of that suit;
            if (suit.Equals(leadSuit) == false)
            {
                if (leadSuit.Equals(Suit.Menschen))
                {
                    setHasMenschen(false);
                }
                else if (leadSuit.Equals(Suit.Zwerge))
                {
                    setHasMenschen(false);
                }
                else if (leadSuit.Equals(Suit.Elfen))
                {
                    setHasElfen(false);
                }
                else if (leadSuit.Equals(Suit.Riesen))
                {
                    setHasRiesen(false);
                }
            }
        }
        public bool needsToBid()
        {
            return needToBid;
        }
        public void changeScore(int scoreChange)
        {
            this.score += scoreChange;
        }
        public int getScore()
        {
            return score;
        }
        public int getCardsRemaining()
        {
            return cardsRemaining;
        }
        public void setCardsRemaining(int cardsRemaining)
        {
            this.cardsRemaining = cardsRemaining;
        }
        public int getNumberOfTricksNeeded()
        {
            return numberOfTricksNeeded;
        }


    }
}
