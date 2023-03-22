namespace GameClassLibrary
{
    public static class Diagnose
    {
        //Initialization and methods

        public static string Calculate(double percentRightAnsweres)
        {
            if (percentRightAnsweres == 0) return "Кретин";
            if (percentRightAnsweres <= 0.25) return "Идиот";
            if (percentRightAnsweres <= 0.50) return "Дурак";
            if (percentRightAnsweres <= 0.75) return "Нормальный";
            if (percentRightAnsweres < 1) return "Талант";
            if (percentRightAnsweres == 1) return "Гений";
            else return "Такого результата просто не может быть";
        }
        public static string GetBestDiagnosed(string oldDiagnosed, string newDiagnosed)
        {
            var diagnosed = new[] { "Кретин", "Идиот", "Дурак", "Нормальный", "Талант", "Гений" };

            int oldIndex = Array.FindIndex(diagnosed, x => x.Equals(oldDiagnosed));
            int newIndex = Array.FindIndex(diagnosed, x => x.Equals(newDiagnosed));

            return diagnosed[Math.Max(oldIndex, newIndex)];
        }
    }
}
