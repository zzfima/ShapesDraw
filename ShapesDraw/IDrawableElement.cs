using System.Windows.Forms;

namespace ShapesDraw
{
    public interface IDrawableElement
    {
        void Draw(PaintEventArgs e);
    }
}