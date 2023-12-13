
namespace SquaresGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Hide();
            game.Show();
        }

        private void QuitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
