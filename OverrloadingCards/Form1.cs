using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverrloadingCards
{
    public partial class Form1 : Form
    {
        Deck deck1, deck2;
        public Form1()
        {
            InitializeComponent();
            AddDecks();

            deck2.Sort();



        }

        private void MoveToDeckBox2_Click(object sender, EventArgs e)
        {
            deck1.Move(deck2, deckBox1.SelectedIndex);

        }

        private void MoveToDeckBox1_Click(object sender, EventArgs e)
        {
           deck2.Move(deck1, deckBox2.SelectedIndex);           
        }

        private void ResetBox1_Click(object sender, EventArgs e)
        {

        }

        private void MixDeck1_Click(object sender, EventArgs e)
        {

        }

        private void ResetBox2_Click(object sender, EventArgs e)
        {

        }

        private void MixDeck2_Click(object sender, EventArgs e)
        {

        }

        private void DeckBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"{}");
        }

        private void AddDecks()
        {
            deck1 = new Deck(100);
            deck2 = new Deck(10);

            deckBox1.Items.Clear();
            deckBox1.Items.Add(deck1.deck[0]);
            deckBox1.Items.Add(deck1.deck[1]);
            deckBox1.Items.Add(deck1.deck[2]);



        }
    }
}
