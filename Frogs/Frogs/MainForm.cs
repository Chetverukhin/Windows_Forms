namespace Frogs
{
    public partial class MainForm : Form
    {
        private const int emptyLeafPosition = 5;
        private const int oneTypeFrogsNumber = 4;
        private const int minimumSteps = 24;
        private int _totalSteps;
        private List<PictureBox>? _leftFrogs;
        private List<PictureBox>? _rightFrogs;
        private List<PictureBox>? _frogs;

        public MainForm()
        {
            InitializeComponent();
            StartGame();

        }
        private void Frog_Click(object sender, EventArgs e)
        {
            Move((PictureBox)sender);
        }
        private void Move(PictureBox clickedFrog)
        {
            if (Math.Abs(emptyLeaf.Location.X - clickedFrog.Location.X) > emptyLeaf.Size.Width * 2)
            {
                MessageBox.Show("Невозможный ход");
            }
            else
            {
               (clickedFrog.Location, emptyLeaf.Location) =(emptyLeaf.Location, clickedFrog.Location);

                labelSteps.Text = $"Количество ходов: {++_totalSteps}";
            }
            if (EndGame())
            {
                var congrats = $"ПОЗДРАВЛЯЕМ!!!\nВы прошли игру за {_totalSteps} ходов!";

                if (_totalSteps == minimumSteps)
                {
                    congrats = $"{_totalSteps} ходов - СУПЕР РЕЗУЛЬТАТ!!\nВы прошли игру за минимальное количество ходов";
                }

                var endGame = new EndGame(congrats);

                if (endGame.ShowDialog() == DialogResult.OK)
                {
                    StartGame();
                    endGame.Dispose();
                }
                else
                {
                    this.Dispose();
                }
            }
        }
        public void StartGame()
        {
            _totalSteps = 0;
            labelSteps.Text = $"Количество ходов: {_totalSteps}";
            CreateFrogSet();

            var startPosition = new Point(0, 0);
            foreach (var frog in _frogs)
            {
                frog.Location = startPosition;
                startPosition.X += frog.Size.Width;
            }
        }
        private void CreateFrogSet()
        {
            this._leftFrogs = new List<PictureBox>();
            _leftFrogs.Add(leftFrog1);
            _leftFrogs.Add(leftFrog2);
            _leftFrogs.Add(leftFrog3);
            _leftFrogs.Add(leftFrog4);

            this._rightFrogs = new List<PictureBox>();
            _rightFrogs.Add(rightFrog1);
            _rightFrogs.Add(rightFrog2);
            _rightFrogs.Add(rightFrog3);
            _rightFrogs.Add(rightFrog4);

            this._frogs = new List<PictureBox>();
            _frogs.AddRange(_leftFrogs);
            _frogs.Add(emptyLeaf);
            _frogs.AddRange(_rightFrogs);
        }
        private bool EndGame()
        {
            if (_leftFrogs.Any(frog => frog.Location.X < frog.Size.Width * emptyLeafPosition))
            {
                return false;
            }

            return emptyLeaf.Location.X == emptyLeaf.Size.Width * oneTypeFrogsNumber;
        }
    }
}