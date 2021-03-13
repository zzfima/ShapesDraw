using System.Drawing;
using System.Windows.Forms;

namespace ShapesDraw
{
    public class DrawableLine : IDrawableElement
    {
        #region Properties
        public Point StartPoint { get; set; }
        private Point _endPoint { get; set; }
        #endregion

        public DrawableLine(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            _endPoint = endPoint;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, StartPoint, _endPoint);
        }
    }
}