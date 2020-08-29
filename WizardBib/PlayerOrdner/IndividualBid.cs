namespace WizardBib.Player
{
    public class IndividualBid
    {
        private IPlayer player;

        private int bid;

        public IndividualBid(IPlayer player, int bid)
        {
            this.player = player;
            this.bid = bid;
        }

        public IPlayer getPlayer()
        {
            return this.player;
        }

        public int getBid()
        {
            return this.bid;
        }
    }
}