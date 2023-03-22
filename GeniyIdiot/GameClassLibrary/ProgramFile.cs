namespace GameClassLibrary
{
    public class ProgramFile
    {
        //Fields

        readonly string detailsUsersFile = "details_data.json";
        readonly string summaryUsersFile = "summary_data.json";
        readonly string archiveTestsFile = "test_data.json";

        //Initialization and methods

        public ProgramFile()
        {
            string[] fileNames = { detailsUsersFile , summaryUsersFile , archiveTestsFile };

            foreach (var name in fileNames)
            {
                var pathFile = Path.Combine(Environment.CurrentDirectory, name);

                if (!File.Exists(pathFile))
                {
                    File.Create(pathFile).Close();
                }
            }
        }
        public static string Read(string fileName)
        {
            var pathFile = Path.Combine(Environment.CurrentDirectory, fileName);

            return File.ReadAllText(pathFile);
        }
        public static void Save(string fileName, string gameData)
        {
            var pathFile = Path.Combine(Environment.CurrentDirectory, fileName);

            File.WriteAllText(pathFile, gameData);
        }
    }
}
