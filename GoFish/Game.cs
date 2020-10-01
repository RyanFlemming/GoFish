using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoFish
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
            {
                players.Add(new Player(player, random, textBoxOnForm));
            }
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                foreach (Player player in players)
                {
                    player.TakeCard(stock.Deal());
                }
                foreach (Player player in players)
                {
                    PullOutBooks(player);
                }
            }
        }

        public bool PullOutBooks(Player player)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<string> GetPlayerCardNames()
        {
            throw new NotImplementedException();
        }

        internal string DescribeBooks()
        {
            throw new NotImplementedException();
        }

        internal string DescribePlayerHands()
        {
            throw new NotImplementedException();
        }

        internal bool PlayOneRound(int selectedPlayerCard)
        {
            Values cardsToAskFor = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                {
                    players[0].AskForACard(players, 0, stock, cardsToAskFor);
                }
                else
                {
                    players[i].AskForACard(players, i, stock);
                }
                if (PullOutBooks(players[i]))
                {
                    textBoxOnForm.Text += players[i].Name
                        + " drew a new hand" + Environment.NewLine;

                    for (int j = 0; j < 5; j++)
                    {
                        players[i].TakeCard(stock.Deal());
                    }
                }
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    textBoxOnForm.Text = "The stock is out of cards. Game over!" + Environment.NewLine;
                    return true;
                }
            }
            return false;
        }

        internal string GetWinnerName()
        {
            throw new NotImplementedException();
        }
    }
}
