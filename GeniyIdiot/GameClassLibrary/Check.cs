namespace GameClassLibrary
{
    public static class Check
    {
        //Initialization and methods

        public static bool UserText(string input, out string text, out string alertError)
        {
            if (input == string.Empty)
            {
                text = string.Empty;
                alertError = "Вы ввели пустое значение";
                return false;
            }
            else
            {
                try
                {
                    double.Parse(input);
                    text = string.Empty;
                    alertError = "Вы ввели число";
                    return false;
                }
                catch
                {
                    text = input;
                    alertError = string.Empty;
                    return true;
                }
            }
        }
        public static bool UserNumber(string input, out int number, out string alertError)
        {
            if (input == string.Empty)
            {
                number = 0;
                alertError = "Вы ввели пустое значение";
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
                        alertError = "Вы ввели слишком большое число";
                        return false;
                    }
                    if (checkNumber <= int.MinValue)
                    {
                        number = 0;
                        alertError = "Вы ввели слишком маленькое число";
                        return false;
                    }
                    else
                    {
                        number = int.Parse(input);
                        alertError = string.Empty;
                        return true;
                    }
                }
                catch
                {
                    number = 0;
                    alertError = "Вы ввели не число";
                    return false;
                }
            }
        }
        public static bool UserChoiceDeleteTest(int userNumber, int minNumber, int maxNumber, out int correctNumber, out string alertError)
        {
            if (userNumber <= minNumber)
            {
                correctNumber = 0;
                alertError = "Первые 5 тестов удалять нельзя";
                return false;
            }
            if (userNumber > maxNumber)
            {
                correctNumber = 0;
                alertError = "Вы выбрали не существующий тест";
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
