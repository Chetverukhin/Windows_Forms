namespace BallClassLibrary
{
    public class RandomBall : Ball
    {
        protected Random random = new Random();
        private int velocity = 3;
        public RandomBall(Panel panelGame) : base(panelGame)
        {
            int thirdX = panelGame.Width / 3;
            int thirdY = panelGame.Height / 3;

            X = random.Next(thirdX, panelGame.Width - thirdX);
            Y = random.Next(thirdY, panelGame.Height - thirdY);

            velocityX = random.Next(-velocity, velocity + 1);
            velocityY = random.Next(-velocity, velocity + 1);

            if (velocityX == 0 && velocityY == 0)
            {
                while (velocityY == 0)
                {
                    velocityY = random.Next(-velocity, velocity + 1);
                }
            }
        }
    }
}
