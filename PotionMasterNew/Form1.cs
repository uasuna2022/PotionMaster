using System.Collections.Specialized;
using System.Net.Sockets;
using System.Windows.Forms;
using PotionMasterNew.CustomEvents;

namespace PotionMasterNew
{
    public partial class MainForm : Form
    {
        public List<VialControl> Vials = new List<VialControl>();

        public Stack<(int outVialIndex, int inVialIndex, int numberOfSegments, Color color)> UndoStack =
            new Stack<(int, int, int, Color)>();
        private int UndoStackCapacity;
        private int UndosLeft;
        private int CurrentScore = 0;
        private int BestScore = 0;

        private int GetUndoPenalty()
        {
            return 5 * UndoStackCapacity;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildVialGrid(decimal vialCount, decimal maxSegments)
        {
            gameFieldTableLayoutPanel.SuspendLayout();
            gameFieldTableLayoutPanel.Controls.Clear();
            gameFieldTableLayoutPanel.ColumnStyles.Clear();
            gameFieldTableLayoutPanel.RowStyles.Clear();
            Vials.Clear();

            int numberOfColumns = Math.Min(7, (int)vialCount);
            int numberOfRows = ((int)vialCount % 7 == 0) ? (int)vialCount / 7 : (int)vialCount / 7 + 1;
            gameFieldTableLayoutPanel.ColumnCount = numberOfColumns;
            gameFieldTableLayoutPanel.RowCount = numberOfRows;

            for (int i = 0; i < numberOfColumns; i++)
            {
                gameFieldTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
            }
            for (int i = 0; i < numberOfRows; i++)
            {
                gameFieldTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / numberOfRows));
            }

            for (int i = 0; i < vialCount; i++)
            {
                VialControl newVial = new VialControl();
                newVial.Anchor = AnchorStyles.None;
                newVial.Size = new Size(61, 180);
                newVial.MaxSegments = (int)maxSegments;

                int row = i / numberOfColumns;
                int col = i % numberOfColumns;
                gameFieldTableLayoutPanel.Controls.Add(newVial, col, row);
                Vials.Add(newVial);

                newVial.MoveCompleted += Vial_PushCurrentStateOntoTheUndoStack;
                newVial.MoveCompleted += Vial_CheckWinCondition;
            }

            UndosLeft = SetUndoStackCapacity();
            UndoStackCapacity = SetUndoStackCapacity();
            undosLeftLabel.Text = $"(Left: {UndosLeft})";
            UndoStack.Clear();
            undoButton.Enabled = UndoStack.Count > 0 && UndosLeft > 0;
            nextPuzzleButton.Enabled = false;

            gameFieldTableLayoutPanel.ResumeLayout();
        }

        private int SetUndoStackCapacity()
        {
            int undoStackCapacity = 3;
            switch (Properties.Settings.Default.Difficulty)
            {
                case "Hard":
                    undoStackCapacity = 1;
                    break;
                case "Medium":
                    undoStackCapacity = 2;
                    break;
                case "Easy":
                    undoStackCapacity = 3;
                    break;
                default:
                    undoStackCapacity = 3;
                    break;
            }

            return undoStackCapacity;
        }

        private void Vial_PushCurrentStateOntoTheUndoStack(object? sender, MoveEventArgs e)
        {
            int outIndex = Vials.IndexOf(e.Source);
            int inIndex = Vials.IndexOf(e.Destination);
            int segmentsMoved = e.SegmentsMoved;
            Color colorMoved = e.ColorPoured;

            if (UndoStack.Count < UndoStackCapacity)
            {
                UndoStack.Push((outIndex, inIndex, segmentsMoved, colorMoved));
                undoButton.Enabled = UndoStack.Count > 0 && UndosLeft > 0;
                return;
            }

            if (UndoStack.Count == UndoStackCapacity)
            {
                Stack<(int outVialIndex, int inVialIndex, int numberOfSegments, Color color)> tempStack =
                    new Stack<(int outVialIndex, int inVialIndex, int numberOfSegments, Color color)>();
                while (UndoStack.Count > 0)
                {
                    var element = UndoStack.Pop();
                    tempStack.Push(element);
                }
                tempStack.Pop();
                UndoStack.Clear();
                while (tempStack.Count > 0)
                {
                    var element = tempStack.Pop();
                    UndoStack.Push(element);
                }

                UndoStack.Push((outIndex, inIndex, segmentsMoved, colorMoved));
            }

            undoButton.Enabled = UndoStack.Count > 0 && UndosLeft > 0;
        }

