using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossword_puzzle
{
    public class Tile
    {
        public bool usage = false;
        public bool begining_status = false;
        public int word_number = new int();
        public char letter = new char();
        public Panel letter_panel;

        public Tile(Panel letter_panel)
        {
            this.letter_panel = letter_panel;
        }

        public void Click()
        {
            if (usage == true)
            {
                usage = false;
                letter_panel.BackColor = Color.Black;
            }
            else
            {
                letter_panel.BackColor = Color.RoyalBlue;
                usage = true;
            }
        }

        public Panel GetPanel()
        {
            return letter_panel;
        }
    }
}
