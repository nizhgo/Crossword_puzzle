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
            GirdCreator();
        }


        async private void GirdCreator()
        {
            #region  Создает и отрисовывает поле кросворда, контролирует нажатия на ячейки

            Panel panelGird = new Panel();
            panelGird.AutoSize = true; // делаем размер панели динамической
            panelGird.Padding = new Padding(0, 0, 85, 85); //отсупы справа и снизу для красоты
            panelGird.Location = new Point(85, 197);        //начальная позиция на всей форме
            await Task.Run(() =>                                    // запускаем асинхронно, чтобы не сильно зависала форма
            {
                for (var n = 0; n < Crossword.H; n++)
                {
                    for (var m = 0; m < Crossword.W; m++)
                    {
                        Tile newTile = new Tile                 //создаем плитку кросворда
                        {
                            Size = new Size(30, 30),
                            Location = new Point(30 * n, 30 * m),
                            Position = new Point(n, m)          // позиция в кросворде

                        };
                        /*Label textBox = new Label();
                        textBox.Text = "T";
                        textBox.ForeColor = Color.White;
                        textBox.Location = new Point(4, 4);
                        newTile.Controls.Add(textBox);
                        */
                        Crossword._Game_field[n, m] = newTile;
                        newTile.MouseClick += ClickControl;                     //контролирует клики по ячейкам
                        panelGird.Controls.Add(Crossword._Game_field[n, m]);
                        newTile.BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            });
            Controls.Add(panelGird);        //добавляем в контрол для отображения на форме
            #endregion
        }


        public void ClickControl(object sender, MouseEventArgs e)    //обрабатывает клик по ячейке и активирует метод Click
        {
            Tile tile = (Tile)sender;
            tile.Click();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crossword.CreateWords();
        }

        public void AnalyzeGird()
        {
        }

    }
}