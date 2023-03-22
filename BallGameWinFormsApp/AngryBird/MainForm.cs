using BallClassLibrary;

namespace AngryBird
{
    public partial class MainForm : Form
    {
        private Bird bird;
        private Pig pig;
        private Wall wall;

        private int scores;

        public MainForm()
        {
            InitializeComponent();
            GameSettings();
        }
        private void panelGame_MouseDown(object sender, MouseEventArgs e)
        {
            bird.Shot(e.X, e.Y);
        }
        private void GameSettings()
        {
            bird = new Bird(panelGame);
            bird.SetStartPosition();
            CreatEnemy();
        }
        private void CreatEnemy()
        {
            pig = new Pig(panelGame, bird);
            pig.Hit += Pig_Hit;
            pig.Start();

            wall = new Wall(panelGame, bird);
            wall.Strike += Wall_Strike;
            wall.Build();
        }
        private void Wall_Strike(object? sender, HitEventArgs e)
        {
            bird.WallStrike(e.Side, wall.GetPoint(), wall.GetSize());
        }
        private void Pig_Hit(object? sender, TouchEventArgs e)
        {
            if (e.Touch == Touch.Explosive)
            {
                wall.Destroy();
                scores += 1;
                labelScrores.Text = $"SCORES: {scores}";
                CreatEnemy();
            }
        }
    }
}