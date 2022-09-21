namespace Evolution;

public partial class Evolution : Form
{
    public Evolution()
    {
        InitializeComponent();

        Load += delegate
        {
            Genome g = new Genome(4);
            g.GenerateRandomGenes();
            MessageBox.Show($"{g}");
        };
    }
}
