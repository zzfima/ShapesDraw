using System.Drawing;
using System.Windows.Forms;

namespace ShapesDraw
{
    public class DrawableSquare : IDrawableElement
    {
        #region Properties
        private Point _startPoint { get; set; }
        private Point _endPoint { get; set; }
        #endregion

        public DrawableSquare(Point pointA, Point pointB)
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
            Size size = new Size(_endPoint.X - _startPoint.X, _endPoint.Y - _startPoint.Y);
            Rectangle rect = new Rectangle(_startPoint, size);
            e.Graphics.DrawRectangle(Pens.Black, rect);
        }
    }
}