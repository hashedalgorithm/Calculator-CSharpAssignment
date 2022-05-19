namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            MainScreen mainScreen = new MainScreen();
            mainScreen.BackColor = Color.FromArgb(33,32,31);

            Application.Run(mainScreen);
        }
    }
}