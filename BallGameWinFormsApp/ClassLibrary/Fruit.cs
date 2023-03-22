using System;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Fruit : MoveBall
    {
        private float zenit;
        private float g = 0.2f;

        public Fruit(Panel panelGame) : base(panelGame)
        {
            Touch = Touch.Stop;
            var random = new Random();
            zenit = random.Next(TopSide(), panelGame.Height / 2);

            centerX = random.Next(LeftSide(), RightSide());
            centerY = panelGame.Height + radius;

            velocityY = -Math.Abs(velocityY);
        }
        protected override void Go()
        {
            base.Go();
            if (centerY - radius <= zenit)
            {
                velocityY += g;
            }
        }
    }
}
