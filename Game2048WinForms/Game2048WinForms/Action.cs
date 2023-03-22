namespace Game2048WinForms
{
    internal class Action
    {

        public static int MoveRight(Cell[,] cellsMap, out int scores)
        {
            int mapSize = cellsMap.GetLength(0);
            scores = 0;

            for (int row = 0; row < mapSize; row++)
            {
                for (int column = mapSize - 1; column >= 0; column--)
                {
                    if (cellsMap[row, column].lable.Text != string.Empty)
                    {
                        for (int i = column - 1; i >= 0; i--)
                        {
                            if (cellsMap[row, i].lable.Text != string.Empty)
                            {
                                if (cellsMap[row, column].lable.Text == cellsMap[row, i].lable.Text)
                                {
                                    var number = int.Parse(cellsMap[row, column].lable.Text);
                                    scores += number * 2;
                                    cellsMap[row, column].lable.Text = (number * 2).ToString();                                    
                                    cellsMap[row, i].lable.Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int row = 0; row < mapSize; row++)
            {
                for (int column = mapSize - 1; column >= 0; column--)
                {
                    if (cellsMap[row, column].lable.Text == string.Empty)
                    {
                        for (int i = column - 1; i >= 0; i--)
                        {
                            if (cellsMap[row, i].lable.Text != string.Empty)
                            {
                                cellsMap[row, column].lable.Text = cellsMap[row, i].lable.Text;
                                cellsMap[row, i].lable.Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            return scores;
        }
        public static int MoveLeft(Cell[,] cellsMap, out int scores)
        {
            int mapSize = cellsMap.GetLength(0);
            scores = 0;

            for (int row = 0; row < mapSize; row++)
            {
                for (int column = 0; column < mapSize; column++)
                {
                    if (cellsMap[row, column].lable.Text != string.Empty)
                    {
                        for (int i = column + 1; i < mapSize; i++)
                        {
                            if (cellsMap[row, i].lable.Text != string.Empty)
                            {
                                if (cellsMap[row, column].lable.Text == cellsMap[row, i].lable.Text)
                                {
                                    var number = int.Parse(cellsMap[row, column].lable.Text);
                                    scores += number * 2;
                                    cellsMap[row, column].lable.Text = (number * 2).ToString();
                                    cellsMap[row, i].lable.Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int row = 0; row < mapSize; row++)
            {
                for (int column = 0; column < mapSize; column++)
                {
                    if (cellsMap[row, column].lable.Text == string.Empty)
                    {
                        for (int i = column + 1; i < mapSize; i++)
                        {
                            if (cellsMap[row, i].lable.Text != string.Empty)
                            {
                                cellsMap[row, column].lable.Text = cellsMap[row, i].lable.Text;
                                cellsMap[row, i].lable.Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            return scores;
        }
        public static int MoveUp(Cell[,] cellsMap, out int scores)
        {
            int mapSize = cellsMap.GetLength(0);
            scores = 0;

            for (int column = 0; column < mapSize; column++)
            {
                for (int row = 0; row < mapSize; row++)
                {
                    if (cellsMap[row, column].lable.Text != string.Empty)
                    {
                        for (int i = row + 1; i < mapSize; i++)
                        {
                            if (cellsMap[i, column].lable.Text != string.Empty)
                            {
                                if (cellsMap[row, column].lable.Text == cellsMap[i, column].lable.Text)
                                {
                                    var number = int.Parse(cellsMap[row, column].lable.Text);
                                    scores += number * 2;
                                    cellsMap[row, column].lable.Text = (number * 2).ToString();
                                    cellsMap[i, column].lable.Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int column = 0; column < mapSize; column++)
            {
                for (int row = 0; row < mapSize; row++)
                {
                    if (cellsMap[row, column].lable.Text == string.Empty)
                    {
                        for (int i = row + 1; i < mapSize; i++)
                        {
                            if (cellsMap[i, column].lable.Text != string.Empty)
                            {
                                cellsMap[row, column].lable.Text = cellsMap[i, column].lable.Text;
                                cellsMap[i, column].lable.Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            return scores;
        }
        public static int MoveDown(Cell[,] cellsMap, out int scores)
        {
            int mapSize = cellsMap.GetLength(0);
            scores = 0;
            for (int column = 0; column < mapSize; column++)
            {
                for (int row = mapSize - 1; row >= 0; row--)
                {
                    if (cellsMap[row, column].lable.Text != string.Empty)
                    {
                        for (int i = row - 1; i >= 0; i--)
                        {
                            if (cellsMap[i, column].lable.Text != string.Empty)
                            {
                                if (cellsMap[row, column].lable.Text == cellsMap[i, column].lable.Text)
                                {
                                    var number = int.Parse(cellsMap[row, column].lable.Text);
                                    scores += number * 2;
                                    cellsMap[row, column].lable.Text = (number * 2).ToString();
                                    cellsMap[i, column].lable.Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int column = 0; column < mapSize; column++)
            {
                for (int row = mapSize - 1; row >= 0; row--)
                {
                    if (cellsMap[row, column].lable.Text == string.Empty)
                    {
                        for (int i = row - 1; i >= 0; i--)
                        {
                            if (cellsMap[i, column].lable.Text != string.Empty)
                            {
                                cellsMap[row, column].lable.Text = cellsMap[i, column].lable.Text;
                                cellsMap[i, column].lable.Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            return scores;
        }
        public static bool IsPressedArrow(KeyEventArgs e)
        {
            var keys = new[] {(int)Keys.Right, (int)Keys.Left, (int)Keys.Up, (int)Keys.Down};
            return keys.Any(key => key == (int)e.KeyCode);
        }
    }
}
