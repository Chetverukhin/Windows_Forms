using BallClassLibrary;

namespace BallGameV2
{
    public partial class GameForm : Form
    {
        private Game game;
        public GameForm()
        {
            InitializeComponent();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            game = new Game(panelGame, 10);
            buttonStart.Enabled = false;
            labelScores.Text = "0";

            panelGame.Invalidate();
            panelGame.Update();

            game.Play();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;

            game.Stop(true);

            MessageBox.Show($"Игра окончена! Вы поймали {game.caughtBalls} шариков", "Поздравляем", MessageBoxButtons.OK);
        }
        private void panelGame_MouseDown(object sender, MouseEventArgs args)
        {
            game.Cathing(args);
            labelScores.Text = game.caughtBalls.ToString();
        }
    }
}