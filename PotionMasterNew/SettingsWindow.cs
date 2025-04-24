using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotionMasterNew
{
    public partial class SettingsWindow : Form
    {
        public string Difficulty { get; set; } = Properties.Settings.Default.Difficulty;
        public decimal VialsCount { get; set; } = Properties.Settings.Default.VialsCount;
        public decimal MaxSegmetsCount { get; set; } = Properties.Settings.Default.SegmentsCount;
        public string ThemeColor { get; set; } = Properties.Settings.Default.ColorTheme;
        public bool ChangesApplied { get; set; } = false;
        public bool ThemeApplied { get; set; } = false;
        public SettingsWindow()
        {
            InitializeComponent();
            this.difficultyComboBox.SelectedItem = Difficulty;
            this.segmentsCountNumericUpDown.Value = MaxSegmetsCount;
            this.vialsCountNumericUpDown.Value = VialsCount;
            if (ThemeColor == lightRadioButton.Text)
            {
                lightRadioButton.Select();
            }
            else
            {
                darkRadioButton.Select();
            }
        }

        private void difficultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Difficulty = difficultyComboBox.Text;
        }

        private void segmentsCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MaxSegmetsCount = segmentsCountNumericUpDown.Value;
        }

        private void vialsCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            VialsCount = vialsCountNumericUpDown.Value;
        }

        private void lightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ThemeColor = "Light";
        }

        private void darkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ThemeColor = "Dark";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (Difficulty != Properties.Settings.Default.Difficulty ||
                VialsCount != Properties.Settings.Default.VialsCount ||
                MaxSegmetsCount != Properties.Settings.Default.SegmentsCount) 
            {
                Properties.Settings.Default.Difficulty = Difficulty;
                Properties.Settings.Default.VialsCount = VialsCount;
                Properties.Settings.Default.SegmentsCount = MaxSegmetsCount;
                ChangesApplied = true;
            }

            if (ThemeColor != Properties.Settings.Default.ColorTheme)
            {
                Properties.Settings.Default.ColorTheme = ThemeColor;
                ThemeApplied = true;
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ChangesApplied = false;
            this.Close();
            return;
        }
    }
}
