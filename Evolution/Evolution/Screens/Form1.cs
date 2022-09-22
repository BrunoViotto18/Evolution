namespace Evolution.Screens;

public partial class Evolution : Form
{
    public Evolution()
    {
        InitializeComponent();

        Load += delegate
        {
            var g = new Genome(4);
            g.GenerateRandomGenes();
            MessageBox.Show($"{g}\n{(byte)129 & 0b10000000}");
        };
    }
}
