using System.Drawing;
using System.Windows.Forms;

namespace ShapesDraw
{
    public class DrawableCircle : IDrawableElement
    {
        #region Properties
        private Point _startPoint { get; set; }
        private Point _endPoint { get; set; }
        #endregion

        public DrawableCircle(Point pointA, Point pointB)
        {
            //Choose who is start point and who is end point
            if (pointA.X < pointB.X)
            {
                _startPoint = pointA;
                _endPoint = pointB;
            }
            else
            {
                _startPoint = pointB;
                _endPoint = pointA;
            }
        }

        public void Draw(PaintEventArgs e)
        {
            int side = _endPoint.X - _startPoint.X;
            Size size = new Size(side, side);
            Rectangle rect = new Rectangle(_startPoint, size);
            e.Graphics.DrawEllipse(Pens.Black, rect);
        }
    }
}