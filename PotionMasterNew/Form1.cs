using System.Collections.Specialized;

namespace PotionMasterNew
{
    public partial class MainForm : Form
    {
        public List<VialControl> Vials = new List<VialControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildVialGrid(decimal vialCount, decimal maxSegments)
        {
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            Vials.Clear();

            int numberOfColumns = Math.Min(7, (int)vialCount);
            int numberOfRows = ((int)vialCount % 7 == 0) ? (int)vialCount / 7 : (int)vialCount / 7 + 1;
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
                newVial.MaxSegments = (int)maxSegments;

                int row = i / numberOfColumns;
                int col = i % numberOfColumns;
                tableLayoutPanel.Controls.Add(newVial, col, row);
                Vials.Add(newVial);
            }

            tableLayoutPanel.ResumeLayout();
        }

        private List<Color> CreateColors()
        {
            List<Color> possibleColors = new List<Color>
            {
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Yellow,
                Color.Orange,
                Color.Purple,
                Color.Pink,
                Color.Brown,
                Color.Cyan,
                Color.Magenta,
                Color.Gold,
                Color.Silver,
                Color.Lime,
                Color.Indigo,
                Color.Violet,
                Color.Turquoise,
                Color.Coral,
                Color.Teal,
                Color.Aqua,
                Color.MediumSlateBlue,
                Color.DarkOrange,
                Color.SpringGreen,
                Color.Salmon,
                Color.MediumOrchid,
                Color.Chocolate,
                Color.RoyalBlue,
                Color.Olive,
                Color.Tomato,
                Color.DarkSeaGreen,
                Color.DeepPink
            };

            return possibleColors;
        }

        private List<Color> CreateListOfNRandomColors(int n, List<Color> possibleColors)
        {
            List<Color> activeRandomColors = new List<Color>();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int index = random.Next(0, possibleColors.Count);
                activeRandomColors.Add(possibleColors[index]);
                possibleColors.RemoveAt(index);
            }
            return activeRandomColors; 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BuildVialGrid(Properties.Settings.Default.VialsCount, Properties.Settings.Default.SegmentsCount);

            int numberOfColors = (int)Properties.Settings.Default.VialsCount - 3;
            if (Properties.Settings.Default.Difficulty == "Medium") numberOfColors++;
            else if (Properties.Settings.Default.Difficulty == "Hard") numberOfColors += 2;

            List<Color> activeRandomColors = CreateListOfNRandomColors(numberOfColors, CreateColors());

            Random random = new Random();         

            foreach (VialControl vial in Vials)
            {
                vial.MaxSegments = (int)Properties.Settings.Default.SegmentsCount;
            }

            List<Color> allSegments = new List<Color>();

            for (int i = 0; i < numberOfColors; i++)
            {
                for (int j = 0; j < Properties.Settings.Default.SegmentsCount; j++)
                {
                    allSegments.Add(activeRandomColors[i]);
                }
            }

            for (int i = 0; i < numberOfColors; i++)
            {
                for (int j = 0; j < Vials[i].MaxSegments; j++)
                {
                    int size = allSegments.Count;
                    int randomIndex = random.Next(0, size);
                    Vials[i].Segments.Add(allSegments[randomIndex]);
                    allSegments.RemoveAt(randomIndex);
                }
            }
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();

            if (settingsWindow.ChangesApplied)
            {
                MainForm_Load(sender, e);
            }
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
