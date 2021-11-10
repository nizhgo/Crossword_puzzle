using System;
using System.Windows.Forms;

namespace Crossword_puzzle
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form SetSizeWindow = new SetSizeWindow();
            Application.Run(SetSizeWindow);
        }
    }
}
