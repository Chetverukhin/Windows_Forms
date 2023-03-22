using BallClassLibrary;
namespace BilliardGame
{
    public partial class BilliardForm : Form
    {
        private int ballsNumber = 10;
        public BilliardForm()
        {
            InitializeComponent();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ballsNumber; i++)
            {
                var ball = new BilliardBall(panelGame);
                ball.Strike += Ball_Strike;
                ball.Start();
            }
        }
        private void Ball_Strike(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    labelLeft.Text = (int.Parse(labelLeft.Text) + 1).ToString();
                    break;
                case Side.Right:
                    labelRight.Text = (int.Parse(labelRight.Text) + 1).ToString();
                    break;
                case Side.Top:
                    labelTop.Text = (int.Parse(labelTop.Text) + 1).ToString();
                    break;
                case Side.Down:
                    labelDown.Text = (int.Parse(labelDown.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}