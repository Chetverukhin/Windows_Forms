using System.Collections.Generic;
using System.Windows.Forms;

namespace BallClassLibrary
{
    public class Game
    {
        public List<Ball> moveBalls = new List<Ball>();
        public int caughtBalls;
        private Panel panelGame;
        public Game(Panel panelGame, int ballsNumber)
        {
            this.panelGame = panelGame;
            for (int i = 0; i < ballsNumber; i++)
            {
                var ball = new MoveBall(panelGame);
                moveBalls.Add(ball);
            }
        }
        public void Play()
        {
            foreach (var ball in moveBalls)
            {
                ball.Start();
            }
        }
        public void Cathing(MouseEventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                if (ball.Сaught(e) && ball.InMotion())
                {
                    ball.Stop();
                    caughtBalls += 1;
                }
            }
        }
        public void Stop(bool cathing)
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();

                if (!cathing && ball.OnWindow())
                {
                    caughtBalls += 1;
                }
            }
        }
    }
}
