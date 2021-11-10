using System.Windows.Forms;

namespace Crossword_puzzle
{
    static class Crossword
    {
        static public int[] Field_size = new int[2];
        static public Tile[,] _Game_field;



        public static void CreateGameField(int h, int w)
        {
            Field_size[0] = h;
            Field_size[1] = w;
            _Game_field = new Tile[h, w];

        }

    }
}