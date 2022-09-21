namespace Evolution;

public struct Brain
{
    Genome Genome { get; set; }

    public Brain()
    {
        Genome = new Genome();
    }
}
