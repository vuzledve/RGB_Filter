using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Filter.Model
{
    static internal class BitmapGetter
    {
        /* установить Bitmap из файла */
        public static void SetBitmapFromFile(ref Bitmap bitmap, string path)
        {
            bitmap?.Dispose();
            bitmap = new Bitmap(path);
        }

        /* установить Bitmap из скриншота */
        public static void SetBitmapFromScreen(ref Bitmap bitmap)
        {
            bitmap?.Dispose();
            bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);  //создаем Bitmap с размерами экрана
            using (Graphics graph = Graphics.FromImage(bitmap))    //Создаем Graphics для Bitmap'a
            {
                graph.CopyFromScreen(0, 0, 0, 0, bitmap.Size);  //Копируем скрин в Bitmap
            }
            //System.GC.Collect();
            //System.GC.WaitForPendingFinalizers();
        }

        /* обрезать Bitmap */
        public static void CutBitmap(ref Bitmap bitmap, int startX, int startY, int width, int height)
        {
            Bitmap tmp = bitmap.Clone(new Rectangle(new Point(startX, startY), new Size(width, height)), bitmap.PixelFormat);          
            bitmap = tmp.Clone(new Rectangle(new Point(startX, startY), new Size(width, height)), bitmap.PixelFormat);

            tmp.Dispose();
            //System.GC.Collect();
            //System.GC.WaitForPendingFinalizers();
        }

        /* создание демонстрационного Bitmap'a */
        public static void MakeDefaultBitmap(ref Bitmap bitmap, int width, int height)
        {
            int step_x = width / 6;
            int step_y = height / 4;

            int radius = step_x < step_y ? step_x / 2 : step_y / 2;
            bitmap = new Bitmap(width, height);

            int[] centerX = new int[3];
            for (int i = 0; i < centerX.Length; i++)
                centerX[i] = step_x * (i * 2 + 1);

            int[] centerY = new int[2];
            for (int i = 0; i < centerY.Length; i++)
                centerY[i] = step_y * (i * 2 + 1);

            Brush[] brushes = new Brush[6]
            {
                new SolidBrush(Color.FromArgb(255, 255, 0)),
                new SolidBrush(Color.FromArgb(0, 255, 255)),
                new SolidBrush(Color.FromArgb(255, 0, 255)),
                Brushes.Red,
                Brushes.Green,
                Brushes.Blue
            };

            Pen borderPen = new Pen(Color.Black, 5);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                for (int i = 0; i < centerX.Length; i++)             
                { 
                    for (int j = 0; j < centerY.Length; j++)
                    {
                        g.FillEllipse(brushes[i * 2 + j], centerX[i] - radius, centerY[j] - radius, radius + radius, radius + radius);
                        g.DrawEllipse(borderPen, centerX[i] - radius, centerY[j] - radius, radius + radius, radius + radius);
                    }
                }
            }
            brushes[0].Dispose();
            brushes[1].Dispose();
            brushes[2].Dispose();
        }

    }
}
