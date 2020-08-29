using System;
using System.Drawing;


//scheint komplett (Welche Kartenart + Farbe)
namespace WizardBib
{
    public class Suit
    {
        public int Index { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }
        public Color Color { get; set; }

        public static readonly Suit Menschen = new Suit(0, "M", "Menschen", "human", Color.Blue);
        public static readonly Suit Zwerge = new Suit(1, "Z", "Zwerge", "Zwerge", Color.Red);
        public static readonly Suit Elfen = new Suit(2, "E", "Elfen", "Elfen", Color.Green);
        public static readonly Suit Riesen = new Suit(3, "R", "Riesen", "Riesen", Color.Yellow);
        public static readonly Suit Andere = new Suit(4, "A", "Andere", "A´ndere", Color.White);

        private Suit(int index, string shortName, string description, string symbol, Color color)
        {
            Index = index;
            ShortName = shortName;
            Description = description;
            Symbol = symbol;
            Color = color;
        }

        public static Suit findSuitByShortName(string shortName)
        {
            if (shortName.Equals(Suit.Menschen.ShortName, StringComparison.InvariantCultureIgnoreCase))
            {
                return Suit.Menschen;
            }
            else if (shortName.Equals(Suit.Zwerge.ShortName, StringComparison.InvariantCultureIgnoreCase))
            {
                return Suit.Zwerge;
            }
            else if (shortName.Equals(Suit.Elfen.ShortName, StringComparison.InvariantCultureIgnoreCase))
            {
                return Suit.Elfen;
            }
            else if (shortName.Equals(Suit.Riesen.ShortName, StringComparison.InvariantCultureIgnoreCase))
            {
                return Suit.Riesen;
            }
            else if (shortName.Equals(Suit.Andere.ShortName, StringComparison.InvariantCultureIgnoreCase))
            {
                return Suit.Andere;
            }
            else
            {
                throw new Exception("Suit with shortName " + shortName + " not found.");
            }

        }

        public static Suit findSuitByIndex(int index)
        {
            if (index == Suit.Menschen.Index)
            {
                return Suit.Menschen;
            }
            else if (index == Suit.Zwerge.Index)
            {
                return Suit.Zwerge;
            }
            else if (index == Suit.Elfen.Index)
            {
                return Suit.Elfen;
            }
            else if (index == Suit.Riesen.Index)
            {
                return Suit.Riesen;
            }
            else if (index == Suit.Andere.Index)
            {
                return Suit.Andere;
            }
            else
            {
                throw new Exception("Suit with Index " + index + " not found.");
            }
        }

    }
}