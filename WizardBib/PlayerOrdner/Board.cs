using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Player
{
    public interface IBoard
    {
        public List<IPlayer> initializePlayers();
        public ISeat getNorthSeat();
        public ISeat getSouthSeat();
        public ISeat getEastSeat();
        public ISeat getWestSeat();
        public void stateChanged();
    }
}
