namespace Evolution;

using Providers;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        RandomProvider.SetSeed(27);
        ApplicationConfiguration.Initialize();
        Application.Run(new Evolution());
    }
}