using Newtonsoft.Json;

namespace GameClassLibrary
{
    public class ProgramFile
    {
        private static string pathFile = Path.Combine(Environment.CurrentDirectory, "game_scores.json");

        public static string Read()
        {
            if (!File.Exists(pathFile))
            {
                File.Create(pathFile).Close();
            }
            return File.ReadAllText(pathFile);
        }
        public static void Save(List<User> gameData)
        {
            File.WriteAllText(pathFile, JsonConvert.SerializeObject(gameData, Formatting.Indented));
        }
    }
}
