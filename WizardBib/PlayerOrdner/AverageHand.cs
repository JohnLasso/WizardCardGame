using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.PlayerOrdner
{
    public class AverageHand : AbstractOpponent
    {
        public AverageHand() : base()
        {

        }

        public override void setRound(int round)
        {
            base.setRound(round);
            double suitProbablility = 13.0 / 60.0;
            setMenschen(suitProbablility * round);
            setZwerge(suitProbablility * round);
            setRiesen(suitProbablility * round);
            setElfen(suitProbablility * round);

            double specialCardProbablility = 4.0 / 60.0;
            setWizards(specialCardProbablility * round);
            setNarren(specialCardProbablility * round);
        }


    }
}
