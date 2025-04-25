using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionMasterNew.CustomEvents
{
    public class MoveEventArgs: EventArgs
    {
        public VialControl Source { get; }
        public VialControl Destination { get; }
        public int SegmentsMoved { get; }
        public Color ColorPoured { get; }

        public MoveEventArgs(VialControl source,
                             VialControl destination,
                             int segmentsMoved,
                             Color colorPoured)
        {
            Source = source;
            Destination = destination;
            SegmentsMoved = segmentsMoved;
            ColorPoured = colorPoured;
        }
    }
}
