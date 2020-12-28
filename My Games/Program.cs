using System;
using System.Windows.Forms;

namespace My_Games
{
    static class Program
    {
        public const string version = "2.3 (01.12.2020)";
        public const string num = "### ### ##0";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
