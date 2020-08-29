using System;
using System.Collections.Generic;
using WizardBib.Core;
using WizardBib.Player;
using WizardBib.PlayerOrdner;

namespace PlayWizardWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerNumber = 0;
            List<Player> mitSpieler = new List<Player>();

            Deck deck = new Deck(new WizardCardFinder());
            deck.shuffle();
            CardCounter cardCounter = new CardCounter();

            //Wahrscheinlichkeiten beim Austeilen
            AverageHand averageHand = new AverageHand();


            //shuffled deck = list of cards
            foreach (var item in deck.shuffledDeck)
            {
                //alle Kartenwerte
                Console.WriteLine(item.suit.Description + ":" + item.value.Index);
            }
            Console.ReadLine();

            playerNumber = SpielerWerdenErstellt(playerNumber, mitSpieler);


            //10 Rounds Beispiel
            for (int i = 1; i < 10; i++)
            {
                //Wahrscheinlichkeiten pro Runde
                averageHand.setRound(i);
                cardCounter.init(mitSpieler.Count, i);

                //jeder Spieler ist 1x an der Reihe
                foreach (var item in mitSpieler)
                {
                    //Jeder Spieler bekommt Karten pro Runde
                }
            }
        }

        private static int SpielerWerdenErstellt(int playerNumber, List<Player> mitSpieler)
        {
            bool neuerSpieler = true;

            while (neuerSpieler)
            {
                Console.WriteLine("Willst du einen neuen Spieler erstellen? Drücke j, zum Abbrechen drücke n");
                string mykey = Console.ReadLine().ToString().ToLower();

                if (mykey == "j")
                {
                    bool newPlayer = true;
                    if (newPlayer)
                    {
                        Console.WriteLine("Wie soll der Spieler heißen?");
                        playerNumber++;
                        string playerName = Console.ReadLine().ToString();
                        Player player = createPlayer(playerNumber, playerName);
                        mitSpieler.Add(player);

                        Console.WriteLine("Willst du noch einen Spieler erstellen? J, anderer Buchstabe zum Abbrechen");
                        string myplayer = Console.ReadLine().ToString().ToLower();

                        if (myplayer == "j")
                        {
                            playerNumber++;
                            Console.WriteLine("Wie soll der Spieler heißen?");
                            playerName = Console.ReadLine().ToString();
                            player = createPlayer(playerNumber, playerName);
                            mitSpieler.Add(player);
                        }
                        else
                        {
                            newPlayer = false;
                            break;
                        }
                    }
                }
                else if (mykey == "n")
                {
                    neuerSpieler = false;
                }
            }

            Console.WriteLine("Fassen wir mal zusammen.... Es spielen mit: ");
            foreach (var item in mitSpieler)
            {
                Console.WriteLine(item.playerNameinGame);
            }
            Console.ReadLine();
            return playerNumber;
        }

        private static Player createPlayer(int playerNumber, string playerName)
        {
            Player player = new Player(playerNumber, playerName);
            Console.WriteLine("Sauber! Dein neuer Spieler heißt: {0} ", playerName);
            return player;
        }
    }
}
