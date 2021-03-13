using System.Drawing;
using System.Windows.Forms;

namespace ShapesDraw
{
    public class DrawableLine : IDrawableElement
    {
        #region Properties
        private Point _startPoint { get; set; }
        private Point _endPoint { get; set; }
        #endregion

        public DrawableLine(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, _startPoint, _endPoint);
        }
    }
}