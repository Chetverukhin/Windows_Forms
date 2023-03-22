using BallClassLibrary;
using Timer = System.Windows.Forms.Timer;

namespace NinjaBall
{
    public partial class NinjaBall : Form
    {
        private List<MoveBall> ballBasket = new List<MoveBall>();
        private Timer gameTimer = new Timer();
        private Timer speedTimer = new Timer();
        private Random random = new Random();

        private int intervalLaunchingBall = 200;

        private float normalSpeed = 1f;
        private float lowSpeed = 0.5f;
        private float speedGame;
        private int bonusSeconds = 3;
        
        public NinjaBall()
        {
            InitializeComponent();            
            GameSettings();
        }
        private void GameSettings()
        {
            speedGame = normalSpeed;

            gameTimer.Enabled = true;
            gameTimer.Interval = intervalLaunchingBall;
            gameTimer.Tick += GameTimer_Tick;

            speedTimer.Enabled = false;
            speedTimer.Interval = bonusSeconds * 1000;
            speedTimer.Tick += SpeedTimer_Tick;
        }
        private void GameTimer_Tick(object? sender, EventArgs e)
        {
            var probability = random.NextDouble();

            if (probability < 0.05)
            {
                CreatTypeBall(new Bomb(panelGame));
            }
            if (probability < 0.1)
            {
                CreatTypeBall(new Banana(panelGame));
            }
            CreatTypeBall(new Fruit(panelGame));
        }
        private void SpeedTimer_Tick(object? sender, EventArgs e)
        {
            speedTimer.Stop();
            ChangeGameSpeed(normalSpeed);
        }
        private void Ball_Catching(object? sender, TouchEventArgs e)
        {
            switch (e.Touch)
            {
                case Touch.Stop:
                    var fruit = (MoveBall)sender;
                    fruit.Clear();
                    break;
                case Touch.Explosive:
                    StopGame();
                    break;
                case Touch.SpeedDown:
                    LowSpeed();
                    break;
            }
        }
        private void PanelGame_MouseMove(object sender, MouseEventArgs args)
        {
            for (int i = 0; i < ballBasket.Count; i++)
            {
                var ball = ballBasket[i];

                if (ball.Ñaught(args))
                {
                    ball.Clear();
                    ballBasket.RemoveAt(i);
                }
            }
        }
        private void ChangeGameSpeed(float speed)
        {
            speedGame = speed;
            float newSpeed = speed;

            if (speed == normalSpeed)
            {
                newSpeed = normalSpeed / lowSpeed;
            }
            gameTimer.Interval = (int)(gameTimer.Interval / newSpeed);

            foreach (var ball in ballBasket)
            {
                ball.Speed(newSpeed);
            }
        }
        private void LowSpeed()
        {
            speedTimer.Start();
            ChangeGameSpeed(lowSpeed);
        }
        private void CreatTypeBall(MoveBall ball)
        {
            ball.Start();
            ball.Speed(speedGame);
            ball.Catch += Ball_Catching;
            ballBasket.Add(ball);
        }
        private void StopGame()
        {
            gameTimer.Stop();

            foreach (var ball in ballBasket)
            {
                ball.Clear();
            }
            MessageBox.Show("GAME OVER", "Information", MessageBoxButtons.OK);
        }
    }
}