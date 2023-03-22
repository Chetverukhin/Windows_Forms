using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BallClassLibrary
{
    internal class MoveBall : RandomSizeAndPointBall
    {
        private Timer timer;
        public MoveBall(Panel panelGame) : base(panelGame)
        {
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
    }
}
