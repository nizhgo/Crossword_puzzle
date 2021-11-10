using System;
using System.Linq;
using System.Windows.Forms;

namespace Crossword_puzzle
{
    public partial class SetSizeWindow : Form
    {
        public SetSizeWindow()
        {
            InitializeComponent();
            OnlyDigitInput();                                           // вызвает функцию, позовляющие вводить в текстбоксы только цифры
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")             // проверяем введено ли хоть что-то в текстбоксы
            {
                int h = int.Parse(textBox1.Text);
                int w = int.Parse(textBox2.Text);
                if (h != 0 && w != 0)
                {
                    Crossword.CreateGameField(h, w);                    //вызываем функцию статического класса, создающую игрвое поле
                    Form Set_the_cells = new Set_the_cells_Window();    // вызываем и показываем форму следующего этапа
                    Set_the_cells.Show();
                    this.Hide();                                        // эту форму скрываем
                }
                else
                    MessageBox.Show("Размер не может быть нулевым!");
            }
            else
                MessageBox.Show("Вы не ввели размер поля!");
        }


        private void OnlyDigitInput()                                   // функция, позволяет писать в текстбокс только цифры
        {
            foreach (TextBox textbox in panel2.Controls.OfType<TextBox>())   // для каждого тексбокса на панели
                textbox.KeyPress += (s, e) =>                           //если что-то введено (нажата кнопка)
                {
                    char number = e.KeyChar;                            // записываем этот символ в переменную

                    if (!Char.IsDigit(number) && number != 8)           // если не цифра и не бэкспейс (удаление)
                        e.Handled = true;                               // отменяем действие (ввод символа)

                };
        }
    }
}
