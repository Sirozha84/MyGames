using System;
using System.Windows.Forms;

namespace My_Games
{
    static class Program
    {
        public static string Version = "2.5 (13.04.2022)";
        public static string num = "### ### ##0";
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
