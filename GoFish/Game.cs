using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Game
    {
        private string Name;
        private List<string> lists;
        private TextBox textProgress;

        public Game(string text, List<string> lists, TextBox textProgress)
        {
            this.Name = text;
            this.lists = lists;
            this.textProgress = textProgress;
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

        internal bool PlayOneRound(int selectedIndex)
        {
            throw new NotImplementedException();
        }

        internal string GetWinnerName()
        {
            throw new NotImplementedException();
        }
    }
}
