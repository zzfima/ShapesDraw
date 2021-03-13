using System.Drawing;
using System.Windows.Forms;

namespace ShapesDraw
{
    public interface IDrawableElement
    {
        void Draw(PaintEventArgs e);
        Point StartPoint { get; set; }
    }
}