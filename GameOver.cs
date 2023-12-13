

namespace SquaresGame
{
    public partial class GameOver : Form
    {
        Game game = null;
        public GameOver(int score, Game game)
        {
            InitializeComponent();
            scoreLabel.Text += score;
            this.game = game;
        }

        private void OkClicked(object sender, EventArgs e)
        {
            game.Close();
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
