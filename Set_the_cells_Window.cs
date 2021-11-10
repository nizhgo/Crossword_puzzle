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
            GirdPaint();
        }


        async private void GirdPaint()
        {
            Panel panelGird = new Panel();
            panelGird.AutoSize = true;
            panelGird.Padding = new System.Windows.Forms.Padding(0, 0, 85, 85);
            panelGird.Location = new Point(85, 197);
            await Task.Run(() =>
            {
                for (var n = 0; n < Crossword.Field_size[0]; n++)
                {
                    for (var m = 0; m < Crossword.Field_size[1]; m++)
                    {
                        Panel newPanel = new Panel
                        {
                            Size = new Size(40, 40),
                            Location = new Point(40 * n, 40 * m)
                        };

                        panelGird.Controls.Add(newPanel);
                        newPanel.BackColor = Color.Black;
                        newPanel.BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            });
            this.Controls.Add(panelGird);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //this.Size = new Size(150 + Crossword.Field_size[0] * 50, 150 + Crossword.Field_size[1] * 50);
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Set_the_cells_Window_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}