using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Filter.View
{
    internal class BitmapPainter
    {
        private bool isMouseDown = false;

        private Point cutStart = Point.Empty;
        private Point cutEnd = Point.Empty;
        private Point realCutStart = new Point();
        private Size realCutSize = new Size();

        /* Отрисовка одной рамки */
        static private void PaintFrame(Bitmap bitmap, int startX, int startY, int sizeX, int sizeY, Color color)
        {
            Graphics Graph = Graphics.FromImage(bitmap);

            // Create pen.
            Pen pen = new Pen(color, 1);

            //квадрат без угловых точек
            try { Graph.DrawLine(pen, startX, startY - 1, startX + sizeX, startY - 1); } catch { }                      //верx
            try { Graph.DrawLine(pen, startX, startY + sizeY + 1, startX + sizeX, startY + sizeY + 1); } catch { }    //низ
            try { Graph.DrawLine(pen, startX - 1, startY, startX - 1, startY + sizeY); } catch { }                     //лево
            try { Graph.DrawLine(pen, startX + sizeX + 1, startY, startX + sizeX + 1, startY + sizeY); } catch { }     //право

            //угловые точки
            try { bitmap.SetPixel(startX - 1, startY - 1, color); } catch { }                   //лево верх
            try { bitmap.SetPixel(startX + sizeX + 1, startY - 1, color); } catch { }           //право верх
            try { bitmap.SetPixel(startX + sizeX + 1, startY + sizeY + 1, color); } catch { }  //право низ
            try { bitmap.SetPixel(startX - 1, startY + sizeY + 1, color); } catch { }          //лево низ

            //Graph.Dispose();

        }
    }
}
