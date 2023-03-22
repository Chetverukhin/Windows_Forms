using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public partial class Molecule : BilliardBall
    {
        public event EventHandler<PassedMeridianEventArgs> Passed;

        private Brush positiveColor = Brushes.Blue;
        private Brush negativeColor = Brushes.Red;

        private int median;
        public Charge charge;

        public Molecule(Panel panelGame, bool positiveCharge) : base(panelGame)
        {
            radius = 25;
            median = panelGame.Width / 2;

            if (positiveCharge)
            {
                brush = positiveColor;
                centerX = random.Next(LeftSide(), median - radius);
            }
            else
            {
                brush = negativeColor;
                centerX = random.Next(median + radius, RightSide());
            }
            centerY = random.Next(TopSide(), DownSide());
        }
        protected override void Go()
        {
            base.Go();

            if (centerX - radius >= median)
            {
                charge = Charge.negative;
                Passed.Invoke(this, new PassedMeridianEventArgs(HalfSide.RightSide));
            }
            if (centerX + radius <= median)
            {
                charge = Charge.positive;
                Passed.Invoke(this, new PassedMeridianEventArgs(HalfSide.LeftSide));
            }
        }
    }
    public enum Charge
    {
        positive,
        negative
    }
}
