using GameClassLibrary;

namespace Game2048WinForms
{
    public partial class FormMain : Form
    {
        private Game game;
        private Form activeForm;
        public FormMain(Game game)
        {
            InitializeComponent();
            this.game = game;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                FormMain_KeyDown(this, new KeyEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ShowGameMenu(Form currentForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            game.Reset(panelGame);
            labelUserScore.Text = game.user.Scores.ToString();
            buttonGame.Enabled = true;
            buttonResetGame.Visible = false;

            activeForm = currentForm;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(currentForm);
            this.panelMain.Tag = currentForm;
            currentForm.BringToFront();
            currentForm.Show();

        }
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            var gameEnd = game.End();

            if (gameEnd)
            {
                game.SaveScores(game.user);

                DialogResult result = MessageBox.Show($"{game.user.Name} Ваш диагноз: {game.user.Scores}" +
                                                      $"\nповторить игру?", "Результат игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    game.PrepareCellsMap(panelGame);
                }
                else
                {
                    buttonGame.Enabled = true;
                    game.Reset(panelGame);
                }
            }
            if (activeForm == null && !gameEnd)
            {
                game.Play(e);
                game.NewRecord(game.user.Scores);
            }
            labelBestScore.Text = game.BestScores.ToString();
            labelUserScore.Text = game.user.Scores.ToString();
        }
        private void buttonGame_Click(object sender, EventArgs e)
        {
            buttonGame.Enabled = false;
            buttonResetGame.Visible = true;
            activeForm = null;

            game.PrepareCellsMap(panelGame);
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ShowGameMenu(new FormSettings());
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            ShowGameMenu(new FormInfo());
        }
        private void buttonScores_Click(object sender, EventArgs e)
        {
            ShowGameMenu(new FormScores());
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            game.Save();
            Application.Exit();
        }
        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            if (game.user.Scores != 0)
            {
                game.SaveScores(game.user);
            }

            activeForm = null;
            buttonGame.Enabled = false;
            game.PrepareCellsMap(panelGame);

            labelUserScore.Text = game.user.Scores.ToString();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            labelTextUserName.Text = game.user.Name;
            labelBestScore.Text = StorageScores.GetBestScores().ToString();
        }
    }
}