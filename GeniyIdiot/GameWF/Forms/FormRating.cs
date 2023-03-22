using GameClassLibrary;

namespace GameWF.Forms
{
    public partial class FormRating : Form
    {
        private Game game;
        private readonly string[] resultsLable = { "№",
                                          "Имя студента",
                                          "Количество пройденных тестов",
                                          "Количество правильных ответов",
                                          "Процент правильных ответов",
                                          "Диагноз" };
        public FormRating(Game game)
        {
            this.game = game;


            InitializeComponent();
            TableResults.ShowResults(game.GetSummaryResults(), resultsLable, dataGridTop);
        }
    }
}
