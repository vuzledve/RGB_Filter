using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
namespace RGB_Filter.Presenter
{
    internal class PropValidationDelegates
    {
        public Func<string> textGetter;
        public Action<ValidationErrorTypes> errorSetter;
        public PropValidationDelegates(Func<string> textGetter, Action<ValidationErrorTypes> colorSetter)
        {
            this.textGetter = textGetter;
            this.errorSetter = colorSetter;
        }
    }
}
