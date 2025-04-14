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
        [Category("VialSettings")]
        [Description("A number representing how many liquid parts can fit in a vial.")]
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
        [Category("VialSettings")]
        [Description("Initial number of segments filled in the vial.")]
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
        [Category("VialSettings")]
        [Description("Collection of color segments in the vial. If set, InitSegmentCount is ignored.")]
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
            //InitializeComponent();
            this.AllowDrop = true;
            //this.MouseDown += VialControl_MouseDown;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            using (Pen pen = new Pen(Color.Black))
            {
                g.DrawRectangle(pen, 0, 0, 60, 180);
            }
        }
    }
}
