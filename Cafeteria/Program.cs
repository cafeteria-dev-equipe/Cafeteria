namespace Cafeteria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            [STAThread]
            static void Main()
            {
                ApplicationConfiguration.Initialize();

                using (FormSplash splash = new FormSplash())
                {
                    splash.ShowDialog();
                }

                Application.Run(new FormMenu());
            }
        }
    }
}