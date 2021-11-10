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
        public bool usage = false; //активна ли ячейка (выбрана ли пользователем)
        public bool begining_status = false; //яляется ли ячейка начальной для слова
        public int word_number = new int(); //номер слова 
        public char letter = new char(); //буква на плитке
        public Panel letter_panel; //плитка, пенадлежащая ячейке
        public Point point = new Point(); //координаты плитки

        public Tile(Panel letter_panel, int x, int y)
        {
            this.letter_panel = letter_panel;
            point.X = x;
            point.Y = y;
        }

        public void Click()      //дейтсвия по клику на плитку
        {
            if (usage == true)
            {
                usage = false;
                letter_panel.BackColor = Color.Black;
            }
            else                 //если неактивна — активируем
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
