
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Filter.View
{
    internal interface ICutCanvas
    {
        event Action CutCanvas; //Restangle
        event Func<bool> CutCanvasValidate;
        string CutStartX { get; set; }
        string CutStartY { get; set; }
        string CutSizeX { get; set; }
        string CutSizeY { get; set; }

        Presenter.ValidationErrorTypes CutStartX_validationStatus { set; }
        Presenter.ValidationErrorTypes CutStartY_validationStatus { set; }
        Presenter.ValidationErrorTypes CutSizeX_validationStatus { set; }
        Presenter.ValidationErrorTypes CutSizeY_validationStatus { set; }
    }
}
