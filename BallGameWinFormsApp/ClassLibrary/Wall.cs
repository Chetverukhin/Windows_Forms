using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Wall
    {
        private Point point;
        private Point center;
        private Size size;
        private Brush color = Brushes.Black;

        private float distanceX;
        private float distanceY;

        private Bird bird;
        private Panel panelGame;
        private Random random = new Random();
        private Timer timer;

        public event EventHandler<HitEventArgs> Strike;

        public Wall(Panel panelGame, Bird bird)
        {
            this.panelGame = panelGame;
            this.bird = bird;

            SetWallSize();
            GetCenterDictance();
            GetCenterPoint();

            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }
        public Point GetPoint()
        {
            return point;
        }
        public Size GetSize()
        {
            return size;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Draw(color);

            if (Math.Abs(center.X - bird.GetCenterX()) < distanceX &&
                Math.Abs(center.Y - bird.GetCenterY()) < distanceY)
            {
                if (bird.GetCenterX() < point.X)
                {
                    Strike.Invoke(this, new HitEventArgs(Side.Left));
                }
                else
                {
                    if (bird.GetCenterY() < center.Y)
                    {
                        Strike.Invoke(this, new HitEventArgs(Side.Top));
                    }
                    if (bird.GetCenterY() > center.Y)
                    {
                        Strike.Invoke(this, new HitEventArgs(Side.Down));
                    }
                }
            }
        }
        public void Build()
        {
            GetLocationPoint();
            GetCenterPoint();
            timer.Start();
        }
        public void Destroy()
        {
            color = new SolidBrush(panelGame.BackColor);
            Draw(color);
            timer.Stop();
        }
        private void SetWallSize()
        {
            size.Width = 20;
            size.Height = panelGame.Height / 3;
        }
        private void GetLocationPoint()
        {
            point.X = panelGame.Width / 2 - size.Width * 2;
            point.Y = random.Next(0, panelGame.Height - size.Height);
        }
        private void GetCenterDictance()
        {
            distanceX = bird.GetRadius() + size.Width / 2;
            distanceY = bird.GetRadius() + size.Height / 2;
        }
        private void GetCenterPoint()
        {
            center.X = point.X + size.Width / 2;
            center.Y = point.Y + size.Height / 2;
        }
        protected void Draw(Brush brush)
        {
            var graphics = panelGame.CreateGraphics();
            var rectangle = new Rectangle(point, size);
            graphics.FillRectangle(brush, rectangle);
        }
    }
}
