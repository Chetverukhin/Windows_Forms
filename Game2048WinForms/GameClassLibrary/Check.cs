namespace GameClassLibrary
{
    public class Check
    {
        public static bool UserText(string input, out string text, out string errorText)
        {
            if (input == string.Empty)
            {
                text = string.Empty;
                errorText = "Вы ввели пустое значение";
                return false;
            }
            else
            {
                try
                {
                    double.Parse(input);
                    text = string.Empty;
                    errorText = "Вы ввели число";
                    return false;
                }
                catch
                {
                    text = input;
                    errorText = string.Empty;
                    return true;
                }
            }
        }
        public static bool UserNumber(string input, out int number, out string errorText)
        {
            if (input == string.Empty)
            {
                number = 0;
                errorText = "Вы ввели пустое значение";
                return false;
            }
            else
            {
                try
                {
                    double checkNumber = double.Parse(input);

                    if (checkNumber >= int.MaxValue)
                    {
                        number = 0;
                        errorText = "Вы ввели слишком большое число";
                        return false;
                    }
                    if (checkNumber <= int.MinValue)
                    {
                        number = 0;
                        errorText = "Вы ввели слишком маленькое число";
                        return false;
                    }
                    else
                    {
                        number = int.Parse(input);
                        errorText = string.Empty;
                        return true;
                    }
                }
                catch
                {
                    number = 0;
                    errorText = "Вы ввели не число";
                    return false;
                }
            }
        }
        public static bool UserChoiceMapStyle(int userNumber, int maxNumber, int minNumber ,out int correctNumber, out string alertError)
        {
            if (userNumber < minNumber)
            {
                correctNumber = 0;
                alertError = "Число меньше разрешенного минимального значения";
                return false;
            }
            if (userNumber > maxNumber)
            {
                correctNumber = 0;
                alertError = "Число больше разрешенного максимального значения";
                return false;
            }
            else
            {
                correctNumber = userNumber;
                alertError = "";
                return true;
            }
        }
    }
}
