using System.Windows.Forms;

namespace BallClassLibrary
{
    public class MoveBall : RandomSizeAndPointBall
    {
        private int velocity = 4;
        public MoveBall(Panel panelGame) : base(panelGame)
        {
            velocityX = GetDirection();
            velocityY = GetDirection();
        }
        public int GetDirection()
        {
            var probability = random.NextDouble();
            var direction = 1;

            if (probability < 0.5)
            {
                direction = -1;
            }
            return random.Next(1, velocity) * direction;
        }
        public void Speed(float speed)
        {
            velocityX *= speed;
            velocityY *= speed;
        }
    }
}
