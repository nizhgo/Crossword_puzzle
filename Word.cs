using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Crossword_puzzle
{
    public class Word : IComparer<Word>
    {
        public List<Tile> WordTiles = new List<Tile>();
        public Word(Tile FirstTile)
        {
            FirstTile.Begining_status = true;
            FirstTile.Word_number =  Crossword.SelectedWord.Count + 1;
            GetFullWord(ref FirstTile);
        }


        public int Compare(Word x, Word y)
        {
            if (x.WordTiles.Count > y.WordTiles.Count)
                return 1;
            else if (x.WordTiles.Count < y.WordTiles.Count)
                return -1;
            else
                return 0;
        }


        public new string ToString()
        {
            string a = "";
            foreach (Tile t in WordTiles)
                a += t.Letter.Text;
            return a;
        }

        public void GetFullWord(ref Tile tile)
        {
            int x = tile.Position.X;
            int y = tile.Position.Y;
            tile.Letter.Text = "#";
            WordTiles.Add(tile);
            if (x + 1 != Crossword.H && Crossword._Game_field[x + 1, y].Usage == true)
            {
                Crossword._Game_field[x + 1, y].Letter.Text = "#";
                WordTiles.Add(Crossword._Game_field[x + 1, y]);
                //Crossword._Game_field[x + 1, y].Letter.Text = "#";
                tile.Letter.Text = "#";
                int i = 2;
                while (true)
                {   
                    if (x + i < Crossword.H)
                    {
                        var a = Crossword._Game_field[x + i, y];
                        if (a.Usage == true)
                        {
                            a.Letter.Text = "#";
                            WordTiles.Add(a);  
                        }
                        else break;
                        i++;
                    }
                    else break;
                }
            }

            else if (y + 1 != Crossword.H && Crossword._Game_field[x, y + 1].Usage == true)
            {
                Crossword._Game_field[x, y + 1].Letter.Text = "#";
                WordTiles.Add(Crossword._Game_field[x, y + 1]);
                //Crossword._Game_field[x, y + 1].Letter.Text = "#";
                int i = 2;
                while (true)
                {
                    if ((y + i != Crossword.W))
                    {
                        var a = Crossword._Game_field[x, y + i];
                        if (a.Usage == true)
                        {
                            a.Letter.Text = "#";
                            WordTiles.Add(a);
                        }
                        else break;
                        i++;
                    }
                    else break;

                }
            }

            else
            {
                MessageBox.Show("Ошибка!", "неправильный шаблон кросворда");
            }               
        }
    }
}
