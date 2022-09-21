namespace Evolution;

using Providers;
using System.Text;

public struct Genome
{
    private static readonly string _letters = "0123456789ABCDEF";
    char[] genes { get; set; }

    public Genome(int genomeLength)
        => genes = new char[genomeLength * 8];

    public void GenerateRandomGenes()
    {
        for (int i = 0; i < genes.Length / 8; i++)
            for (int j = 0; j < 8; j++)
                genes[i * 8 + j] = _letters[RandomProvider.Rng.Next(0, _letters.Length)];
    }

    public void Mutate(int mutationChance)
    {
        for (int i = 0; i < genes.Length / 8; i++)
            for (int j = 0; j < 8; j++)
                if (RandomProvider.Rng.Next(0, 10000) < mutationChance * 100)
                    genes[i * 8 + j] = _letters[RandomProvider.Rng.Next(0, _letters.Length)];
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        for (int i = 0; i < genes.Length / 8; i++)
        {
            builder.Append(genes[i..(i + 8)]);
            builder.Append(' ');
        }

        return builder.ToString();
    }
}
