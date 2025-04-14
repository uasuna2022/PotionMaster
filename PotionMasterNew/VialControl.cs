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
    public partial class VialControl : UserControl
    {
        private int MaxSegments = 4;
        public int GetSetMaximumAmountOfSegments
        {
            get { return MaxSegments; }
            set
            {
                MaxSegments = value;
                Invalidate();
            }
        }

        private int InitSegmentCount = 0;
        public int GetSetInitialAmountOfSegments
        {
            get { return InitSegmentCount; }
            set
            {
                InitSegmentCount = value;
                Invalidate();
            }
        }

        private List<Color>? Segments = null;
        public List<Color>? GetSetSegments
        {
            get { return Segments; }
            set
            {
                Segments = value;
                Invalidate();
            }
        }
        public VialControl()
        {
            this.AllowDrop = true;
            //this.MouseDown += VialControl_MouseDown;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e);
            Graphics g = e.Graphics;
            int sideMargin = 2;
            int top_bottomMargin = 2;
            int segmentMargin = 3;
            int segmentHeight = (this.Height - 2 * top_bottomMargin - (MaxSegments - 1) * segmentMargin) 
                / MaxSegments;

            for (int i = 0; i < MaxSegments; i++)
            {
                int segmentY = this.Height - (i + 1) * segmentHeight - top_bottomMargin - i * segmentMargin;
                Rectangle segmentRectangle = 
                    new Rectangle(sideMargin, segmentY, this.Width - 2 * sideMargin - 1, segmentHeight);

                Color colorToFill = Color.Transparent;
                if (i < InitSegmentCount && Segments != null)
                {
                    colorToFill = Segments[i];
                }
                else if (Segments == null && i < InitSegmentCount)
                {
                    colorToFill = Color.Red; // hardcoded at the moment, in the future it will be randomized
                }

                if (colorToFill != Color.Transparent)
                {
                    using (SolidBrush brush = new SolidBrush(colorToFill))
                    {
                        g.FillRectangle(brush, segmentRectangle);
                    }
                }

                g.DrawRectangle(new Pen(Color.Black), segmentRectangle);
            }

            using (Pen pen = new Pen(Color.Black))
            {
                g.DrawRectangle(pen, 0, 0, 60, 180);
            }
        }
    }
}
