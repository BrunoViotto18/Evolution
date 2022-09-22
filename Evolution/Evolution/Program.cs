namespace Evolution;

using Providers;
using Screens;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Configurations();
        
        ApplicationConfiguration.Initialize();
        Application.Run(new Evolution());
    }

    private static void Configurations()
    {
        RandomProvider.SetSeed(27);
    }
}
