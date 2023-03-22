using Newtonsoft.Json;

namespace GameClassLibrary
{
    public class Game
    {
        private readonly string detailsUsersFile = "details_data.json";
        private readonly string summaryUsersFile = "summary_data.json";
        private readonly string archiveTestsFile = "test_data.json";

        public User user;

        private List<Test> currentSetTests;
        private Test currentTest;

        private StorageTests storageTests;
        private StorageResults storageResults;  
        
        private int rightAnswers;
        private int counter;
        public Game(User user)
        {
            this.user = user;
        }
        public void PrepareSources()
        {
            ProgramFile files = new();

            var detailsUsersData = ProgramFile.Read(detailsUsersFile);
            var summaryUsersData = ProgramFile.Read(summaryUsersFile);
            var archiveTestsData = ProgramFile.Read(archiveTestsFile);

            storageTests = new(archiveTestsData);
            storageResults = new(detailsUsersData, summaryUsersData);
        }
        public void Save()
        {
            ProgramFile.Save(detailsUsersFile, JsonConvert.SerializeObject(storageResults.Details, Formatting.Indented));
            ProgramFile.Save(summaryUsersFile, JsonConvert.SerializeObject(storageResults.Summary, Formatting.Indented));
            ProgramFile.Save(archiveTestsFile, JsonConvert.SerializeObject(storageTests.Data, Formatting.Indented));
        }
        public void SaveUserResults(User newUser)
        {
            newUser.SetResults(currentSetTests.Count, rightAnswers);
            storageResults.AddResults(newUser);
        }
        public void Start()
        {
            rightAnswers = 0;
            counter = 0;
            currentSetTests = storageTests.GetSetTest(storageTests.Length);
        }
        public bool End()
        {
            return counter == currentSetTests.Count;
        }
        public Test GetNextTest()
        {
            currentTest = (currentSetTests[counter]);
            return currentTest;
        }
        public string GetNumberTest(bool startFirst)
        {
            if (startFirst)
            {
                return $"Вопрос № {counter + 1}";
            }
            else
            {
                return $"Вопрос № {counter}";
            }
        }
        public void AcceptAnswer(int userAnswer)
        {
            if (userAnswer == currentTest.Answer)
            {
                rightAnswers++;
            }
            counter++;
        }
        public List<User> GetDetailsResults()
        {
            return storageResults.Details;
        }
        public List<User> GetSummaryResults()
        {
            var summaryResults = storageResults.Summary.OrderByDescending(x => x.PercentRightAnswers)
                                                       .ThenByDescending(x => x.QuantityPassedTests)
                                                       .ToList();
            return summaryResults;
        }
        public List<Test> GetTestsData()
        {
            return storageTests.Data;
        }
        public void AddTest(Test test)
        {
            storageTests.Add(test);
        }
        public void DelTest(int testNUmber)
        {
            storageTests.Delete(testNUmber);
        }
        public int GetQuantityRightAnswers()
        {
            return rightAnswers;
        }
        public void ClearAllResults()
        {
            storageResults.ClearResults();
        }
    }
}
