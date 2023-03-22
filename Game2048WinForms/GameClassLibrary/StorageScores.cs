using Newtonsoft.Json;

namespace GameClassLibrary
{
    public class StorageScores
    {
        public static List<User> Scores;
        public static void ReadDataScores(string gameScores)
        {
            if (gameScores == String.Empty)
            {
                Scores = new();
            }
            else
            {
                Scores = JsonConvert.DeserializeObject<List<User>>(gameScores);
            }
        }
        public static void Add(User newUserScores)
        {
            Scores.Add(newUserScores);
        }
        public static void Clear()
        {
            Scores.Clear();
        }
        public static int GetBestScores()
        {
            try
            {
                return Scores.Max(user => user.Scores);
            }
            catch
            {
                return 0;
            }
        }
    }
}
