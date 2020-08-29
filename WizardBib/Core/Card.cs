namespace WizardBib
{
    //Incomplete /suit dürfte die Farbe sein)
    public class Card
    {
        public Suit suit { get; set; }
        public Value value { get; set; }
       
        public int index { get; set; }

        public Card()
        {

        }

        public Card(Value _value, Suit _suit)
        {
            if(suit == null)
            {
                throw new System.Exception("suit == null");
            }

            this.suit = _suit;
            this.value = _value;
            this.index = -1;
        }

        public Card(Value value, Suit suit, int index)
        {
            if (suit == null)
            {
                throw new System.Exception("suit == null");
            }
            this.value = value;
            this.suit = suit;
            this.index = index;
        }

        public int getPoint()
        {
            return this.value.Index;
        }

        public Value getValue()
        {
            return this.value;
        }

        public bool isGreater(Value v)
        {
            return this.value != null && this.value.Index > v.Index;
        }

        public bool isWizard()
        {
            return this.getValue() != null && Value.Wizard.Index == this.getValue().Index;
        }

        public bool isJester()
        {
            return this.getValue() != null && Value.Null.Index == this.getValue().Index;
        }

        public bool isSameSuit(Card card)
        {
            return suit.Equals(card.suit);
        }

        public bool istMensch(Card card)
        {
            return Suit.Menschen.Equals(card.suit.Description);
        }

        public bool istElf(Card card)
        {
            return Suit.Elfen.Equals(card.suit.Description);
        }

        public bool istZwerge(Card card)
        {
            return Suit.Zwerge.Equals(card.suit.Description);
        }

        public bool istRiesen(Card card)
        {
            return Suit.Riesen.Equals(card.suit.Description);
        }

        public bool istAndere(Card card)
        {
            return Suit.Andere.Equals(card.suit.Description);
        }

        //z.B. bei Wizward
        public bool istGleicheKarte(Card card)
        {
            //TODO istGleicheKarte

            return false;
        }

    }
}