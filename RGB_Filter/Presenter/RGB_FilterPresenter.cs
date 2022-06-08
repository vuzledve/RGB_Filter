using RGB_Filter.Model;
using RGB_Filter.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RGB_Filter.Presenter
{
    internal class RGB_FilterPresenter 
    {
        public void Run()
        {
            _view.Show();
        }

        private readonly IRGB_FilterView _view;
        private readonly IRGB_FilterModel _model;
        private bool needValidateDataFilterTab = true;  //необходимо ли валидировать данные с закладки "Filter"
        private bool needValidateDataCanvasTab = true;  //необходимо ли валидировать данные с закладки "Canvas"

        public RGB_FilterPresenter(IRGB_FilterView view, IRGB_FilterModel model)
        {
            _view = view;
            _model = model;

            SubscribeViewToModelEvents();
            SubscribeToViewEvents();

            SetDefaultValues();
            _view.Canvas = _model.Canvas;
        }

        private void SubscribeViewToModelEvents()
        {
            _model.NewCanvasSetted += () =>
            {
                _view.Canvas = _model.Canvas;
                _view.FiltredCanvas = _model.FiltredCanvas;
            };
            _model.NewFiltredCanvasSetted += () => _view.FiltredCanvas = _model.FiltredCanvas;
        }
        private void SubscribeToViewEvents()
        {
            _view.SetCanvasFromFile += this.SetCanvasFromFile;
            _view.SetCanvasFromScreen += this.SetCanvasFromScreen;
            _view.CutCanvas += this.CutCanvas;
            _view.CutCanvasValidate += ()=> this.ValidateICutCanvas();
            _view.SetCanvasFromModel += GetCanvas;         //получить картинку из модели
            _view.SetFiltredCanvasFromModel += GetFiltredCanvas;  //получить отфильтрованную картинку из модели

            _view.FilterCanvas += this.FilterCanvas;
            _view.FilterCanvasValidate += () => this.ValidateIBoolMatrixGetter();

    }
        private void SetDefaultValues()
        {
            needValidateDataCanvasTab = false;
            _view.CutStartX = "0";
            _view.CutStartY = "0";
            _view.CutSizeX = _model.Canvas.Width.ToString();
            _view.CutSizeY = _model.Canvas.Height.ToString();
            needValidateDataCanvasTab = true;
            ValidateICutCanvas();

            needValidateDataFilterTab = false;
            _view.RminText = _model.Rmin.ToString();
            _view.RmaxText = _model.Rmax.ToString();
            _view.GminText = _model.Gmin.ToString();
            _view.GmaxText = _model.Gmax.ToString();
            _view.BminText = _model.Bmin.ToString();
            _view.BmaxText = _model.Bmax.ToString();
            _view.RightPixColor = _model.RightPix;
            _view.WrongPixColor = _model.WrongPix;
            needValidateDataFilterTab = true;
            ValidateIBoolMatrixGetter();

            FilterCanvas();
        }


        public void SetCanvasFromFile(string path)
        {
            _model.SetCanvasFromFile(path);
        }
      
        public void SetCanvasFromScreen()
        {
            _model.SetCanvasFromScreen();
        }

        public void CutCanvas()
        {
            if (ValidateICutCanvas())
                _model.CutCanvas(Convert.ToInt32(_view.CutStartX), Convert.ToInt32(_view.CutStartY), Convert.ToInt32(_view.CutSizeX), Convert.ToInt32(_view.CutSizeY));
        }

        public void FilterCanvas()
        {
            if (ValidateIBoolMatrixGetter())
            {
                _model.SetFilterParam(Convert.ToByte(_view.RminText), Convert.ToByte(_view.RmaxText), Convert.ToByte(_view.GminText), Convert.ToByte(_view.GmaxText), Convert.ToByte(_view.BminText), Convert.ToByte(_view.BmaxText));
                _model.SetFilterColors(_view.RightPixColor, _view.WrongPixColor);
                _model.FilterCanvas();
            }
        }


        public void GetCanvas()
        {
            _view.Canvas = _model.Canvas;
        }
        public void GetFiltredCanvas()
        {
            _view.FiltredCanvas = _model.FiltredCanvas;
        }




        ///////////////////////////////////////////////////////////////////
        ///                                                             /// 
        ///                     Data validation                         ///
        ///                                                             ///
        ///////////////////////////////////////////////////////////////////

        //валидация значений при обрезке изображения
        public bool ValidateICutCanvas()
        {
            if (needValidateDataCanvasTab)
            {
                if (_model.Canvas != null)
                {
                    Size canvasSize = _model.Canvas.Size;
                    PropValidationDelegates startX = new PropValidationDelegates(() => _view.CutStartX, (value) => _view.CutStartX_validationStatus = value);
                    PropValidationDelegates startY = new PropValidationDelegates(() => _view.CutStartY, (value) => _view.CutStartY_validationStatus = value);
                    PropValidationDelegates sizeX = new PropValidationDelegates(() => _view.CutSizeX, (value) => _view.CutSizeX_validationStatus = value);
                    PropValidationDelegates sizeY = new PropValidationDelegates(() => _view.CutSizeY, (value) => _view.CutSizeY_validationStatus = value);

                    return ValidationMethods.SetValidationStatusNewPictureInFrame(canvasSize, startX, startY, sizeX, sizeY);
                }
                else
                {
                    _view.CutStartX_validationStatus = ValidationErrorTypes.NotEnoughData;
                    _view.CutStartY_validationStatus = ValidationErrorTypes.NotEnoughData;
                    _view.CutSizeX_validationStatus = ValidationErrorTypes.NotEnoughData;
                    _view.CutSizeY_validationStatus = ValidationErrorTypes.NotEnoughData;

                    return false;
                }
            }
            return true;
        }

        public bool ValidateIBoolMatrixGetter()
        {
            if (needValidateDataFilterTab)
            {
                PropValidationDelegates Rmin = new PropValidationDelegates(() => _view.RminText, (value) => _view.RminText_validationStatus = value);
                PropValidationDelegates Rmax = new PropValidationDelegates(() => _view.RmaxText, (value) => _view.RmaxText_validationStatus = value);
                bool RFine = ValidationMethods.SetValidationStatusColorTwoBorders(Rmin, Rmax);

                PropValidationDelegates Gmin = new PropValidationDelegates(() => _view.GminText, (value) => _view.GminText_validationStatus = value);
                PropValidationDelegates Gmax = new PropValidationDelegates(() => _view.GmaxText, (value) => _view.GmaxText_validationStatus = value);
                bool GFine = ValidationMethods.SetValidationStatusColorTwoBorders(Gmin, Gmax);

                PropValidationDelegates Bmin = new PropValidationDelegates(() => _view.BminText, (value) => _view.BminText_validationStatus = value);
                PropValidationDelegates Bmax = new PropValidationDelegates(() => _view.BmaxText, (value) => _view.BmaxText_validationStatus = value);
                bool BFine = ValidationMethods.SetValidationStatusColorTwoBorders(Bmin, Bmax);

                return (RFine && GFine && BFine);
            }
            return true;
        }


    }
}
