using System.Drawing;
using System;
namespace BallClassLibrary
{
    public class Ball
    {
        private Panel panelGame;
        protected int velocityX = 1;
        protected int velocityY = 1;
        protected int X;
        protected int Y;
        protected int ballSize = 50;
        public bool onWindow = true;
        public Ball(Panel panelGame)
        {
            this.panelGame = panelGame;
            onWindow = true;
        }
        public void Show(Brush brush)
        {
            var graphics = panelGame.CreateGraphics();
            var rectangle = new Rectangle(X, Y, ballSize, ballSize);
            graphics.FillEllipse(brush, rectangle);
        }
        private void Go()
        {
            X += velocityX;
            Y += velocityY;
        }
        public void Move()
        {
            ChekPosition();

            if (onWindow)
            {
                Show(Brushes.Gainsboro);
                Go();
                Show(Brushes.MediumSeaGreen);
            }
        }
        public bool Сaught(int x, int y)
        {
            var legX = x - (X + ballSize / 2);
            var legY = y - (Y + ballSize / 2);
            var hypo = Math.Sqrt(legX * legX + legY * legY);

            return hypo <= ballSize / 2;
        }
        public void ChekPosition()
        {
            if (onWindow)
            {
                if (X < 0)
                {
                    onWindow = false;
                }
                if (X + ballSize > panelGame.Width)
                {
                    onWindow = false;
                }
                if (Y < 0)
                {
                    onWindow = false;
                }
                if (Y + ballSize > panelGame.Height)
                {
                    onWindow = false;
                }
            }
        }
    }
}
