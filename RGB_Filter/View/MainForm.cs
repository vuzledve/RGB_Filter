using RGB_Filter.Presenter;

namespace RGB_Filter.View
{
    public partial class MainForm : Form, IRGB_FilterView
    {
        private Bitmap _canvas;                         //картинка
        private Bitmap _filtredCanvas;                  //картинка с фильтраим

        private bool isNotFiltredCanvasShow = true;
        public MainForm()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            Application.Run(this);
        }

        public Bitmap Canvas
        {

            set
            {
                _canvas?.Dispose();
                _canvas = value;
                SetCanvasPicture();
            }
        }
        public Bitmap FiltredCanvas
        {
            set
            {
                _filtredCanvas?.Dispose();
                _filtredCanvas = value;
                SetCanvasPicture();
            }
        }

        public string CutStartX { get => Start_X_textBoxCanvas.Text; set => Start_X_textBoxCanvas.Text = value; }
        public string CutStartY { get => Start_Y_textBoxCanvas.Text; set => Start_Y_textBoxCanvas.Text = value; }
        public string CutSizeX { get => Size_X_textBoxCanvas.Text; set => Size_X_textBoxCanvas.Text = value; }
        public string CutSizeY { get => Size_Y_textBoxCanvas.Text; set => Size_Y_textBoxCanvas.Text = value; }
        public ValidationErrorTypes CutStartX_validationStatus { set => Start_X_textBoxCanvas.BackColor = GetErrorColor(value); }
        public ValidationErrorTypes CutStartY_validationStatus { set => Start_Y_textBoxCanvas.BackColor = GetErrorColor(value); }
        public ValidationErrorTypes CutSizeX_validationStatus { set => Size_X_textBoxCanvas.BackColor = GetErrorColor(value); }
        public ValidationErrorTypes CutSizeY_validationStatus { set => Size_Y_textBoxCanvas.BackColor = GetErrorColor(value); }

        public string RminText { get => searchR_checkBox.Checked ? Rmin_textBox.Text : "0"; set => Rmin_textBox.Text = value; }
        public string RmaxText { get => searchR_checkBox.Checked ? Rmax_textBox.Text : "0"; set => Rmax_textBox.Text = value; }
        public string GminText { get => searchG_checkBox.Checked ? Gmin_textBox.Text : "0"; set => Gmin_textBox.Text = value; }
        public string GmaxText { get => searchG_checkBox.Checked ? Gmax_textBox.Text : "0"; set => Gmax_textBox.Text = value; }
        public string BminText { get => searchB_checkBox.Checked ? Bmin_textBox.Text : "0"; set => Bmin_textBox.Text = value; }
        public string BmaxText { get => searchB_checkBox.Checked ? Bmax_textBox.Text : "0"; set => Bmax_textBox.Text = value; }
        public ValidationErrorTypes RminText_validationStatus { set => Rmin_textBox.BackColor = GetErrorColor(value); }
        public ValidationErrorTypes RmaxText_validationStatus { set => Rmax_textBox.BackColor = GetErrorColor(value); }
        public ValidationErrorTypes GminText_validationStatus { set => Gmin_textBox.BackColor = GetErrorColor(value); }
        public ValidationErrorTypes GmaxText_validationStatus { set => Gmax_textBox.BackColor = GetErrorColor(value); }
        public ValidationErrorTypes BminText_validationStatus { set => Bmin_textBox.BackColor = GetErrorColor(value); }
        public ValidationErrorTypes BmaxText_validationStatus { set => Bmax_textBox.BackColor = GetErrorColor(value); }
        public Color RightPixColor { get => rightPixelColor_button.BackColor; set => rightPixelColor_button.BackColor = value; }
        public Color WrongPixColor { get => wrongPixelColor_button.BackColor; set => wrongPixelColor_button.BackColor = value; }

        public event Action SetCanvasFromModel;
        public event Action SetFiltredCanvasFromModel;
        public event Action<string> SetCanvasFromFile;
        public event Action SetCanvasFromScreen;
        public event Action CutCanvas;
        public event Func<bool> CutCanvasValidate;
        public event Action FilterCanvas;
        public event Func<bool> FilterCanvasValidate;
        public event Action SaveToDB;

        public event Action<Point, Point> PaintFrameOnCanvas;
        public event Action<Point, Point> PaintFrameOnFiltredCanvas;

        private void Apply_button_Click(object sender, EventArgs e)
        {
            FilterCanvas.Invoke();
        }

        #region Validate
        private void FilterCanvas_DataChanged(object sender, EventArgs e)
        {
            FilterCanvasValidate.Invoke();
        }

        private void cutPicture_DataChanged(object sender, EventArgs e)
        {
            CutCanvasValidate.Invoke();
        }


        /* Получение цвета на основании типа ошибки */
        private static Color GetErrorColor(ValidationErrorTypes type)
        {
            switch (type)
            {
                case ValidationErrorTypes.AllOK:
                    return Color.LightGreen;

                case ValidationErrorTypes.WrongInput:
                    return Color.LightCoral;

                case ValidationErrorTypes.BorderOut:
                    return Color.LightPink;

                case ValidationErrorTypes.WrongRelation:
                    return Color.Orange;

                case ValidationErrorTypes.WrongSum:
                    return Color.Orange;

                case ValidationErrorTypes.NotEnoughData:
                    return Color.Aqua;

                default:
                    throw new Exception("invalid errorType");
            }
        }
        #endregion

        private void SetSimpleCanvas_button_Click(object sender, EventArgs e)
        {
            isNotFiltredCanvasShow = true;
            SetCanvasPicture();
        }

        private void SetFiltredCanvas_button_Click(object sender, EventArgs e)
        {
            isNotFiltredCanvasShow = false;
            SetCanvasPicture();
        }

        private void TakeScreenshot_ButtonCanvas_Click(object sender, EventArgs e)
        {
            SetCanvasFromScreen.Invoke();
            SetCanvasPicture();
        }

        private void GetFromFile_ButtonCanvas_Click(object sender, EventArgs e)
        {
            if (GetPicture_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SetCanvasFromFile.Invoke(GetPicture_openFileDialog.FileName);
                SetCanvasPicture();
            }
        }

        private void cutPicture_buttonCanvas_Click(object sender, EventArgs e)
        {
            CutCanvas.Invoke();
            SetCanvasPicture();
        }

        private void rightPixelColor_button_Click(object sender, EventArgs e)
        {
            if (rightPixelColor_colorDialog.ShowDialog() == DialogResult.OK)
                rightPixelColor_button.BackColor = rightPixelColor_colorDialog.Color;
        }

        private void wrongPixelColor_button_Click(object sender, EventArgs e)
        {
            if (wrongPixelColor_colorDialog.ShowDialog() == DialogResult.OK)
                wrongPixelColor_button.BackColor = wrongPixelColor_colorDialog.Color;
        }



        private void SetCanvasPicture()
        {
           // canvas_pictureBox.Image?.Dispose();

            if (isNotFiltredCanvasShow)
                canvas_pictureBox.Image = _canvas;
            else
                canvas_pictureBox.Image = _filtredCanvas;
        }
    }
}