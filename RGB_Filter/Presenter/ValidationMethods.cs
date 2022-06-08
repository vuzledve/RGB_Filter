namespace RGB_Filter.Presenter
{
    static internal class ValidationMethods
    {
        static public bool SetValidationStatusNewPictureInFrame(Size basePictureSize, PropValidationDelegates startX, PropValidationDelegates startY, PropValidationDelegates sizeX, PropValidationDelegates sizeY)
        {   
            //могут ли значения в теории является верными (int, не выходят за рамки большого изображения)
            bool StartXFine = SetValidationStatusValueBetweenBorders(startX, 0, basePictureSize.Width - 1);
            bool StartYFine = SetValidationStatusValueBetweenBorders(startY, 0, basePictureSize.Height - 1);
            bool SizeXFine = SetValidationStatusValueBetweenBorders(sizeX, 1, basePictureSize.Width);
            bool SizeYFine = SetValidationStatusValueBetweenBorders(sizeY, 1, basePictureSize.Height);

            
            if (StartXFine && SizeXFine) //если оба значения прошли 1 проверку - проверяем start + size <= max size 
                if (Convert.ToInt32(startX.textGetter()) + Convert.ToInt32(sizeX.textGetter()) > basePictureSize.Width) //если выходят за границы
                {
                    startX.errorSetter(ValidationErrorTypes.WrongSum);
                    sizeX.errorSetter(ValidationErrorTypes.WrongSum);
                }

            if (StartYFine && SizeYFine)
                if (Convert.ToInt32(startY.textGetter()) + Convert.ToInt32(sizeY.textGetter()) > basePictureSize.Height)
                {
                    startY.errorSetter(ValidationErrorTypes.WrongSum);
                    sizeY.errorSetter(ValidationErrorTypes.WrongSum);
                }

            return (StartXFine && StartYFine && SizeXFine && SizeYFine);
        }


        static public bool SetValidationStatusValueBetweenBorders(PropValidationDelegates value, int min, int max)
        {

            if (TryConvertToInt(value.textGetter()))
            {
                int value_int = Convert.ToInt32(value.textGetter());
                if (value_int >= min && value_int <= max)
                {
                    value.errorSetter(ValidationErrorTypes.AllOK);
                    return true;
                }
                else
                {
                    value.errorSetter(ValidationErrorTypes.BorderOut);
                    return false;
                }

            }
            else
            {
                value.errorSetter(ValidationErrorTypes.WrongInput);
                return false;
            }
        }
        static public bool SetValidationStatusColorTwoBorders(PropValidationDelegates min, PropValidationDelegates max)
        {
            bool minFine = SetValidationStatusOneColorPart(min);
            bool maxFine = SetValidationStatusOneColorPart(max);
          
            if (minFine && maxFine)
            {
                //если все в порядке -> проверка отношения
                if (Convert.ToByte(min.textGetter()) > Convert.ToByte(max.textGetter()))
                {
                    min.errorSetter(ValidationErrorTypes.WrongRelation);
                    max.errorSetter(ValidationErrorTypes.WrongRelation);
                    return false;
                }
                return true;
            }
            else
                return false;          
        }

        static private bool SetValidationStatusOneColorPart(PropValidationDelegates value)
        {
            if (TryConvertToInt(value.textGetter()))
            {
                try
                {
                    Convert.ToByte(value.textGetter());
                    value.errorSetter(ValidationErrorTypes.AllOK);
                    return true;
                }
                catch
                {
                    value.errorSetter(ValidationErrorTypes.BorderOut);
                    return false;
                } 
            }
            else
            {
                value.errorSetter(ValidationErrorTypes.WrongInput);
                return false;
            }
        }

        static public bool TryConvertToInt(string data)
        {
            try
            {
                Convert.ToInt32(data);
                return true;
            }
            catch
            {
                return false;
            }
        }    
    }
}
