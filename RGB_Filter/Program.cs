using RGB_Filter.Model;
using RGB_Filter.Presenter;
using RGB_Filter.View;

namespace RGB_Filter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new RGB_FilterPresenter(new MainForm(), new RGB_FilterModel()); 
            presenter.Run();
        }
    }
}