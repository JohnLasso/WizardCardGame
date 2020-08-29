using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Stats
{
    public class Play
    {
        private int playerId;
        private Card card;

        public Play(int playerId, Card card)
        {
            this.playerId = playerId;
            this.card = card;
        }

        public Card getCard()
        {
            return card;
        }

        public void setCard(Card pCard)
        {
            card = pCard;
        }

        public int getPlayerId()
        {
            return playerId;
        }

        public void setPlayerId(int pPlayerId)
        {
            playerId = pPlayerId;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(playerId).Append(":").Append(card);
            return sb.ToString();
        }
    }
}
