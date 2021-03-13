using System.Drawing;
using System.Windows.Forms;

namespace ShapesDraw
{
    public class DrawableCircle : IDrawableElement
    {
        #region Properties
        public Point StartPoint { get; set; }
        private Point _endPoint { get; set; }
        #endregion

        public DrawableCircle(Point pointA, Point pointB)
        {
            //Choose who is start point and who is end point
            if (pointA.X < pointB.X)
            {
                StartPoint = pointA;
                _endPoint = pointB;
            }
            else
            {
                StartPoint = pointB;
                _endPoint = pointA;
            }
        }

        public void Draw(PaintEventArgs e)
        {
            int side = _endPoint.X - StartPoint.X;
            Size size = new Size(side, side);
            Rectangle rect = new Rectangle(StartPoint, size);
            e.Graphics.DrawEllipse(Pens.Black, rect);
        }
    }
}