        private void Vial_CheckWinCondition(object? sender, MoveEventArgs e)
        {
            foreach (VialControl vial in Vials)
            {
                if (vial.Segments.Count == 0) continue;
                if (vial.Segments.Count != vial.MaxSegments)
                    return;

                Color vialColor = vial.Segments[0];
                for (int i = 1; i < vial.Segments.Count; i++)
                {
                    if (vial.Segments[i] != vialColor) return;
                }
            }

            nextPuzzleButton.Enabled = true;
            undoButton.Enabled = false;
            CurrentScore += (4 - UndoStackCapacity) * (int)Properties.Settings.Default.SegmentsCount *
                ((int)Properties.Settings.Default.VialsCount - UndoStackCapacity);
            if (CurrentScore > BestScore) BestScore = CurrentScore;

            scoreLabel.Text = $"Score: {CurrentScore}";
            bestScoreLabel.Text = $"Best Score: {BestScore}";
            congratsLabel.Visible = true;

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

            congratsLabel.Visible = false;
            fileToolStripMenuItem.Enabled = true;

            ApplyTheme();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();

            if (settingsWindow.ChangesApplied)
            {
                MainForm_Load(sender, e);
                CurrentScore = 0;
                scoreLabel.Text = $"Score: {CurrentScore}";

            }

            if (settingsWindow.ThemeApplied)
            {
                ApplyTheme();
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

        private void ApplyTheme()
        {
            bool dark = Properties.Settings.Default.ColorTheme == "Dark";

            Color backgroundColor = dark ? Color.FromArgb(60, 60, 60) : Color.White;

            Color textColor = dark ? Color.White : Color.Black;

            Color buttonColor = dark ? Color.FromArgb(100, 100, 100) : Color.FromKnownColor(KnownColor.Control);

            Color accentColor = Color.Pink;

            ApplyColours(this, backgroundColor, textColor, buttonColor);

            menuStrip.BackColor = accentColor;
            menuStrip.ForeColor = textColor;
            foreach (ToolStripMenuItem tsmi in menuStrip.Items)
                StyleMenuItemRecursive(tsmi, accentColor, textColor);

        }
        private void ApplyColours(Control currentControl, Color backgroundColor, Color textColor, Color buttonColor)
        {
            switch (currentControl)
            {
                case Button:
                    currentControl.BackColor = buttonColor;
                    break;

                case VialControl:
                    currentControl.BackColor = backgroundColor;
                    break;

                default:
                    currentControl.BackColor = backgroundColor;
                    break;
            }

            currentControl.ForeColor = textColor;

            foreach (Control child in currentControl.Controls)
                ApplyColours(child, backgroundColor, textColor, buttonColor);
        }
        private void StyleMenuItemRecursive(ToolStripMenuItem item, Color backgroundColor, Color textColor)
        {
            item.BackColor = backgroundColor;
            item.ForeColor = textColor;

            item.DropDown.BackColor = backgroundColor;
            item.DropDown.ForeColor = textColor;

            if (item.DropDown is ToolStripDropDownMenu tsddm)
            {
                tsddm.ShowImageMargin = false;
            }

            foreach (ToolStripItem child in item.DropDownItems)
            {
                if (child is ToolStripMenuItem tsmi) StyleMenuItemRecursive(tsmi, backgroundColor, textColor);
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (UndosLeft <= 0 || UndoStack.Count <= 0)
                return;

            var lastMove = UndoStack.Pop();

            int outIndex = lastMove.outVialIndex;
            int inIndex = lastMove.inVialIndex;
            int segmentsCount = lastMove.numberOfSegments;
            Color color = lastMove.color;

            VialControl source = Vials[outIndex];
            VialControl destination = Vials[inIndex];

            for (int i = 0; i < segmentsCount; i++)
            {
                destination.Segments.RemoveAt(destination.Segments.Count - 1);
                source.Segments.Add(color);
            }

            source.Invalidate();
            destination.Invalidate();

            CurrentScore -= GetUndoPenalty();
            scoreLabel.Text = $"Score: {CurrentScore}";

            UndosLeft--;
            undosLeftLabel.Text = $"(Left: {UndosLeft})";
            undoButton.Enabled = UndosLeft > 0 && UndoStack.Count > 0;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentScore = 0;
            scoreLabel.Text = $"Score: {CurrentScore}";

            MainForm_Load(sender, e);
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentScore > BestScore)
            {
                BestScore = CurrentScore;
                bestScoreLabel.Text = $"Best score: {BestScore}";
            }

            MessageBox.Show($"You ended the game!\n Game Score: {CurrentScore}\n Best Score: {BestScore}\n" +
                $"Tap Settings -> Open Settings and choose your preferencies to start a new game!");
            CurrentScore = 0;
            fileToolStripMenuItem.Enabled = false;
            foreach (VialControl vial in Vials)
                vial.Enabled = false;
            undoButton.Enabled = false;
            nextPuzzleButton.Enabled = false;
        }

        private void nextPuzzleButton_Click(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
        }

        private void exitGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Thanks for playing! Your best score is {BestScore}! See you later :))");
            Close();
        }
    }
}
