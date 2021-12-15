using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_paint
{
    struct Points
    {
        public int PointStartX { get; set; }
        public int PointStartY { get; set; }
        public int PointEndX { get; set; }
        public int PointEndY { get; set; }
        public int PointMoveStartX { get; set; }
        public int PointMoveStartY { get; set; }
        public int PointMoveEndX { get; set; }
        public int PointMoveEndY { get; set; }

        public Points(int pointStartX, int pointStartY, int pointEndX, int pointEndY, int pointMoveStartX, int pointMoveStartY, int pointMoveEndX, int pointMoveEndY)
        {
            PointStartX = pointStartX;
            PointStartY = pointStartY;
            PointEndX = pointEndX;
            PointEndY = pointEndY;
            PointMoveStartX = pointMoveStartX;
            PointMoveStartY = pointMoveStartY;
            PointMoveEndX = pointMoveEndX;
            PointMoveEndY = pointMoveEndY;
        }
    }
}
