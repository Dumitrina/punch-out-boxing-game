namespace Simple_Punch_Out_Game
{
    public partial class Form1 : Form
    {

        bool playerBlock = false;
        bool enemyBlock = false;
        Random random = new Random();
        int enemySpeed = 5;
        int index = 0;
        int playerHealth = 100;
        int enemyHealth = 100;
        List<string> enemyAttack = new List<string> { "left", "right", "block" };


        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BoxerAttackTimerEvent(object sender, EventArgs e)
        {
            index = random.Next(0, enemyAttack.Count);

            switch (enemyAttack[index].ToString())
            {
                case "left":
                    boxer.Image = Properties.Resources.enemy_punch1;
                    enemyBlock = false;

                    if (boxer.Bounds.IntersectsWith(player.Bounds) && playerBlock == false)
                    {
                        playerHealth -= 5;
                    }

                    break;

                case "right":
                    boxer.Image = Properties.Resources.enemy_punch2;
                    enemyBlock = false;

                    if (boxer.Bounds.IntersectsWith(player.Bounds) && playerBlock == false)
                    {
                        playerHealth -= 5;
                    }

                    break;

                case "block":
                    boxer.Image = Properties.Resources.enemy_block;
                    enemyBlock = true;


                    break;
            }
        }

        private void BoxerMoveTimerEvent(object sender, EventArgs e)
        {
            //incrementam health bars
            if (playerHealth > 1)
            {
                playerHealthBar.Value = playerHealth;
            }

            if (enemyHealth > 1)
            {
                boxerHealthBar.Value = enemyHealth;
            }


            //mutam boxer-ul
            boxer.Left += enemySpeed;

            if (boxer.Left > 430)
            {
                enemySpeed = -5;
            }
            if (boxer.Left < 220)
            {
                enemySpeed = 5;
            }

            //verific daca jocul s-a terminat
            if (enemyHealth < 1)
            {
                boxerAttackTimer.Stop();
                BoxerMoveTimer.Stop();
                MessageBox.Show("You Win, Click Ok to Play Again", "Boss Says: ");
                ResetGame();
            }

            if (playerHealth < 1)
            {
                boxerAttackTimer.Stop();
                BoxerMoveTimer.Stop();
                MessageBox.Show("You lost, Click Ok to Play Again", "Boss Says: ");
                ResetGame();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
             //daca utilizatorul alege cheia dreapta
            if (e.KeyCode == Keys.Down)
            {
                //schimbam imaginea
                player.Image = Properties.Resources.boxer_block;
                playerBlock = true;  
            }
            //daca utilizatorul alege cheia stanga
            if (e.KeyCode == Keys.Left)
            {
                 
                player.Image = Properties.Resources.boxer_left_punch;
                playerBlock = false;

                if (player.Bounds.IntersectsWith(boxer.Bounds) &&  enemyBlock == false)
                {
                     
                    enemyHealth -= 5;
                }
            }
            // //daca utilizatorul alege cheia Jos
            if (e.KeyCode == Keys.Right)
            {
                
                player.Image = Properties.Resources.boxer_right_punch;
                playerBlock = false;
                if (player.Bounds.IntersectsWith(boxer.Bounds) && enemyBlock == false)
                { 
                    enemyHealth -= 5;
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            player.Image = Properties.Resources.boxer_stand;
            playerBlock = false;
        }

        private void ResetGame()
        {
            boxerAttackTimer.Start();
            BoxerMoveTimer.Start();
            playerHealth = 100;
            enemyHealth = 100;

            boxer.Left = 400;
        }
    }
}