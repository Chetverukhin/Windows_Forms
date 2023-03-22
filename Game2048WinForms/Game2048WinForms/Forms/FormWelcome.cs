using GameClassLibrary;

namespace Game2048WinForms
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }
        private void buttonAcceptUserName_Click(object sender, EventArgs e)
        {
            if (Check.UserText(textBoxUserName.Text, out string name, out string error))
            {
                User user = new(name);
                Game game = new(user);
                game.PrepareSources();

                new FormMain(game).Show();
                Hide();
            }
            else
            {
                MessageBox.Show(error, "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserName.Clear();
                textBoxUserName.Focus();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
