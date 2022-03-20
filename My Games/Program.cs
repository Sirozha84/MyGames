namespace My_Games
{
    internal static class Program
    {
        public static string version = "3.0 (14.03.2022)";
        public static string num = "### ### ##0";
        public static float scale = 1;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}