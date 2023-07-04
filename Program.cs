namespace B23_Ex05_Daniel_208063362_Lior_207899469
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
            //Application.Run(new Form1());
            Application.Run(new TicTacToeMisere(5,5, "player1", "player2", 0));
        }
    }
}