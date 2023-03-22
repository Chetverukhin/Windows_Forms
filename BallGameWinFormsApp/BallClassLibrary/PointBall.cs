namespace BallClassLibrary
{
    public class PointBall : Ball
    {
        public PointBall(Panel panelGame, int x, int y) :base(panelGame)
        {
            X = x - ballSize / 2;
            Y = y - ballSize / 2;
        }

    }
}
