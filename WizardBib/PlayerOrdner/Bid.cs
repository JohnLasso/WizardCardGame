using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Player
{
    public class Bid
    {
        private List<IndividualBid> individualBidCollection 
            = new List<IndividualBid>();

        public IndividualBid findIndividualBidBy(IPlayer player)
        {
            IndividualBid previousIndividualBid = null;
            foreach (IndividualBid tempIndividualBid in individualBidCollection)
            {
                if (tempIndividualBid.getPlayer().Equals(player))
                {
                    previousIndividualBid = tempIndividualBid;
                }
            }
            return previousIndividualBid;
        }
        public List<IndividualBid> getBids()
        {
            return individualBidCollection;
        }
        public void addIndividualBid(IndividualBid individualBid)
        {
            individualBidCollection.Add(individualBid);
        }

        public int bidSoFar()
        {
            int bid = 0;
            foreach (IndividualBid tempIndividualBid in individualBidCollection)
            {
                bid += tempIndividualBid.getBid();
            }
            return bid;
        }


    }
    }

