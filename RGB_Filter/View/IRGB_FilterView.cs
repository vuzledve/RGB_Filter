using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Filter.View  
{
    internal interface IRGB_FilterView : ICutCanvas, IFilterCanvas
    {
        void Show(); //запуск формы

        Bitmap Canvas { set; }
        Bitmap FiltredCanvas { set; }

        public event Action SetCanvasFromModel;         //получить картинку из модели
        public event Action SetFiltredCanvasFromModel;  //получить отфильтрованную картинку из модели

        event Action<string> SetCanvasFromFile;         // событие "пользователь пытается устрановить фон из файла"
        event Action SetCanvasFromScreen;               // событие "пользователь пытается устрановить фон из скрина"

        event Action<Point, Point> PaintFrameOnCanvas;          // нарисовать рамку на исходнике
        event Action<Point, Point> PaintFrameOnFiltredCanvas;   // нарисовать рамку на отфильтрованной картинке
    }
}
