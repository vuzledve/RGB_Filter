using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Filter.Model
{
    internal class RGB_FilterModel : IRGB_FilterModel
    {
        private Bitmap _canvas;
        private Bitmap _filtredCanvas;
        public Bitmap Canvas => new Bitmap(_canvas);  //отдаем копию. public Bitmap Canvas => _canvas; //cloneTODO
        public Bitmap FiltredCanvas => new Bitmap(_filtredCanvas);  //отдаем копию

        public event Action NewCanvasSetted;        // событие "Установлен новый фон"
        public event Action NewFiltredCanvasSetted; // событие "Установлен новый обработанный фон"

        public byte Rmin { get; private set; }
        public byte Rmax { get; private set; }
        public byte Gmin { get; private set; }
        public byte Gmax { get; private set; }
        public byte Bmin { get; private set; }
        public byte Bmax { get; private set; }
        public Color RightPix { get; private set; }
        public Color WrongPix { get; private set; }
       

        public RGB_FilterModel()
        {
            Rmin = 0;
            Rmax = 255;
            Gmin = 0;
            Gmax = 0;
            Bmin = 0;
            Bmax = 255;
            RightPix = Color.Black;
            WrongPix = Color.White;
            BitmapGetter.MakeDefaultBitmap(ref _canvas,1000,580);
            FilterCanvas();
        }

        /* установить canvas из файла */
        public void SetCanvasFromFile(string path)
        {
            BitmapGetter.SetBitmapFromFile(ref _canvas, path);
            FilterCanvas();
            NewCanvasSetted.Invoke();
        }

        /* установить canvas из скриншота */
        public void SetCanvasFromScreen()
        {
            BitmapGetter.SetBitmapFromScreen(ref _canvas);
            FilterCanvas();
            NewCanvasSetted.Invoke();
        }

        /* обрезать canvas */
        public void CutCanvas(int startX, int startY, int width, int height)
        {
            BitmapGetter.CutBitmap(ref _canvas, startX, startY, width, height);
            BitmapGetter.CutBitmap(ref _filtredCanvas, startX, startY, width, height);
            NewCanvasSetted.Invoke();
        }

        /*отфильтровать цвета*/
        public void FilterCanvas()
        {
            if (_canvas == null)
                throw new NotImplementedException();

            _filtredCanvas = new Bitmap(_canvas);

            for (int i = 0; i < _filtredCanvas.Width; i++)
            {
                for (int j = 0; j < _filtredCanvas.Height; j++)
                {
                    Color pix = _canvas.GetPixel(i, j);
                    if ((pix.R >= Rmin && pix.R <= Rmax) &&
                            (pix.G >= Gmin && pix.G <= Gmax) &&
                            (pix.B >= Bmin && pix.B <= Bmax))
                    {
                        if (RightPix != Color.Transparent)
                            _filtredCanvas.SetPixel(i, j, RightPix);
                    }
                    else
                        if (RightPix != Color.Transparent)
                        _filtredCanvas.SetPixel(i, j, WrongPix);
                }
            }

            NewFiltredCanvasSetted?.Invoke();
        }

     

        //public async Color GetPixelColorAsync(int x, int y)
        //{
        //    throw new NotImplementedException(); return new Color();
        //    //Task task = new Task(() => GetPixelColor(x, y));
        //    //task.Start();
        //    //return await task;
        //}
        private Color GetPixelColor(int x, int y)
        {
            return _canvas.GetPixel(x, y);
        }

        public void SetFilterParam(byte Rmin, byte Rmax, byte Gmin, byte Gmax, byte Bmin, byte Bmax)
        {
            this.Rmin = Rmin;
            this.Rmax = Rmax;
            this.Gmin = Gmin;
            this.Gmax = Gmax;
            this.Bmin = Bmin;
            this.Bmax = Bmax;
        }

        public void SetFilterColors(Color rightPix, Color wrongPix)
        {
            this.RightPix = rightPix;
            this.WrongPix = wrongPix;
        }
    }
}

