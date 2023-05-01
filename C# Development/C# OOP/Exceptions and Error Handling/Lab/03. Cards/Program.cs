using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Card> cards = new List<Card>();

            foreach (var card in input)
            {
                var cardInfo = card.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string face = cardInfo[0];
                string suit = cardInfo[1];

                try
                {
                    Card cardToUse = new Card(face, suit);
                    cards.Add(cardToUse);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(' ', cards));
        }
    }

    public class Card
    {
        private string face;
        private string suit;
        private readonly List<string> validFaces = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private readonly List<string> validSuits = new List<string> { "S", "H", "D", "C" };

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public string Face
        {
            get => this.face;
            set
            {
                if (!validFaces.Contains(value))
                    throw new ArgumentException("Invalid card!");
                this.face = value;
            }
        }

        public string Suit
        {
            get => this.suit;
            set
            {
                if (!validSuits.Contains(value))
                    throw new ArgumentException("Invalid card!");
                this.suit = value;
            }
        }

        private string GetUTFCode()
        {
            switch (this.Suit)
            {
                case "S": return "\u2660";
                case "H": return "\u2665";
                case "D": return "\u2666";
                case "C": return "\u2663";
                default: return string.Empty;
            }
        }

        public override string ToString() => $"[{this.Face}{this.GetUTFCode()}]";
    }
}