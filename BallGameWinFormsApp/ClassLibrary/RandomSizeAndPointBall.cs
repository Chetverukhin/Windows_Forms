using System.Windows.Forms;

namespace BallClassLibrary
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Panel panelGame) : base(panelGame)
        {
            radius = random.Next(25, 50);
        }
    }
}
