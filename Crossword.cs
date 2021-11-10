namespace Crossword_puzzle
{
    static class Crossword
    {
        static public int[] Field_size = new int[2];
        public static Tile[,] Game_field;



        public static void CreateGameField(int h, int w)
        {
            Field_size[0] = h;
            Field_size[1] = w;
            Game_field = new Tile[h, w];

        }

    }
}