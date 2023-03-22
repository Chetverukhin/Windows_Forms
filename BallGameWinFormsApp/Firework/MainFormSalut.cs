using BallClassLibrary;

namespace Firework
{
    public partial class MainFormSalut : Form
    {
        public MainFormSalut()
        {
            InitializeComponent();
        }
        private void panelFirework_MouseDown(object sender, MouseEventArgs e)
        {
            Explosive(e.X, e.Y);
        }
        private void ArrowBall_ReachZenit(object? sender, HitEventArgs e)
        {
            var arrow = (ArrowBall)sender;
            Explosive(arrow.GetCenterX(),arrow.GetCenterY());
        }
        private void Explosive(float X, float Y)
        {
            var random = new Random();
            var ballsNumber = random.Next(5, 11);

            for (int i = 0; i < ballsNumber; i++)
            {
                var ball = new FireworkBall(panelFirework, X, Y);
                ball.Start();
            }
        }
        private void timerLaunch_Tick(object sender, EventArgs e)
        {
            LaunchArrow();
        }
        private void LaunchArrow()
        {
            var arrowBall = new ArrowBall(panelFirework);
            arrowBall.Start();
            arrowBall.ReachZenit += ArrowBall_ReachZenit;
        }
    }
}