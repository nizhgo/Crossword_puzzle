using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Crossword_puzzle
{
    public partial class Set_the_cells_Window : Form
    {
        public Set_the_cells_Window()
        {
            InitializeComponent();
            GirdControl();
        }


        async private void GirdControl()
        {
            //region  Создает и отрисовывает поле кросворда, контролирует нажатия на ячейки

            Tile panelGird = new Tile();
            panelGird.AutoSize = true;
            panelGird.Size = new Size(Crossword.Field_size[0], Crossword.Field_size[1]);
            panelGird.Padding = new Padding(0, 0, 85, 85);
            panelGird.Location = new Point(85, 197);
            await Task.Run(() =>
            {
                for (var n = 0; n < Crossword.Field_size[0]; n++)
                {
                    for (var m = 0; m < Crossword.Field_size[1]; m++)
                    {
                        Tile newTile = new Tile
                        {
                            Size = new Size(30, 30),
                            Location = new Point(30 * n, 30 * m),
                            Position = new Point(n, m)
                        };
                        Crossword._Game_field[n, m] = newTile;
                        newTile.MouseClick += ClickControl;
                        panelGird.Controls.Add(Crossword._Game_field[n, m]);
                        newTile.BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            });
            Controls.Add(panelGird);
            // контролирует клики по полю кросворда
            //#endregion
        }


        public void ClickControl(object sender, MouseEventArgs e)
        {
            Tile tile = (Tile)sender;
            tile.Click();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}