using System;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class FireworkBall : MoveBall
    {
        private float g = 0.2f;
        public FireworkBall(Panel panelGame, float centerX, float centerY) : base(panelGame)
        {
            radius= 15;
            this.centerX = centerX;
            this.centerY = centerY;

            velocityY = -Math.Abs(velocityY);
        }
        protected override void Go()
        {
            base.Go();

            velocityY += g;
        }
    }
}
