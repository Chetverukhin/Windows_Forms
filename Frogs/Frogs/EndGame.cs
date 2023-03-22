namespace Frogs
{
    public partial class EndGame : Form
    {
        public EndGame(string results)
        {
            InitializeComponent();

            buttonYes.DialogResult = DialogResult.OK;
            buttonNo.DialogResult = DialogResult.Cancel;

            labelScores.Text = results;
        }
    }
}
