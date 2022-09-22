namespace Evolution;

public class Life
{
    private Point _position;
    private Genome _genome;
    private Brain _brain;
    

    public Life(int genomeLength)
    {
        _genome = new Genome(genomeLength);
        _position = Point.Empty;
        _brain = new Brain(_genome);
    }
}
