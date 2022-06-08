using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Filter.View
{
    internal interface IFilterCanvas
    {
        event Action FilterCanvas;  
        event Func<bool> FilterCanvasValidate;
        event Action SaveToDB;
        public string RminText { get; set; }
        public string RmaxText { get; set; }
        public string GminText { get; set; }
        public string GmaxText { get; set; }
        public string BminText { get; set; }
        public string BmaxText { get; set; }

        //validate
        Presenter.ValidationErrorTypes RminText_validationStatus { set; }
        Presenter.ValidationErrorTypes RmaxText_validationStatus { set; }
        Presenter.ValidationErrorTypes GminText_validationStatus { set; }
        Presenter.ValidationErrorTypes GmaxText_validationStatus { set; }
        Presenter.ValidationErrorTypes BminText_validationStatus { set; }
        Presenter.ValidationErrorTypes BmaxText_validationStatus { set; }

        Color RightPixColor { get; set; }    //цвет закраски подходящих пикселей

        Color WrongPixColor { get; set; }       //цвет закраски НЕподходящих пикселей
    }
}
