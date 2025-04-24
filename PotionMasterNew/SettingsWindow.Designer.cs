namespace PotionMasterNew
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTableLayoutPanelSettings = new TableLayoutPanel();
            buttonTableLayoutPanel = new TableLayoutPanel();
            cancelButton = new Button();
            OKButton = new Button();
            LableTableLayoutPanel = new TableLayoutPanel();
            difficultyLabel = new Label();
            segmentsCountLabel = new Label();
            vialsCountLabel = new Label();
            colorThemeLabel = new Label();
            DataTableLayoutPanel = new TableLayoutPanel();
            segmentsCountNumericUpDown = new NumericUpDown();
            vialsCountNumericUpDown = new NumericUpDown();
            difficultyComboBox = new ComboBox();
            colorThemeTableLayoutPanel = new TableLayoutPanel();
            lightRadioButton = new RadioButton();
            darkRadioButton = new RadioButton();
            mainTableLayoutPanelSettings.SuspendLayout();
            buttonTableLayoutPanel.SuspendLayout();
            LableTableLayoutPanel.SuspendLayout();
            DataTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)segmentsCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vialsCountNumericUpDown).BeginInit();
            colorThemeTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanelSettings
            // 
            mainTableLayoutPanelSettings.ColumnCount = 2;
            mainTableLayoutPanelSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            mainTableLayoutPanelSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            mainTableLayoutPanelSettings.Controls.Add(buttonTableLayoutPanel, 1, 1);
            mainTableLayoutPanelSettings.Controls.Add(LableTableLayoutPanel, 0, 0);
            mainTableLayoutPanelSettings.Controls.Add(DataTableLayoutPanel, 1, 0);
            mainTableLayoutPanelSettings.Dock = DockStyle.Fill;
            mainTableLayoutPanelSettings.Location = new Point(0, 0);
            mainTableLayoutPanelSettings.Name = "mainTableLayoutPanelSettings";
            mainTableLayoutPanelSettings.RowCount = 2;
            mainTableLayoutPanelSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            mainTableLayoutPanelSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            mainTableLayoutPanelSettings.Size = new Size(582, 353);
            mainTableLayoutPanelSettings.TabIndex = 0;
            // 
            // buttonTableLayoutPanel
            // 
            buttonTableLayoutPanel.ColumnCount = 2;
            buttonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonTableLayoutPanel.Controls.Add(cancelButton, 0, 0);
            buttonTableLayoutPanel.Controls.Add(OKButton, 1, 0);
            buttonTableLayoutPanel.Dock = DockStyle.Fill;
            buttonTableLayoutPanel.Location = new Point(195, 285);
            buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            buttonTableLayoutPanel.RowCount = 1;
            buttonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonTableLayoutPanel.Size = new Size(384, 65);
            buttonTableLayoutPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.Location = new Point(49, 18);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // OKButton
            // 
            OKButton.Anchor = AnchorStyles.None;
            OKButton.Location = new Point(241, 18);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(94, 29);
            OKButton.TabIndex = 1;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // LableTableLayoutPanel
            // 
            LableTableLayoutPanel.ColumnCount = 1;
            LableTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LableTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LableTableLayoutPanel.Controls.Add(difficultyLabel, 0, 0);
            LableTableLayoutPanel.Controls.Add(segmentsCountLabel, 0, 1);
            LableTableLayoutPanel.Controls.Add(vialsCountLabel, 0, 2);
            LableTableLayoutPanel.Controls.Add(colorThemeLabel, 0, 3);
            LableTableLayoutPanel.Dock = DockStyle.Fill;
            LableTableLayoutPanel.Location = new Point(3, 3);
            LableTableLayoutPanel.Name = "LableTableLayoutPanel";
            LableTableLayoutPanel.RowCount = 4;
            LableTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LableTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LableTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LableTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LableTableLayoutPanel.Size = new Size(186, 276);
            LableTableLayoutPanel.TabIndex = 1;
            // 
            // difficultyLabel
            // 
            difficultyLabel.Anchor = AnchorStyles.None;
            difficultyLabel.AutoSize = true;
            difficultyLabel.Location = new Point(58, 24);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(69, 20);
            difficultyLabel.TabIndex = 0;
            difficultyLabel.Text = "Difficulty";
            // 
            // segmentsCountLabel
            // 
            segmentsCountLabel.Anchor = AnchorStyles.None;
            segmentsCountLabel.AutoSize = true;
            segmentsCountLabel.Location = new Point(34, 93);
            segmentsCountLabel.Name = "segmentsCountLabel";
            segmentsCountLabel.Size = new Size(117, 20);
            segmentsCountLabel.TabIndex = 1;
            segmentsCountLabel.Text = "Segments Count";
            // 
            // vialsCountLabel
            // 
            vialsCountLabel.Anchor = AnchorStyles.None;
            vialsCountLabel.AutoSize = true;
            vialsCountLabel.Location = new Point(51, 162);
            vialsCountLabel.Name = "vialsCountLabel";
            vialsCountLabel.Size = new Size(83, 20);
            vialsCountLabel.TabIndex = 2;
            vialsCountLabel.Text = "Vials Count";
            // 
            // colorThemeLabel
            // 
            colorThemeLabel.Anchor = AnchorStyles.None;
            colorThemeLabel.AutoSize = true;
            colorThemeLabel.Location = new Point(46, 231);
            colorThemeLabel.Name = "colorThemeLabel";
            colorThemeLabel.Size = new Size(94, 20);
            colorThemeLabel.TabIndex = 3;
            colorThemeLabel.Text = "Color Theme";
            // 
            // DataTableLayoutPanel
            // 
            DataTableLayoutPanel.ColumnCount = 1;
            DataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DataTableLayoutPanel.Controls.Add(segmentsCountNumericUpDown, 0, 1);
            DataTableLayoutPanel.Controls.Add(vialsCountNumericUpDown, 0, 2);
            DataTableLayoutPanel.Controls.Add(difficultyComboBox, 0, 0);
            DataTableLayoutPanel.Controls.Add(colorThemeTableLayoutPanel, 0, 3);
            DataTableLayoutPanel.Dock = DockStyle.Fill;
            DataTableLayoutPanel.Location = new Point(195, 3);
            DataTableLayoutPanel.Name = "DataTableLayoutPanel";
            DataTableLayoutPanel.RowCount = 4;
            DataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DataTableLayoutPanel.Size = new Size(384, 276);
            DataTableLayoutPanel.TabIndex = 2;
            // 
            // segmentsCountNumericUpDown
            // 
            segmentsCountNumericUpDown.Anchor = AnchorStyles.None;
            segmentsCountNumericUpDown.Location = new Point(117, 90);
            segmentsCountNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            segmentsCountNumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            segmentsCountNumericUpDown.Name = "segmentsCountNumericUpDown";
            segmentsCountNumericUpDown.Size = new Size(150, 27);
            segmentsCountNumericUpDown.TabIndex = 0;
            segmentsCountNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            segmentsCountNumericUpDown.ValueChanged += segmentsCountNumericUpDown_ValueChanged;
            // 
            // vialsCountNumericUpDown
            // 
            vialsCountNumericUpDown.Anchor = AnchorStyles.None;
            vialsCountNumericUpDown.Location = new Point(117, 159);
            vialsCountNumericUpDown.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            vialsCountNumericUpDown.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            vialsCountNumericUpDown.Name = "vialsCountNumericUpDown";
            vialsCountNumericUpDown.Size = new Size(150, 27);
            vialsCountNumericUpDown.TabIndex = 1;
            vialsCountNumericUpDown.Value = new decimal(new int[] { 4, 0, 0, 0 });
            vialsCountNumericUpDown.ValueChanged += vialsCountNumericUpDown_ValueChanged;
            // 
            // difficultyComboBox
            // 
            difficultyComboBox.Anchor = AnchorStyles.None;
            difficultyComboBox.FormattingEnabled = true;
            difficultyComboBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            difficultyComboBox.Location = new Point(116, 20);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(151, 28);
            difficultyComboBox.TabIndex = 2;
            difficultyComboBox.SelectedIndexChanged += difficultyComboBox_SelectedIndexChanged;
            // 
            // colorThemeTableLayoutPanel
            // 
            colorThemeTableLayoutPanel.ColumnCount = 2;
            colorThemeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            colorThemeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            colorThemeTableLayoutPanel.Controls.Add(lightRadioButton, 0, 0);
            colorThemeTableLayoutPanel.Controls.Add(darkRadioButton, 1, 0);
            colorThemeTableLayoutPanel.Dock = DockStyle.Fill;
            colorThemeTableLayoutPanel.Location = new Point(3, 210);
            colorThemeTableLayoutPanel.Name = "colorThemeTableLayoutPanel";
            colorThemeTableLayoutPanel.RowCount = 1;
            colorThemeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            colorThemeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            colorThemeTableLayoutPanel.Size = new Size(378, 63);
            colorThemeTableLayoutPanel.TabIndex = 3;
            // 
            // lightRadioButton
            // 
            lightRadioButton.Anchor = AnchorStyles.Right;
            lightRadioButton.AutoSize = true;
            lightRadioButton.Location = new Point(101, 19);
            lightRadioButton.Margin = new Padding(3, 3, 25, 3);
            lightRadioButton.Name = "lightRadioButton";
            lightRadioButton.Size = new Size(63, 24);
            lightRadioButton.TabIndex = 0;
            lightRadioButton.TabStop = true;
            lightRadioButton.Text = "Light";
            lightRadioButton.UseVisualStyleBackColor = true;
            lightRadioButton.CheckedChanged += lightRadioButton_CheckedChanged;
            // 
            // darkRadioButton
            // 
            darkRadioButton.Anchor = AnchorStyles.Left;
            darkRadioButton.AutoSize = true;
            darkRadioButton.Location = new Point(214, 19);
            darkRadioButton.Margin = new Padding(25, 3, 3, 3);
            darkRadioButton.Name = "darkRadioButton";
            darkRadioButton.Size = new Size(61, 24);
            darkRadioButton.TabIndex = 1;
            darkRadioButton.TabStop = true;
            darkRadioButton.Text = "Dark";
            darkRadioButton.UseVisualStyleBackColor = true;
            darkRadioButton.CheckedChanged += darkRadioButton_CheckedChanged;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(mainTableLayoutPanelSettings);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsWindow";
            TopMost = true;
            mainTableLayoutPanelSettings.ResumeLayout(false);
            buttonTableLayoutPanel.ResumeLayout(false);
            LableTableLayoutPanel.ResumeLayout(false);
            LableTableLayoutPanel.PerformLayout();
            DataTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)segmentsCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)vialsCountNumericUpDown).EndInit();
            colorThemeTableLayoutPanel.ResumeLayout(false);
            colorThemeTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanelSettings;
        private TableLayoutPanel buttonTableLayoutPanel;
        private Button cancelButton;
        private Button OKButton;
        private TableLayoutPanel LableTableLayoutPanel;
        private TableLayoutPanel DataTableLayoutPanel;
        private Label difficultyLabel;
        private Label segmentsCountLabel;
        private Label vialsCountLabel;
        private Label colorThemeLabel;
        private NumericUpDown segmentsCountNumericUpDown;
        private NumericUpDown vialsCountNumericUpDown;
        private ComboBox difficultyComboBox;
        private TableLayoutPanel colorThemeTableLayoutPanel;
        private RadioButton lightRadioButton;
        private RadioButton darkRadioButton;
    }
}