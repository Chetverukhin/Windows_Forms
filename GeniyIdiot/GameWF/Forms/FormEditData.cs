using GameClassLibrary;

namespace GameWF.Forms
{
    public partial class FormEditData : Form
    {
        private Game game;
        private readonly string[] testsLable = { "№", "Тестовый вопрос" };

        public FormEditData(Game game)
        {
            this.game = game;

            InitializeComponent();

            ShowAllTestsQuestions();
        }
        private void ShowAllTestsQuestions()
        {
            TableResults.ShowResults(game.GetTestsData(), testsLable, dataGridTestQuestion);
        }
        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            var correctText = Check.UserText(textBoxAddQuestion.Text, out string userQuestion, out string errorText);
            var correctNUmb = Check.UserNumber(textBoxAddAnswer.Text, out int userAnswer, out string errorNumb);

            if (!correctText)
            {
                MessageBox.Show(errorText, "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddQuestion.Clear();
                textBoxAddQuestion.Focus();
            }
            if (!correctNUmb)
            {
                MessageBox.Show(errorNumb, "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddAnswer.Clear();
                textBoxAddAnswer.Focus();
            }
            if (correctText && correctNUmb)
            {
                game.AddTest(new(textBoxAddQuestion.Text, int.Parse(textBoxAddAnswer.Text)));

                textBoxAddQuestion.Clear();
                textBoxAddAnswer.Clear();

                ShowAllTestsQuestions();
            }
        }
        private void buttonDelTest_Click(object sender, EventArgs e)
        {
            int minNumber = StorageTests.GetDefaultTests().Count - 1;
            int maxNumber = game.GetTestsData().Count - 1;
            int correctNumber;

            if (!Check.UserChoiceDeleteTest(dataGridTestQuestion.CurrentRow.Index, minNumber, maxNumber, out correctNumber, out string errorText))
            {
                MessageBox.Show(errorText, "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                game.DelTest(correctNumber);
                ShowAllTestsQuestions();
            }
        }
        private void textBoxAddQuestion_Click(object sender, EventArgs e)
        {
            textBoxAddQuestion.Text = null;
            textBoxAddQuestion.ForeColor = Color.Black;
        }
        private void textBoxAddAnswer_Click(object sender, EventArgs e)
        {
            textBoxAddAnswer.Text = null;
            textBoxAddAnswer.ForeColor = Color.Black;
        }
    }
}
