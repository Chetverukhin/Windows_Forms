using GameClassLibrary;

namespace Game2048WinForms
{
    public partial class FormSettings : Form
    {
        private static int minSize = 4;
        private static int maxSize = 10;
        private static int minGrid = 1;
        private static int maxGrid = 20;

        public FormSettings()
        {
            InitializeComponent();
            SetInfoStyle();
        }
        private void SetInfoStyle()
        {
            labelInfoStyleMap.Text = $"Настройте игровое поле под ваши предпочтения.\n" +
                                     $"Количество ячеек должно быть от {minSize} до {maxSize} ячеек\n" +
                                     $"Ширина сетки игры должна быть от {minGrid} до {maxGrid} пикселей";
        }
        private void buttonAcceptStyle_Click(object sender, EventArgs e)
        {
            var correctNumberSize = Check.UserNumber(textBoxMapSize.Text, out int sizeMap, out string errorNumberSize);
            var correctNumberGrid = Check.UserNumber(textBoxGridMap.Text, out int gridMap, out string errorNumberGrid);

            if (!correctNumberSize)
            {
                MessageBox.Show(errorNumberSize, "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMapSize.Clear();
                textBoxMapSize.Focus();
            }
            if (!correctNumberGrid)
            {
                MessageBox.Show(errorNumberGrid, "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxGridMap.Clear();
                textBoxGridMap.Focus();
            }
            if (correctNumberSize && correctNumberGrid)
            {
                var correctStyleSize = Check.UserChoiceMapStyle(sizeMap, maxSize, minSize, out int correctSize, out string errorSize);
                var correctStyleGrid = Check.UserChoiceMapStyle(gridMap, maxGrid, minGrid, out int correctGrid, out string errorGrid);

                if (!correctStyleSize)
                {
                    MessageBox.Show(errorSize + " количества ячеек", "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMapSize.Clear();
                    textBoxMapSize.Focus();
                }
                if (!correctStyleGrid)
                {
                    MessageBox.Show(errorGrid + " ширины сетки", "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxGridMap.Clear();
                    textBoxGridMap.Focus();
                }
                if (correctStyleSize && correctStyleGrid)
                {
                    CellsMap.SetMapStyle(correctSize, correctGrid);
                    MessageBox.Show("Изменения успешно внесены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void textBoxMapSize_Click(object sender, EventArgs e)
        {
            textBoxMapSize.Text = null;
            textBoxMapSize.ForeColor = Color.Black;
        }
        private void textBoxGridMap_Click(object sender, EventArgs e)
        {
            textBoxGridMap.Text = null;
            textBoxGridMap.ForeColor = Color.Black;
        }
    }
}
