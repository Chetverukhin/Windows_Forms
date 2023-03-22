using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class ArrowBall : MoveBall
    {
        private float zenit;
        private Brush defaultColor;

        public event EventHandler<HitEventArgs> ReachZenit;

        public ArrowBall(Panel panelGame) : base(panelGame)
        {
            defaultColor = new SolidBrush(panelGame.BackColor);
            var random = new Random();
            zenit = random.Next(TopSide(), panelGame.Height / 2);

            radius = 10;
            centerX = random.Next(LeftSide(), RightSide());
            centerY = panelGame.Height + radius;

            velocityY = -Math.Abs(velocityY);
            velocityX = 0;
        }
        protected override void Go()
        {
            base.Go();

            if (centerY - radius <= zenit)
            {
                Stop();
                brush = defaultColor;
                ReachZenit.Invoke(this, new HitEventArgs(Side.Top));
            }
        }
    }
}
