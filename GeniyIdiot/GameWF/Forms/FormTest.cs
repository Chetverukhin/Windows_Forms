using GameClassLibrary;

namespace GameWF.Forms
{
    public partial class FormTest : Form
    {
        private Game game;
        private Label labelCurrentMenu;
        private int seconds = 10;
        int R = 56;
        int G = 56;
        int B = 56;
        public FormTest(Game game, Label labelCurrentMenu)
        {
            this.labelCurrentMenu = labelCurrentMenu;
            this.game = game;

            InitializeComponent();

            game.Start();

            ShowTest();

            MessageBox.Show("На каждый тест вам будет отведено 10 секунд", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timerCountDown.Enabled = true;
        }
        private void ShowTest()
        {
            var currentTest = game.GetNextTest();
            labelTestNumber.Text = game.GetNumberTest(true);
            labelTestQuestion.Text = currentTest.Question;
        }
        private void buttonAcceptAnswer_Click(object sender, EventArgs e)
        {
            if (Check.UserNumber(textBoxAnswer.Text, out int userAnswer, out string error))
            {
                ManageCountDown(true);
                seconds = 10;
                game.AcceptAnswer(userAnswer);

                if (game.End())
                {
                    timerCountDown.Enabled = false;
                    ManageCountDown(true);

                    User newUser = new(game.user.Name);
                    game.SaveUserResults(newUser);

                    DialogResult result = MessageBox.Show($"{newUser.Name} Ваш диагноз: {newUser.Diagnosis}" +
                                                          $"\nповторить тестирование?", "Результат тестирования", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        game.Start();
                        ShowTest();                        
                        timerCountDown.Enabled = true;
                    }
                    else
                    {
                        labelCurrentMenu.Text = "ГЛАВНАЯ СТРАНИЦА";
                        Close();
                    }
                }
                else
                {
                    ShowTest();
                    textBoxAnswer.Clear();
                    textBoxAnswer.Focus();
                }
            }
            else
            {
                MessageBox.Show(error, "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAnswer.Clear();
                textBoxAnswer.Focus();
            }
        }
        private void textBoxAnswer_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = null;
            textBoxAnswer.ForeColor = Color.Black;
        }
        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            ManageCountDown(false);            
            labelCountDown.Text = seconds--.ToString();

            if (seconds < 0)
            {
                textBoxAnswer.Text = (game.GetNextTest().Answer * -1).ToString();
                buttonAcceptAnswer_Click(sender, EventArgs.Empty);
                ManageCountDown(true);
            }
        }
        private void ManageCountDown(bool propertyReset)
        {
            if (propertyReset)
            {
                textBoxAnswer.ForeColor = Color.Black;
                R = G = B = 56;
                seconds = 10;
            }
            else
            {
                R += 13;
                G += 2;
                B += 2;
                labelCountDown.ForeColor = Color.FromArgb(R, G, B);
            }
        }
    }
}
