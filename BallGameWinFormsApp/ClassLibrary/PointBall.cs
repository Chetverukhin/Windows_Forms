using System.Windows.Forms;

namespace BallClassLibrary
{
    public class PointBall : Ball
    {
        public PointBall(Panel panelGame, int x, int y) :base(panelGame)
        {
            centerX = x;
            centerY = y;
        }
    }
}
