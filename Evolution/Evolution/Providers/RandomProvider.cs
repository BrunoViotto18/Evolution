namespace Evolution.Providers;

internal static class RandomProvider
{
    public static Random Rng { get; private set; } = new Random();

    public static void SetSeed(int seed)
    {
        Rng = new Random(seed);
    }
}
