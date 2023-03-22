using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Banana : Fruit
    {
        public Banana(Panel panelGame) : base(panelGame)
        {
            brush = Brushes.Yellow;
            radius = 20;
            Touch = Touch.SpeedDown;
        }
    }
}
