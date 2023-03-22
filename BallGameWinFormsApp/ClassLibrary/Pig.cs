using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Pig : Ball
    {
        public event EventHandler<TouchEventArgs> Hit;
        protected Random random = new Random();
        protected Bird bird;
        public Pig(Panel panelGame, Bird bird) : base(panelGame)
        {
            brush = Brushes.Coral;
            centerX = random.Next(RightSide() / 2, RightSide());
            centerY = random.Next(TopSide(), DownSide());
            velocityX = 0;
            velocityY = 0;
            this.bird = bird;
        }
        protected override void Go()
        {
            base.Go();
            var D = bird.GetRadius() + radius;

            if (Math.Abs(centerX - bird.GetCenterX()) <= D && Math.Abs(centerY - bird.GetCenterY()) <= D)
            {
                brush = new SolidBrush(panelGame.BackColor);
                Stop();
                Hit.Invoke(this, new TouchEventArgs(Touch.Explosive));
            }
        }
    }
}
