using System;
using System.IO;

namespace My_Games
{
    static class Settings
    {
        const string fileName = "My Games.ini";
        public static int left = 100;
        public static int top = 100;
        public static int width = 800;
        public static int height = 600;
        public static bool infoPanel = false;
        public static int colorMode = 0;

        /// <summary>
        /// Инициализация настроек
        /// </summary>
        public static void Init()
        {
            try
            {
                StreamReader file = File.OpenText(fileName);
                while (!file.EndOfStream)
                {
                    string[] s = file.ReadLine().Split('=');
                    if (s[0] == "Left") left = Convert.ToInt32(s[1]);
                    if (s[0] == "Top") top = Convert.ToInt32(s[1]);
                    if (s[0] == "Width") width = Convert.ToInt32(s[1]);
                    if (s[0] == "Height") height = Convert.ToInt32(s[1]);
                    if (s[0] == "InfoPanel") infoPanel = s[1] == "True";
                    if (s[0] == "ColorMode") colorMode = Convert.ToInt32(s[1]);
                }
            }
            catch { }
        }

        /// <summary>
        /// Сохранение настроек в файл
        /// </summary>
        public static void Save()
        {
            try
            {
                using (StreamWriter file = File.CreateText(fileName))
                {
                    file.WriteLine("Left=" + left.ToString());
                    file.WriteLine("Top=" + top.ToString());
                    file.WriteLine("Width=" + width.ToString());
                    file.WriteLine("Height=" + height.ToString());
                    file.WriteLine("InfoPanel=" + infoPanel.ToString());
                    file.WriteLine("ColorMode=" + colorMode.ToString());
                }
            }
            catch { }
        }
    }
}
