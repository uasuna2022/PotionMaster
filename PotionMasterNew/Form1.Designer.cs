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
            tableLayoutPanel = new TableLayoutPanel();
            vialControl1 = new VialControl();
            vialControl2 = new VialControl();
            vialControl3 = new VialControl();
            vialControl4 = new VialControl();
            menuStrip.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
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
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Controls.Add(vialControl1, 0, 0);
            tableLayoutPanel.Controls.Add(vialControl2, 1, 0);
            tableLayoutPanel.Controls.Add(vialControl3, 2, 0);
            tableLayoutPanel.Controls.Add(vialControl4, 3, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 28);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(782, 425);
            tableLayoutPanel.TabIndex = 1;
            // 
            // vialControl1
            // 
            vialControl1.AllowDrop = true;
            vialControl1.Anchor = AnchorStyles.None;
            vialControl1.GetSetInitialAmountOfSegments = 0;
            vialControl1.GetSetMaximumAmountOfSegments = 4;
            vialControl1.GetSetSegments = null;
            vialControl1.Location = new Point(67, 122);
            vialControl1.Name = "vialControl1";
            vialControl1.Size = new Size(61, 181);
            vialControl1.TabIndex = 0;
            // 
            // vialControl2
            // 
            vialControl2.AllowDrop = true;
            vialControl2.Anchor = AnchorStyles.None;
            vialControl2.GetSetInitialAmountOfSegments = 0;
            vialControl2.GetSetMaximumAmountOfSegments = 4;
            vialControl2.GetSetSegments = null;
            vialControl2.Location = new Point(262, 122);
            vialControl2.Name = "vialControl2";
            vialControl2.Size = new Size(61, 181);
            vialControl2.TabIndex = 1;
            // 
            // vialControl3
            // 
            vialControl3.AllowDrop = true;
            vialControl3.Anchor = AnchorStyles.None;
            vialControl3.GetSetInitialAmountOfSegments = 0;
            vialControl3.GetSetMaximumAmountOfSegments = 4;
            vialControl3.GetSetSegments = null;
            vialControl3.Location = new Point(457, 122);
            vialControl3.Name = "vialControl3";
            vialControl3.Size = new Size(61, 181);
            vialControl3.TabIndex = 2;
            // 
            // vialControl4
            // 
            vialControl4.AllowDrop = true;
            vialControl4.Anchor = AnchorStyles.None;
            vialControl4.GetSetInitialAmountOfSegments = 0;
            vialControl4.GetSetMaximumAmountOfSegments = 4;
            vialControl4.GetSetSegments = null;
            vialControl4.Location = new Point(653, 122);
            vialControl4.Name = "vialControl4";
            vialControl4.Size = new Size(61, 181);
            vialControl4.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(tableLayoutPanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(500, 300);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion Master";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel;
        private VialControl vialControl1;
        private VialControl vialControl2;
        private VialControl vialControl3;
        private VialControl vialControl4;
    }
}
