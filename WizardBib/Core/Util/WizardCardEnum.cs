using System;
using System.Collections.Generic;
using System.Text;

namespace WizardBib.Core.Util
{
    public class WizardCardEnum
    {
        private static List<Card> values = new List<Card>();

        public static Card addValue(Card card)
        {
            values.Add(card);
            return card;
        }

        public static List<Card> getValues()
        {
            return values;
        }

        /** */
        public static Card WIZARD_1 = addValue(new Card(Value.Wizard, Suit.Andere, 1));
        /** */
        public static Card WIZARD_2 = addValue(new Card(Value.Wizard, Suit.Andere, 2));
        /** */
        public static Card WIZARD_3 = addValue(new Card(Value.Wizard, Suit.Andere, 3));
        /** */
        public static Card WIZARD_4 = addValue(new Card(Value.Wizard, Suit.Andere, 4));


        public static Card Narren_1 = addValue(new Card(Value.Null, Suit.Andere, 1));
        /** */
        public static Card Narren_2 = addValue(new Card(Value.Null, Suit.Andere, 2));
        /** */
        public static Card Narren_3 = addValue(new Card(Value.Null, Suit.Andere, 3));
        /** */
        public static Card Narren_4 = addValue(new Card(Value.Null, Suit.Andere, 4));

        /** */
        public static Card TWO_Menschen = addValue(new Card(Value.Zwei, Suit.Menschen, 1));
        /** */
        public static Card THREE_Menschen = addValue(new Card(Value.Drei, Suit.Menschen, 1));
        /** */
        public static Card FOUR_Menschen = addValue(new Card(Value.Vier, Suit.Menschen, 1));
        /** */
        public static Card FIVE_Menschen = addValue(new Card(Value.Fünf, Suit.Menschen, 1));
        /** */
        public static Card SIX_Menschen = addValue(new Card(Value.Sechs, Suit.Menschen, 1));
        /** */
        public static Card SEVEN_Menschen = addValue(new Card(Value.Sieben, Suit.Menschen, 1));
        /** */
        public static Card EIGHT_Menschen = addValue(new Card(Value.Acht, Suit.Menschen, 1));
        /** */
        public static Card NINE_Menschen = addValue(new Card(Value.Neun, Suit.Menschen, 1));
        /** */
        public static Card TEN_Menschen = addValue(new Card(Value.Zehn, Suit.Menschen, 1));
        /** */
        public static Card JACK_Menschen = addValue(new Card(Value.Elf, Suit.Menschen, 1));
        /** */
        public static Card QUEEN_Menschen = addValue(new Card(Value.Zwölf, Suit.Menschen, 1));
        /** */
        public static Card KING_Menschen = addValue(new Card(Value.Dreizehn, Suit.Menschen, 1));
        /** */
        public static Card One_Menschen = addValue(new Card(Value.Eins, Suit.Menschen, 1));


        /** */
        public static Card TWO_Zwerge = addValue(new Card(Value.Zwei, Suit.Zwerge, 3));
        /** */
        public static Card THREE_Zwerge = addValue(new Card(Value.Drei, Suit.Zwerge, 3));
        /** */
        public static Card FOUR_Zwerge = addValue(new Card(Value.Vier, Suit.Zwerge, 3));
        /** */
        public static Card FIVE_Zwerge = addValue(new Card(Value.Fünf, Suit.Zwerge, 3));
        /** */
        public static Card SIX_Zwerge = addValue(new Card(Value.Sechs, Suit.Zwerge, 3));
        /** */
        public static Card SEVEN_Zwerge = addValue(new Card(Value.Sieben, Suit.Zwerge, 3));
        /** */
        public static Card EIGHT_Zwerge = addValue(new Card(Value.Acht, Suit.Zwerge, 3));
        /** */
        public static Card NINE_Zwerge = addValue(new Card(Value.Neun, Suit.Zwerge, 3));
        /** */
        public static Card TEN_Zwerge = addValue(new Card(Value.Zehn, Suit.Zwerge, 3));
        /** */
        public static Card JACK_Zwerge = addValue(new Card(Value.Elf, Suit.Zwerge, 3));
        /** */
        public static Card QUEEN_Zwerge = addValue(new Card(Value.Zwölf, Suit.Zwerge, 3));
        /** */
        public static Card KING_Zwerge = addValue(new Card(Value.Dreizehn, Suit.Zwerge, 3));
        /** */
        public static Card One_Zwerge = addValue(new Card(Value.Eins, Suit.Zwerge, 3));


        public static Card TWO_Elfen = addValue(new Card(Value.Zwei, Suit.Elfen, 3));
        /** */
        public static Card THREE_Elfen = addValue(new Card(Value.Drei, Suit.Elfen, 3));
        /** */
        public static Card FOUR_Elfen = addValue(new Card(Value.Vier, Suit.Elfen, 3));
        /** */
        public static Card FIVE_Elfen = addValue(new Card(Value.Fünf, Suit.Elfen, 3));
        /** */
        public static Card SIX_Elfen = addValue(new Card(Value.Sechs, Suit.Elfen, 3));
        /** */
        public static Card SEVEN_Elfen = addValue(new Card(Value.Sieben, Suit.Elfen, 3));
        /** */
        public static Card EIGHT_Elfen = addValue(new Card(Value.Acht, Suit.Elfen, 3));
        /** */
        public static Card NINE_Elfen = addValue(new Card(Value.Neun, Suit.Elfen, 3));
        /** */
        public static Card TEN_Elfen = addValue(new Card(Value.Zehn, Suit.Elfen, 3));
        /** */
        public static Card JACK_Elfen = addValue(new Card(Value.Elf, Suit.Elfen, 3));
        /** */
        public static Card QUEEN_Elfen = addValue(new Card(Value.Zwölf, Suit.Elfen, 3));
        /** */
        public static Card KING_Elfen = addValue(new Card(Value.Dreizehn, Suit.Elfen, 3));
        /** */
        public static Card One_Elfen = addValue(new Card(Value.Eins, Suit.Elfen, 3));


        public static Card TWO_Riesen = addValue(new Card(Value.Zwei, Suit.Riesen, 3));
        /** */
        public static Card THREE_Riesen = addValue(new Card(Value.Drei, Suit.Riesen, 3));
        /** */
        public static Card FOUR_Riesen = addValue(new Card(Value.Vier, Suit.Riesen, 3));
        /** */
        public static Card FIVE_Riesen = addValue(new Card(Value.Fünf, Suit.Riesen, 3));
        /** */
        public static Card SIX_Riesen = addValue(new Card(Value.Sechs, Suit.Riesen, 3));
        /** */
        public static Card SEVEN_Riesen = addValue(new Card(Value.Sieben, Suit.Riesen, 3));
        /** */
        public static Card EIGHT_Riesen = addValue(new Card(Value.Acht, Suit.Riesen, 3));
        /** */
        public static Card NINE_Riesen = addValue(new Card(Value.Neun, Suit.Riesen, 3));
        /** */
        public static Card TEN_Riesen = addValue(new Card(Value.Zehn, Suit.Riesen, 3));
        /** */
        public static Card JACK_Riesen = addValue(new Card(Value.Elf, Suit.Riesen, 3));
        /** */
        public static Card QUEEN_Riesen = addValue(new Card(Value.Zwölf, Suit.Riesen, 3));
        /** */
        public static Card KING_Riesen = addValue(new Card(Value.Dreizehn, Suit.Riesen, 3));
        /** */
        public static Card One_Riesen = addValue(new Card(Value.Eins, Suit.Riesen, 3));



    }
}
