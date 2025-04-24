namespace PotionMasterNew
{
    public partial class MainForm : Form
    {
        public List<VialControl> Vials = new List<VialControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildVialGrid(int vialCount, int maxSegments)
        {
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            Vials.Clear();

            int numberOfColumns = Math.Min(7, vialCount);
            int numberOfRows = (vialCount % 7 == 0) ? vialCount / 7 : vialCount / 7 + 1;
            tableLayoutPanel.ColumnCount = numberOfColumns;
            tableLayoutPanel.RowCount = numberOfRows;

            for (int i = 0; i < numberOfColumns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
            }
            for (int i = 0; i < numberOfRows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / numberOfRows));
            }

            for (int i = 0; i < vialCount; i++)
            {
                VialControl newVial = new VialControl();
                newVial.Anchor = AnchorStyles.None;
                newVial.Size = new Size(61, 180);
                newVial.MaxSegments = maxSegments;

                int row = i / numberOfColumns;
                int col = i % numberOfColumns;
                tableLayoutPanel.Controls.Add(newVial, col, row);
                Vials.Add(newVial);
            }

            tableLayoutPanel.ResumeLayout();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int vialCount = 16;
            int maxSegments = 4;
            BuildVialGrid(vialCount, maxSegments);
            
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
            for (int i = 0; i <= 4; i++)
            {
                int index = random.Next(0, possibleColors.Count);
                activeRandomColors.Add(possibleColors[index]);
                possibleColors.RemoveAt(index);
            }

            foreach (VialControl vial in Vials)
            {
                vial.MaxSegments = 5;
            }

            for (int i = 1; i <= vialCount * 3; i++)
            {
                int numberOfVial = random.Next(0, Vials.Count);
                int numberOfColor = random.Next(0, activeRandomColors.Count);
                
                if (Vials[numberOfVial].Segments.Count < Vials[numberOfVial].MaxSegments)
                {
                    Vials[numberOfVial].Segments.Add(activeRandomColors[numberOfColor]);
                }
            }
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            foreach (VialControl vial in Vials)
            {
                vial.Invalidate();
            }

            Invalidate();
        }
    }
}
