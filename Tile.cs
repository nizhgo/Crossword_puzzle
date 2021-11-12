using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Crossword_puzzle
{
    public class Tile : Panel // мой сапописный класс, наследуемый от Panel
    {
        public Point Position { get; set; }  // расположение ячейки на всем кроссворде
        public bool Usage = false; //активна ли ячейка (выбрана ли пользователем)
        public bool Begining_status = false; //яляется ли ячейка начальной для слова
        public int Word_number = new int(); //номер слова 
        //public char Letter = new char(); //буква на плитке
        public Label Letter = new Label();

        public Tile(Size size, Point location, Point position)  // конструктор класса 
        {
            Size = size;
            Location = location;
            Position = position;
        }

        public Tile() // еще один контруктор, но пустой
        {
        }

        public new void Click()      //дейтсвия по клику на плитку
        {
            if (Usage == true) // если активна - деактивируем
            {
                Usage = false;
                this.BackColor = Color.Black;
            }
            else                 //если неактивна — активируем
            {
                this.BackColor = Color.LightSlateGray;
                Usage = true;
            }
        }


    }
}
