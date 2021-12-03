using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_paint
{
    struct GetPoint
    {
        public int PointStartX { get; set; }
        public int PointStartY { get; set; }
        public int PointEndX { get; set; }
        public int PointEndY { get; set; }

        public GetPoint(int pointStartX, int pointStartY, int pointEndX, int pointEndY)
        {
            PointStartX = pointStartX;
            PointStartY = pointStartY;
            PointEndX = pointEndX;
            PointEndY = pointEndY;
        }
    }
}
