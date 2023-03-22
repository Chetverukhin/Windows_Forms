using System;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class RandomPointBall : Ball
    {
        protected Random random = new Random();
        public RandomPointBall(Panel panelGame) : base(panelGame)
        {
            int thirdX = panelGame.Width / 3;
            int thirdY = panelGame.Height / 3;

            centerX = random.Next(thirdX, panelGame.Width - thirdX);
            centerY = random.Next(thirdY, panelGame.Height - thirdY);
        }
    }
}
