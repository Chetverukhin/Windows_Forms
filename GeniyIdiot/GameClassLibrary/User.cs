namespace GameClassLibrary
{
    public class User
    {
        //Fields

        public string Name;
        public int QuantityPassedTests;
        public int QuantityRightAnswers;
        public double PercentRightAnswers;
        public string Diagnosis;

        //Initialization and methods

        public User(string name)
        {
            Name = name;
        }
        public void SetResults(int quantityPassedTests, int quantityRightAnswers)
        {
            QuantityPassedTests = quantityPassedTests;
            QuantityRightAnswers = quantityRightAnswers;
            PercentRightAnswers = (double)quantityRightAnswers / quantityPassedTests;
            Diagnosis = Diagnose.Calculate(PercentRightAnswers);
        }
    }
}
