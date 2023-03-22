using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Bomb : Fruit
    {
        public Bomb(Panel panelGame) : base(panelGame)
        {
            brush = Brushes.Black;
            radius = 20;
            Touch = Touch.Explosive;
        }
    }
}
