using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverrloadingCards
{
    class Deck
    {
        Random random = new Random();
        public List<Cards> deck = new List<Cards>();

        private int numberOfCard;
        public int NumberOfCard
        {
            get
            {
                return numberOfCard;
            }
            set
            {
                numberOfCard = value;

                if (value > 52)
                {
                    numberOfCard = 52;
                }

                SetACards(NumberOfCard);
            }
        }

        public Deck(int numberOfCards)
        {
            NumberOfCard = numberOfCards;
        }

        private void SetACards(int numberOfCard)
        {
            if (numberOfCard == 52)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        deck.Add(new Cards { Suit = (Suits)i, Value = (Values)j });
                    }
                }
            }
            else
            {
                for (int i = 1; i <= numberOfCard; i++)
                {
                    deck.Add(new Cards { Suit = (Suits)(random.Next(1, 4)), Value = (Values)(random.Next(1, 13)) });
                }
            }

        }

        public override string ToString()
        {
            return $"Deck has {NumberOfCard} cards.";
        }

        public void Sort()
        {
            deck.Sort();
        }


        public void Move(Deck deckToMove, int indexToMove)
        {
            MessageBox.Show(indexToMove.ToString());
            deckToMove.deck.Add(this.deck[indexToMove]);
            this.deck.RemoveAt(indexToMove);
        }
    }
}
