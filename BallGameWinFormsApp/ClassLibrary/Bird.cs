using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Bird : Ball
    {
        private float g;
        private Brush color = Brushes.Red;
        private int acceleration = 30;
        private float declineSpeed = 0.5f;
        private float previousPosition;
        private bool inFlight;

        public event EventHandler<HitEventArgs> Strike;
        public Bird(Panel panelGame) : base(panelGame)
        {
            radius = 15;
            brush = color;
            SetStartPosition();
        }
        protected override void Go()
        {
            base.Go();
            velocityY += g;

            if (centerX >= RightSide())
            {
                SetStartPosition();
            }
            if (centerX <= LeftSide())
            {
                SetStartPosition();
            }
            if (centerY > DownSide())
            {
                centerY = DownSide();
                if (centerX - previousPosition < 0.5)
                {
                    SetStartPosition();
                }
                previousPosition = centerX;
                DeclineSpeed();
            }
        }
        public void SetStartPosition()
        {
            Start();
            inFlight = false;
            g = 0;
            velocityY = 0;
            velocityX = 0;
            centerX = LeftSide() + radius;
            centerY = DownSide() - radius;
            previousPosition = 0;
        }
        public void Shot(int X, int Y)
        {
            g = 0.2f;
            GetVelosity(X, Y);
            Start();
        }
        public void GetVelosity(int X, int Y)
        {
            var availableX = panelGame.Width / 2;
            var availableY = panelGame.Height / 2;

            if (!inFlight)
            {
                inFlight = true;

                if (X >= availableX)
                {
                    X = availableX;
                }
                if (Y <= availableY)
                {
                    Y = availableY;
                }
                velocityX = ((float)X / availableX) * acceleration;
                velocityY = ((float)(Y - panelGame.Height) / availableY) * acceleration;
            }
        }
        public void DeclineSpeed()
        {
            velocityY = -velocityY * declineSpeed;
            velocityX *= declineSpeed;
        }
        public void WallStrike(Side side, Point wallPoint, Size wallSize)
        {
            if (side == Side.Left)
            {
                Clear();
                centerX = wallPoint.X - radius;
                Start();
                velocityX = -velocityX * declineSpeed;
                velocityY *=  declineSpeed;
            }
            if (side == Side.Top)
            {
                Clear();
                centerY = wallPoint.Y - radius;
                Start();
                DeclineSpeed();
            }
            if (side == Side.Down)
            {
                Clear();
                centerY = wallPoint.Y + wallSize.Height + radius;
                Start();
                DeclineSpeed();
            }
        }
    }
}
