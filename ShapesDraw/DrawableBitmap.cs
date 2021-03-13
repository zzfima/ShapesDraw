using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ShapesDraw
{
    public class BitmapSaver
    {
        private string v;
        #region Properties
        private FileInfo _file { get; set; }
        #endregion

        public BitmapSaver(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }

            _file = fileInfo;
        }

        internal void Save(Form1 form1)
        {
            using (Bitmap bmp = new Bitmap(form1.Width, form1.Height))
            {
                form1.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                Bitmap resized = new Bitmap(bmp, new Size((int)(bmp.Width * 2.7), (int)(bmp.Height * 3.4)));
                resized.Save(_file.FullName);
            }
        }
    }
}