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
        public int MaxSegments = 4;

        public int InitSegmentCount = 1;

        public List<Color> Segments = new List<Color>();
        public VialControl()
        {
            this.AllowDrop = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
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

                if (i <= Segments.Count - 1)
                {
                    colorToFill = Segments[i];
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
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (Segments.Count() > 0)
            {
                this.DoDragDrop(this, DragDropEffects.Move);
            }
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            base.OnDragDrop(e);
            VialControl ChosenVial = (VialControl)(e.Data!.GetData(typeof(VialControl)));

            if (ChosenVial != null && ChosenVial != this && ChosenVial.Segments.Count != 0)
            {
                Color topColor = ChosenVial.Segments[ChosenVial.Segments.Count - 1];
                int count = 1;
                
                for (int i = ChosenVial.Segments.Count - 2; i >= 0; i--)
                {
                    if (ChosenVial.Segments[i] != topColor) break;

                    count++;
                }

                if (Segments.Count + count <= MaxSegments && (Segments.Count == 0 || Segments[Segments.Count - 1] == topColor))
                {
                    for (int i = 0; i < count; i++)
                    {
                        ChosenVial.Segments.RemoveAt(ChosenVial.Segments.Count() - 1);
                        Segments.Add(topColor);
                    }
                }

                ChosenVial.Invalidate();
                Invalidate();
            }
        }

        protected override void OnDragEnter(DragEventArgs e)
        {
            if (e.Data!.GetDataPresent(typeof(VialControl)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
