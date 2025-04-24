namespace PotionMasterNew
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Color> possibleColors = new List<Color>();
            possibleColors.Add(Color.Red);
            possibleColors.Add(Color.Green);
            possibleColors.Add(Color.Blue);
            possibleColors.Add(Color.Orange);
            possibleColors.Add(Color.Yellow);
            possibleColors.Add(Color.Purple);
            possibleColors.Add(Color.Black);

            List<Color> activeRandomColors = new List<Color>();
            Random random = new Random();
            for (int i = 0; i <= 2; i++)
            {
                int index = random.Next(0, possibleColors.Count);
                activeRandomColors.Add(possibleColors[index]);
                possibleColors.RemoveAt(index);
            }

            

            for (int i = 1; i <= 9; i++)
            {
                int numberOfVial = random.Next(1, 5);
                int numberOfColor = random.Next(0, activeRandomColors.Count);
                switch (numberOfVial)
                {
                    case 1:
                        if (vialControl1.Segments.Count < vialControl1.MaxSegments)
                            vialControl1.Segments.Add(activeRandomColors[numberOfColor]);
                        break;
                    case 2:
                        if (vialControl2.Segments.Count < vialControl2.MaxSegments)
                            vialControl2.Segments.Add(activeRandomColors[numberOfColor]);
                        break;
                    case 3:
                        if (vialControl3.Segments.Count < vialControl3.MaxSegments)
                            vialControl3.Segments.Add(activeRandomColors[numberOfColor]);
                        break;
                    case 4:
                        if (vialControl4.Segments.Count < vialControl4.MaxSegments)
                            vialControl4.Segments.Add(activeRandomColors[numberOfColor]);
                        break;
                    default:
                        break;
                }
            }
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }
    }
}
