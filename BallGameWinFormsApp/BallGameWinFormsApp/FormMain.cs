using BallClassLibrary;

namespace BallGameWinFormsApp
{
    public partial class FormMain : Form
    {
        private Game game;
        public FormMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            game = new Game(panelGame, 10);
            buttonStart.Enabled = false;

            panelGame.Invalidate();
            panelGame.Update();

            game.Play();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            game.Stop(false);

            MessageBox.Show($"Игра окончена! Вы поймали {game.caughtBalls} шариков", "Поздравляем", MessageBoxButtons.OK);
        }
    }
}