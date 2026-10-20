namespace Cafeteria
{
    internal static class Program
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