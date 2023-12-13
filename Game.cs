

namespace SquaresGame
{
    public partial class Game : Form
    {
        int playerSpeed = 8;
        int enemySpeed = 9;
        int score = 0;
        int gameSpeed = 5;

        bool goLeft = false;
        bool goRight = false;
        bool goDown = false;
        bool goUp = false;

        public Game()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            this.Text = "Game                Score: " + score.ToString();

            if (goLeft)
            {
                player.Left -= playerSpeed;
            }
            if (goRight)
            {
                player.Left += playerSpeed;
            }
            if (goDown)
            {
                player.Top += playerSpeed;
            }
            if (goUp)
            {
                player.Top -= playerSpeed;
            }

            enemyBottom.Left -= enemySpeed;
            enemyTop.Left -= enemySpeed;
            coin1.Left -= enemySpeed;
            

            if (enemyBottom.Location.X < -50)
            {
                enemyBottom = GenerateNewEnemy(enemyBottom);
                enemyBottom.Left = 600;
                enemyBottom.Top = 500 - enemyBottom.Height;
            }
            if (enemyTop.Location.X < -50)
            {
                enemyTop = GenerateNewEnemy(enemyTop);
                enemyTop.Left = 800;
                enemyTop.Top = -30;
            }

            if (player.Bounds.IntersectsWith(enemyBottom.Bounds) || player.Bounds.IntersectsWith(enemyTop.Bounds) ||
                player.Top == -5 || player.Bounds.IntersectsWith(border.Bounds))
            {
                GameStop();
            }

            if (player.Bounds.IntersectsWith(coin1.Bounds))
            {
                NewCoinLocalization(coin1);
                score++;
            }
            else if (coin1.Left < 0)
            {
                NewCoinLocalization(coin1);
            }

            if (player.Bounds.IntersectsWith(yBorder.Bounds))
            {
                goRight = false;
            }

            if (score == gameSpeed)
            {
                enemySpeed++;
                gameSpeed +=5;
            }
        }

        private void GameStop()
        {
            gameTimer.Stop();
            GameOver go = new GameOver(score, this);
            go.Show();

        }

        private void NewCoinLocalization(PictureBox coin)
        {
            Random rd = new Random();
            coin.Left = rd.Next(800, 1000);
            coin.Top = rd.Next(50, 500);
            if (coin.Bounds.IntersectsWith(enemyBottom.Bounds) || coin.Bounds.IntersectsWith(enemyTop.Bounds) || 
                (coin.Left >= enemyBottom.Left && coin.Left <= enemyBottom.Left + enemyBottom.Width) ||
                (coin.Left >= enemyTop.Left && coin.Left <= enemyTop.Left + enemyTop.Width))
            {
                coin.Left += 300;
            }
        }

        private PictureBox GenerateNewEnemy(PictureBox enemy)
        {
            Random random = new Random();
            int x = random.Next(-25, 25);
            int y = random.Next(-45, 45);

            enemy.Width = 75 + x;
            enemy.Height = 190 + y; 

            return enemy;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }
    }
}
