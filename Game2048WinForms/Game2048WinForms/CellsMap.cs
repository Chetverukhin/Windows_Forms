namespace Game2048WinForms
{
    public static class CellsMap
    {
        public static Cell[,] Map;
        public static int Size = 4;
        public static int Grid = 10;
        public static void CreateCellsMap()
        {
            Map = new Cell[Size, Size];

            for (int rowIndex = 0; rowIndex < Size; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < Size; columnIndex++)
                {
                    var newCell = new Cell(columnIndex, rowIndex, string.Empty, distanceNextCell: Grid);
                    Map[rowIndex, columnIndex] = newCell;
                }
            }
        }
        public static void InsertCellsMapToForm(Control panelGame)
        {
            foreach (var cell in Map)
            {
                panelGame.Controls.Add(cell.lable);
            }
        }
        public static void SetNumberRadomCell()
        {
            var random = new Random();
            var emptyCells = new List<Cell>();

            foreach (var cell in Map)
            {
                if (cell.lable.Text == string.Empty)
                {
                    emptyCells.Add(cell);
                }
            }
            var randomCell = emptyCells[random.Next(emptyCells.Count)];
            randomCell.lable.Text = GetRandomNumber();
        }
        public static void SetMapStyle(int sizeMap, int gridMap)
        {
            Size = sizeMap;
            Grid = gridMap;
        }
        public static string GetRandomNumber()
        {
            var random = new Random();
            var probability = random.NextDouble();

            if (probability <= 0.75)
            {
                return "2";
            }
            return "4";
        }
        public static bool HasNoFreeCells()
        {
            foreach (var cell in Map)
            {
                if (cell.lable.Text == string.Empty)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
