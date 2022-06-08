using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Filter.Model
{
    internal interface IRGB_FilterModel
    {
        public Bitmap Canvas { get;}            //необработанное изображение (фон)
        public Bitmap FiltredCanvas { get;}     //обработанный фон

        event Action NewCanvasSetted;           // событие "Установлен новый фон"
        event Action NewFiltredCanvasSetted;    // событие "Установлен новый обработанный фон"

        

        void SetCanvasFromScreen();             //Установить фон из скриншота
        void SetCanvasFromFile(string path);    //установить фон из файла
        void CutCanvas(int startX, int startY, int width, int height);  //обрезать фон
        void FilterCanvas();    //отфильтровать фон

        public byte Rmin { get; }
        public byte Rmax { get; }
        public byte Gmin { get; }
        public byte Gmax { get; }
        public byte Bmin { get; }
        public byte Bmax { get; }
        public Color RightPix { get; }
        public Color WrongPix { get; }


        void SetFilterParam(byte Rmin, byte Rmax, byte Gmin, byte Gmax, byte Bmin, byte Bmax);
        void SetFilterColors(Color rightPix, Color wrongPix);

     //   Color GetPixelColorAsync(int x, int y); //получить цвет пикселя


    }
}
