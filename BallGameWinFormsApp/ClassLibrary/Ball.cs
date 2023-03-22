using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Ball
    {
        protected Panel panelGame;
        private Timer timer;
        protected Brush brush = Brushes.MediumSeaGreen;

        protected float velocityX = 1;
        protected float velocityY = 1;

        protected float centerX;
        protected float centerY;
        protected int radius = 25;

        public event EventHandler<TouchEventArgs> Catch;
        protected Touch Touch = Touch.Stop;
        public Ball(Panel panelGame)
        {
            this.panelGame = panelGame;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public void SetColor(Brush brush)
        {
            Draw(brush);
        }
        public bool InMotion()
        {
            return timer.Enabled;
        }
        public void Move()
        {
            Draw(new SolidBrush(panelGame.BackColor));
            Go();
            Draw(brush);
        }
        public float GetRadius()
        {
            return radius;
        }
        public float GetCenterX()
        {
            return centerX;
        }
        public float GetCenterY()
        {
            return centerY;
        }
        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return panelGame.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return panelGame.Height - radius;
        }
        public bool OnWindow()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }
        public virtual bool Сaught(MouseEventArgs e)
        {
            var legX = e.X - centerX;
            var legY = e.Y - centerY;

            var ballsIsCaught = legX * legX + legY * legY <= radius * radius; ;

            if (ballsIsCaught)
            {
                Catch.Invoke(this, new TouchEventArgs(Touch));
            }
            return ballsIsCaught;
        }
        protected virtual void Go()
        {
            centerX += velocityX;
            centerY += velocityY;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        protected void Draw(Brush brush)
        {
            var graphics = panelGame.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectangle);
        }
        public void Clear()
        {
            Stop();
            Draw(new SolidBrush(panelGame.BackColor));
        }
    }
}
