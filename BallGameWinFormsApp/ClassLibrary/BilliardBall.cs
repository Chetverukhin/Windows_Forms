using System;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> Strike;
        public BilliardBall(Panel panelGame) : base(panelGame)
        { 
        }
        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftSide())
            {
                velocityX = -velocityX;
                Strike.Invoke(this, new HitEventArgs(Side.Left));
            }
            if ( centerX >= RightSide())
            {
                velocityX = -velocityX;
                Strike.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                velocityY = -velocityY;
                Strike.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                velocityY = -velocityY;
                Strike.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
