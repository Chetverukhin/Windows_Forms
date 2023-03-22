using Newtonsoft.Json;

namespace GameClassLibrary
{
    public class StorageResults
    {
        //Fields

        public List<User> Details;
        public List<User> Summary;

        //Initialization and methods

        public StorageResults(string detailsUsersData, string summaryUsersData)
        {
            if (detailsUsersData == String.Empty || summaryUsersData == String.Empty)
            {
                Details = new();
                Summary = new();
            }
            else
            {
                Details = JsonConvert.DeserializeObject<List<User>>(detailsUsersData);
                Summary = JsonConvert.DeserializeObject<List<User>>(summaryUsersData);
            }
        }
        public void AddResults(User newUserResults)
        {
            User previousUserResults;
            User updatedUserResults = new(newUserResults.Name);

            int index = Summary.FindIndex(0, x => x.Name.Equals(newUserResults.Name));

            if (index != -1)
            {
                previousUserResults = Summary[index];

                int totalPassedTests = previousUserResults.QuantityPassedTests + newUserResults.QuantityPassedTests;
                int totalRightAnswers = previousUserResults.QuantityRightAnswers + newUserResults.QuantityRightAnswers;

                updatedUserResults.SetResults(totalPassedTests, totalRightAnswers);
                updatedUserResults.Diagnosis = Diagnose.GetBestDiagnosed(updatedUserResults.Diagnosis, newUserResults.Diagnosis);

                Summary.RemoveAt(index);
            }
            else
            {
                updatedUserResults = newUserResults;
            }

            Details.Add(newUserResults);
            Summary.Add(updatedUserResults);
        }
        public void ClearResults()
        {
            Details.Clear();
            Summary.Clear();
        }
    }
}
