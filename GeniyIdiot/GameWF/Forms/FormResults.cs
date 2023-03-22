using GameClassLibrary;

namespace GameWF.Forms
{
    public partial class FormResults : Form
    {
        private Game game;
        private readonly string[] resultsLable = { "№",
                                          "Имя студента",
                                          "Количество пройденных тестов",
                                          "Количество правильных ответов",
                                          "Процент правильных ответов",
                                          "Диагноз" };
        public FormResults(Game game)
        {
            this.game = game;

            InitializeComponent();
            TableResults.ShowResults(game.GetDetailsResults(), resultsLable, dataGridResullts);
        }
    }
}
