using System.Text;

namespace Evolution;

using Providers;

// (0)                (0000000)      (0)                     (0000000)           (00000000 00000000)
// SourceNeuronType - SourceNeuron - DestinationNeuronType - DestinationNeuron - ConnectionWeight
public class Genome
{
    private const string HexadecimalCharacters = "0123456789ABCDEF";
    private readonly char[] _genes;
    private static char RandomHexadecimalCharacter => HexadecimalCharacters[RandomProvider.Rng.Next(0, HexadecimalCharacters.Length)];
    public bool SourceNeuronType => ((byte)_genes[0] & 0b10000000) != 0;
    
    
    public Genome(int genomeLength)
    {
        _genes = new char[genomeLength * 8];
        GenerateRandomGenes();
    }

    
    public void GenerateRandomGenes()
    {
        for (var i = 0; i < _genes.Length; i++)
            _genes[i] = RandomHexadecimalCharacter;
    }
    
    public void Mutate(int mutationChance)
    {
        for (var i = 0; i < _genes.Length; i++)
            if (RandomProvider.Rng.Next(0, 10000) < mutationChance * 100)
                _genes[i] = RandomHexadecimalCharacter;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        for (var i = 0; i < _genes.Length / 8; i++)
        {
            builder.Append(_genes[i..(i + 8)]);
            builder.Append(' ');
        }

        return builder.ToString();
    }
}
