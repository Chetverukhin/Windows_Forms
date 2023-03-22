using BallClassLibrary;

namespace Diffusion
{
    public partial class MainForm : Form
    {
        private int moleculesNumber = 10;
        private List<Molecule> firstPack = new List<Molecule>();
        private List<Molecule> secondPack = new List<Molecule>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void panelGame_MouseDown(object sender, MouseEventArgs e)
        {
            StopGame();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawMedian();

            for (int i = 0; i < moleculesNumber; i++)
            {
                var molecule = new Molecule(panelGame, true);
                molecule.Strike += FirstPackMolecule_Strike;
                molecule.Passed += Molecule_Passed;
                firstPack.Add(molecule);
            }
            for (int i = 0; i < moleculesNumber; i++)
            {
                var molecule = new Molecule(panelGame, false);
                molecule.Strike += SecondPackMolecule_Strike;
                molecule.Passed += Molecule_Passed;
                secondPack.Add(molecule);
            }
        }
        private void Molecule_Passed(object? sender, PassedMeridianEventArgs e)
        {
            if (MixCompleted())
            {
                StopGame();
            }
        }
        private bool MixCompleted()
        {
            return firstPack.Count(x => x.charge == Charge.positive) == moleculesNumber /2 && secondPack.Count(x => x.charge == Charge.positive) == moleculesNumber / 2;
        }
        private void StopGame()
        {
            for (int i = 0; i < moleculesNumber; i++)
            {
                firstPack[i].Stop();
                secondPack[i].Stop();
            }
        }
        private void StartGame()
        {
            for (int i = 0; i < moleculesNumber; i++)
            {
                firstPack[i].Start();
                secondPack[i].Start();
            }
        }
        private void SecondPackMolecule_Strike(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    labelSecondPackLeft.Text = (int.Parse(labelSecondPackLeft.Text) + 1).ToString();
                    break;
                case Side.Right:
                    labelSecondPackRight.Text = (int.Parse(labelSecondPackRight.Text) + 1).ToString();
                    break;
                case Side.Top:
                    labelSecondPackTop.Text = (int.Parse(labelSecondPackTop.Text) + 1).ToString();
                    break;
                case Side.Down:
                    labelSecondPackDown.Text = (int.Parse(labelSecondPackDown.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }
        private void FirstPackMolecule_Strike(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    labelFirstPackLeft.Text = (int.Parse(labelFirstPackLeft.Text) + 1).ToString();
                    break;
                case Side.Right:
                    labelFirstPackRight.Text = (int.Parse(labelFirstPackRight.Text) + 1).ToString();
                    break;
                case Side.Top:
                    labelFirstPackTop.Text = (int.Parse(labelFirstPackTop.Text) + 1).ToString();
                    break;
                case Side.Down:
                    labelFirstPackDown.Text = (int.Parse(labelFirstPackDown.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }
        private void DrawMedian()
        {
            var median = new Label();
            int medianWidth = 2;
            panelGame.Controls.Add(median);
            median.BackColor = Color.IndianRed;
            median.Location = new Point(panelGame.Width / 2 - medianWidth / 2, 0);
            median.Size = new Size(medianWidth, panelGame.Height);
            median.TabIndex = 0;
        }
    }
}