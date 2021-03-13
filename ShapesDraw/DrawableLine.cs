using System.Drawing;
using System.Windows.Forms;

namespace ShapesDraw
{
    public class DrawableLine : IDrawableElement
    {
        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 2, 2, 55, 55);
        }
    }
}