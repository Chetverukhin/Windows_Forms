namespace BallClassLibrary
{
    public class RandomSizeAndPointBall : RandomBall
    {
        public RandomSizeAndPointBall(Panel panelGame) : base(panelGame)
        {
            ballSize = random.Next(50, 100);
        }
    }
}
