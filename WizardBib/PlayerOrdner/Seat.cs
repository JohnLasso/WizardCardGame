using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Player
{
    public interface ISeat
    {
        public void setPlayer(IPlayer player);
        public IPlayer getPlayer();
    }
}
