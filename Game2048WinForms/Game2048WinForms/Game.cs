using GameClassLibrary;

namespace Game2048WinForms
{
    public class Game
    {
        public User user;
        public int BestScores;
        public Game(User user)
        {
            this.user = user;
        }
        public void PrepareSources()
        {
            var fileScores = ProgramFile.Read();
            StorageScores.ReadDataScores(fileScores);
            BestScores = StorageScores.GetBestScores();
        }
        public void PrepareCellsMap(Control panelGame)
        {
            user.Scores = 0;
            panelGame.Controls.Clear();
            panelGame.BringToFront();

            CellsMap.CreateCellsMap();
            CellsMap.InsertCellsMapToForm(panelGame);
            CellsMap.SetNumberRadomCell();
        }
        public void Reset(Control panelGame)
        {
            panelGame.Controls.Clear();
            user.Scores = 0;
        }
        public void SaveScores(User user)
        {
            var newUser = user.Clone();
            StorageScores.Add(newUser);
        }
        public void Save()
        {
            ProgramFile.Save(StorageScores.Scores);
        }
        public void Play(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Action.MoveRight(CellsMap.Map, out int scores);
                user.Scores += scores;
            }
            if (e.KeyCode == Keys.Left)
            {
                Action.MoveLeft(CellsMap.Map, out int scores);
                user.Scores += scores;
            }
            if (e.KeyCode == Keys.Up)
            {
                Action.MoveUp(CellsMap.Map, out int scores);
                user.Scores += scores;
            }
            if (e.KeyCode == Keys.Down)
            {
                Action.MoveDown(CellsMap.Map, out int scores);
                user.Scores += scores;
            }
            if (Action.IsPressedArrow(e))
            {
                CellsMap.SetNumberRadomCell();
            }
        }
        public bool End()
        {
            var maxScores = user.Scores >= 2048;
            var noMoves = CellsMap.HasNoFreeCells();

            return maxScores || noMoves;
        }
        public void NewRecord(int currentScore)
        {
            if (currentScore >= BestScores)
            {
                BestScores = currentScore;
            }
        }
    }
}
