using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Filter.Presenter
{
    public enum ValidationErrorTypes
    {
        AllOK,          //все ок
        WrongInput,     //не преобразовывается в нужный формат (в инт)
        BorderOut,      //меньше минимального возможного или больше макс возможного
        WrongRelation,  //у 2 полей если минимум больше максимума
        WrongSum,        //у 2 полей если val1 + val2 > максимально допустимое значение
        NotEnoughData   //недостаточно данных для валидации
    }
}
