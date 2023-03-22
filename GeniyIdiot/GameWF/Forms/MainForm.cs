using GameClassLibrary;

namespace GameWF
{
    public partial class MainForm : Form
    {
        private Game game;
        private Form activeForm;
        public MainForm(Game game)
        {
            this.game = game;

            InitializeComponent();

            labelUserName.Text = $"Hi {game.user.Name}";
        }
        private void ShowGameMenu(Form currentForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = currentForm;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            this.panelActiveForm.Controls.Add(currentForm);
            this.panelActiveForm.Tag = currentForm;
            currentForm.BringToFront();
            currentForm.Show();
            labelCurrentMenu.Text = currentForm.Text;
        }
        private void buttonTest_Click(object sender, EventArgs e)
        {
            ShowGameMenu(new Forms.FormTest(game, labelCurrentMenu));
        }
        private void buttonResults_Click(object sender, EventArgs e)
        {
            ShowGameMenu(new Forms.FormResults(game));
        }
        private void buttonTop_Click(object sender, EventArgs e)
        { 
            ShowGameMenu(new Forms.FormRating(game));
        }
        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            ShowGameMenu(new Forms.FormEditData(game));
        }
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            game.Save();
            Application.Exit();
        }
    }
}