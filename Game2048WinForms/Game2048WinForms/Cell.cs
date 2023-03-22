namespace Game2048WinForms
{
    public class Cell
    {
        public Label lable;
        int baseColor = 208; // LightGary
        int stepRed = 3; int stepGreen = 13; int stepBlue = 13; // Step for changing cell's color

        public Cell(int indexColumn, int indexRow, string number = "",
                    int cellSize = 100, int positionX = 10, int positionY = 10,
                    int distanceNextCell = 6)
        {
            // create lable
            this.lable = new Label();
            positionX += indexColumn * (cellSize + distanceNextCell);
            positionY += indexRow * (cellSize + distanceNextCell);

            lable.Size = new Size(cellSize, cellSize);
            lable.FlatStyle = FlatStyle.Flat;
            lable.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lable.BackColor = Color.FromArgb(baseColor, baseColor, baseColor);
            lable.TextAlign = ContentAlignment.MiddleCenter;
            lable.AutoSize = false;
            lable.TextChanged += new EventHandler(ColorChanged);
            lable.Text = number;
            lable.Location = new Point(positionX, positionY);
        }
        private void ColorChanged(object sender, EventArgs e)
        {
            var newLable = (Label)sender;
            if (newLable.Text == string.Empty)
            {
                newLable.BackColor = Color.FromArgb(baseColor, baseColor, baseColor);
                return;
            }
            var number = (int)Math.Log(double.Parse(newLable.Text), 2) - 1;

            var R = baseColor - number * stepRed;
            var G = baseColor - number * stepGreen;
            var B = baseColor - number * stepBlue;

            newLable.BackColor = Color.FromArgb(R, G, B);
        }
    }
}
