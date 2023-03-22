using GameClassLibrary;

namespace Game2048WinForms
{
    public partial class FormScores : Form
    {
        private readonly string[] resultsLable = { "№",
                                          "Имя игрока",
                                          "Количество очков"};
        public FormScores()
        {
            InitializeComponent();
            TableResults.ShowResults(StorageScores.Scores, resultsLable, dataGridScores);
        }
    }
}
