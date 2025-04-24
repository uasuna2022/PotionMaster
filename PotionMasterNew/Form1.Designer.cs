namespace PotionMasterNew
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            surrenderToolStripMenuItem = new ToolStripMenuItem();
            exitGameToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            openSettingsToolStripMenuItem = new ToolStripMenuItem();
            gameFieldTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel = new TableLayoutPanel();
            playerButtonsTableLayoutPanel = new TableLayoutPanel();
            nextPuzzleButton = new Button();
            scoreUndoTableLayoutPanel = new TableLayoutPanel();
            undoButton = new Button();
            undosLeftLabel = new Label();
            scoreLabel = new Label();
            bestScoreLabel = new Label();
            menuStrip.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            playerButtonsTableLayoutPanel.SuspendLayout();
            scoreUndoTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(782, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, surrenderToolStripMenuItem, exitGameToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(165, 26);
            newGameToolStripMenuItem.Text = "New Game";
            // 
            // surrenderToolStripMenuItem
            // 
            surrenderToolStripMenuItem.Name = "surrenderToolStripMenuItem";
            surrenderToolStripMenuItem.Size = new Size(165, 26);
            surrenderToolStripMenuItem.Text = "Surrender";
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.Size = new Size(165, 26);
            exitGameToolStripMenuItem.Text = "Exit Game";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // openSettingsToolStripMenuItem
            // 
            openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            openSettingsToolStripMenuItem.Size = new Size(194, 26);
            openSettingsToolStripMenuItem.Text = "Open Settings...";
            openSettingsToolStripMenuItem.Click += openSettingsToolStripMenuItem_Click;
            // 
            // gameFieldTableLayoutPanel
            // 
            gameFieldTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            gameFieldTableLayoutPanel.Dock = DockStyle.Fill;
            gameFieldTableLayoutPanel.Location = new Point(3, 3);
            gameFieldTableLayoutPanel.Name = "gameFieldTableLayoutPanel";
            gameFieldTableLayoutPanel.Size = new Size(776, 339);
            gameFieldTableLayoutPanel.TabIndex = 1;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(gameFieldTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(playerButtonsTableLayoutPanel, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 28);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            mainTableLayoutPanel.Size = new Size(782, 425);
            mainTableLayoutPanel.TabIndex = 2;
            // 
            // playerButtonsTableLayoutPanel
            // 
            playerButtonsTableLayoutPanel.ColumnCount = 2;
            playerButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            playerButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            playerButtonsTableLayoutPanel.Controls.Add(nextPuzzleButton, 1, 0);
            playerButtonsTableLayoutPanel.Controls.Add(scoreUndoTableLayoutPanel, 0, 0);
            playerButtonsTableLayoutPanel.Dock = DockStyle.Fill;
            playerButtonsTableLayoutPanel.Location = new Point(3, 348);
            playerButtonsTableLayoutPanel.Name = "playerButtonsTableLayoutPanel";
            playerButtonsTableLayoutPanel.RowCount = 1;
            playerButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            playerButtonsTableLayoutPanel.Size = new Size(776, 74);
            playerButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // nextPuzzleButton
            // 
            nextPuzzleButton.Anchor = AnchorStyles.Right;
            nextPuzzleButton.Location = new Point(672, 22);
            nextPuzzleButton.Margin = new Padding(3, 3, 10, 3);
            nextPuzzleButton.Name = "nextPuzzleButton";
            nextPuzzleButton.Size = new Size(94, 29);
            nextPuzzleButton.TabIndex = 0;
            nextPuzzleButton.Text = "Next Puzzle";
            nextPuzzleButton.UseVisualStyleBackColor = true;
            // 
            // scoreUndoTableLayoutPanel
            // 
            scoreUndoTableLayoutPanel.ColumnCount = 2;
            scoreUndoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            scoreUndoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            scoreUndoTableLayoutPanel.Controls.Add(undoButton, 0, 0);
            scoreUndoTableLayoutPanel.Controls.Add(undosLeftLabel, 0, 1);
            scoreUndoTableLayoutPanel.Controls.Add(scoreLabel, 1, 0);
            scoreUndoTableLayoutPanel.Controls.Add(bestScoreLabel, 1, 1);
            scoreUndoTableLayoutPanel.Dock = DockStyle.Fill;
            scoreUndoTableLayoutPanel.Location = new Point(3, 3);
            scoreUndoTableLayoutPanel.Name = "scoreUndoTableLayoutPanel";
            scoreUndoTableLayoutPanel.RowCount = 2;
            scoreUndoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            scoreUndoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            scoreUndoTableLayoutPanel.Size = new Size(304, 68);
            scoreUndoTableLayoutPanel.TabIndex = 1;
            // 
            // undoButton
            // 
            undoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            undoButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            undoButton.Location = new Point(20, 14);
            undoButton.Margin = new Padding(20, 3, 3, 3);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(87, 23);
            undoButton.TabIndex = 0;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            // 
            // undosLeftLabel
            // 
            undosLeftLabel.AutoSize = true;
            undosLeftLabel.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            undosLeftLabel.Location = new Point(39, 40);
            undosLeftLabel.Margin = new Padding(39, 0, 0, 0);
            undosLeftLabel.Name = "undosLeftLabel";
            undosLeftLabel.Size = new Size(52, 17);
            undosLeftLabel.TabIndex = 1;
            undosLeftLabel.Text = "(Left: 3)";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(135, 0);
            scoreLabel.Margin = new Padding(25, 0, 3, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(61, 20);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "Score: 0";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Location = new Point(135, 40);
            bestScoreLabel.Margin = new Padding(25, 0, 3, 0);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(93, 20);
            bestScoreLabel.TabIndex = 3;
            bestScoreLabel.Text = "Best Score: 0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(mainTableLayoutPanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(500, 300);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion Master";
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            playerButtonsTableLayoutPanel.ResumeLayout(false);
            scoreUndoTableLayoutPanel.ResumeLayout(false);
            scoreUndoTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem surrenderToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem openSettingsToolStripMenuItem;
        private TableLayoutPanel gameFieldTableLayoutPanel;
        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel playerButtonsTableLayoutPanel;
        private Button nextPuzzleButton;
        private TableLayoutPanel scoreUndoTableLayoutPanel;
        private Button undoButton;
        private Label undosLeftLabel;
        private Label scoreLabel;
        private Label bestScoreLabel;
    }
}
