using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Crossword_puzzle
{
    static class Crossword
    {
        static public int H;
        static public int W;
        static public Tile[,] _Game_field;
        static public List<Word> SelectedWord = new List<Word>();



        public static void CreateGameField(int h, int w)
        {
            H = h;
            W = w;
            _Game_field = new Tile[h, w];

        }

        public static void CreateWords()
        {
            foreach (Tile tile in _Game_field)
            {
                if (tile.Usage == true && tile.Letter.Text != "#")
                {
                    SelectedWord.Add(new Word(tile));
                }
            }

            //SelectedWord.Sort();

            foreach (Word word in SelectedWord)
            {
                string a = word.ToString();
                char[] new_word = Dictionary.FindWord(a).ToCharArray();
                for (int i = 0; i < new_word.Length; i++)
                {
                    word.WordTiles[i].Letter.Text = new_word[i].ToString();
                    Label word_label = new Label();
                    word_label.Location = new Point(5, 5);
                    word_label.Text = new_word[i].ToString();
                    word_label.Font = new Font("Rocketfont", 10);
                    word_label.BackColor = Color.Transparent;
                    word_label.ForeColor = Color.White;
                    word_label.BringToFront();
                    word.WordTiles[i].Controls.Add(word_label);
                    word_label.Show();
                }
                System.Console.WriteLine(word.ToString());

                Label numb = new Label();
                numb.BackColor = Color.Transparent;
                numb.Font = new Font("Rockwell", 6);
                numb.ForeColor = Color.White;
#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
                numb.Text = word.WordTiles[0].Word_number.ToString();
#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
                word.WordTiles[0].Controls.Add(numb);

            }
        }

    }
}