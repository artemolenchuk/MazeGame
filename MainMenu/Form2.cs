using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GameClassLibrary;

namespace MainMenu
{
    public partial class Form2 : Form
    {
        private Player player;
        private Wall[] walls;
        private HashSet<Keys> keysPressed = new HashSet<Keys>();
        private Finish finish;
        private PlayerProgress playerProgress;

        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            playerProgress = new PlayerProgress();

            InitializePlayer();
            InitializeLevel1();

            this.DoubleBuffered = true;
            this.Paint += Form2_Paint;
            this.KeyDown += Form2_KeyDown;
            this.KeyUp += Form2_KeyUp;
            this.Focus();

            InitializeTimer();
        }

        private void InitializePlayer()
        {
            Image playerImage = Properties.Resources.player;
            player = new Player(260, 150, 10, playerImage);
        }

        private void InitializeLevel1()
        {
            Sound.StopFinishSound();
            Sound.PlayFinishSound();

            labelNumberOfLavel.Text = "1";

            Image HorisontalwallImage = Properties.Resources.wall_h;
            Image VerticalwallImage = Properties.Resources.wall_v;

            walls = new Wall[25];
            walls[0] = new Wall(230, 120, 726, 10, HorisontalwallImage);
            walls[1] = new Wall(230, 880, 726, 10, HorisontalwallImage);
            walls[2] = new Wall(230, 120, 10, 390, VerticalwallImage);
            walls[3] = new Wall(1665, 120, 10, 390, VerticalwallImage);
            walls[4] = new Wall(248, 550, 150, 10, HorisontalwallImage);
            walls[5] = new Wall(380, 260, 10, 148, VerticalwallImage);
            walls[6] = new Wall(530, 140, 10, 138, VerticalwallImage);
            walls[7] = new Wall(690, 140, 10, 70, VerticalwallImage);
            walls[8] = new Wall(400, 720, 150, 10, HorisontalwallImage);
            walls[9] = new Wall(550, 396, 80, 10, HorisontalwallImage);
            walls[10] = new Wall(690, 398, 10, 171, VerticalwallImage);
            walls[11] = new Wall(1140, 140, 10, 70, VerticalwallImage);
            walls[12] = new Wall(1048, 550, 230, 10, HorisontalwallImage);
            walls[13] = new Wall(710, 550, 80, 10, HorisontalwallImage);
            walls[14] = new Wall(870, 400, 320, 10, HorisontalwallImage);
            walls[15] = new Wall(870, 720, 100, 10, HorisontalwallImage);
            walls[16] = new Wall(1505, 720, 80, 10, HorisontalwallImage);
            walls[17] = new Wall(1505, 265, 80, 10, HorisontalwallImage);
            walls[18] = new Wall(1240, 720, 60, 10, HorisontalwallImage);
            walls[19] = new Wall(1040, 260, 50, 10, HorisontalwallImage);
            walls[20] = new Wall(1330, 260, 10, 70, VerticalwallImage);
            walls[21] = new Wall(860, 270, 10, 150, VerticalwallImage);
            walls[22] = new Wall(870, 740, 10, 70, VerticalwallImage);
            walls[23] = new Wall(1340, 740, 10, 70, VerticalwallImage);
            walls[24] = new Wall(1230, 570, 10, 85, VerticalwallImage);

            Image finishImage = Properties.Resources.Finish;
            finish = new Finish(1550, 760, 100, 100, finishImage);
        }

        public void InitializeLevel2()
        {
            Sound.StopFinishSound();
            Sound.PlayFinishSound();

            InitializePlayer();

            labelNumberOfLavel.Text = "2";

            Image HorisontalwallImage = Properties.Resources.wall_h;
            Image VerticalwallImage = Properties.Resources.wall_v;

            walls = new Wall[21];
            walls[0] = new Wall(230, 120, 726, 10, HorisontalwallImage);
            walls[1] = new Wall(230, 880, 726, 10, HorisontalwallImage);
            walls[2] = new Wall(230, 120, 10, 390, VerticalwallImage);
            walls[3] = new Wall(1665, 120, 10, 390, VerticalwallImage);
            walls[4] = new Wall(248, 560, 230, 10, HorisontalwallImage);
            walls[5] = new Wall(380, 420, 10, 80, VerticalwallImage);
            walls[6] = new Wall(690, 420, 10, 150, VerticalwallImage);
            walls[7] = new Wall(680, 140, 10, 70, VerticalwallImage);
            walls[8] = new Wall(400, 720, 550, 10, HorisontalwallImage);
            walls[9] = new Wall(380, 260, 150, 10, HorisontalwallImage);
            walls[10] = new Wall(540, 280, 10, 70, VerticalwallImage);
            walls[11] = new Wall(860, 560, 405, 10, HorisontalwallImage);
            walls[12] = new Wall(1020, 280, 10, 145, VerticalwallImage);
            walls[13] = new Wall(860, 280, 10, 75, VerticalwallImage);
            walls[14] = new Wall(690, 410, 90, 10, HorisontalwallImage);
            walls[15] = new Wall(860, 260, 10, 85, VerticalwallImage);
            walls[16] = new Wall(1020, 261, 90, 10, HorisontalwallImage);
            walls[17] = new Wall(1180, 280, 10, 70, VerticalwallImage);
            walls[18] = new Wall(1350, 270, 10, 70, VerticalwallImage);
            walls[19] = new Wall(1200, 400, 160, 10, HorisontalwallImage);
            walls[20] = new Wall(1520, 261, 80, 10, HorisontalwallImage);

            Image finishImage = Properties.Resources.Finish;
            finish = new Finish(1130, 760, 100, 100, finishImage);
        }

        public void InitializeLevel3()
        {
            Sound.StopFinishSound();
            Sound.PlayFinishSound();

            labelNumberOfLavel.Text = "3";

            InitializePlayer();

            Image HorisontalwallImage = Properties.Resources.wall_h;
            Image VerticalwallImage = Properties.Resources.wall_v;

            walls = new Wall[26];
            walls[0] = new Wall(230, 120, 726, 10, HorisontalwallImage);
            walls[1] = new Wall(230, 880, 726, 10, HorisontalwallImage);
            walls[2] = new Wall(230, 120, 10, 390, VerticalwallImage);
            walls[3] = new Wall(1665, 120, 10, 390, VerticalwallImage);
            walls[4] = new Wall(700, 140, 10, 70, VerticalwallImage);
            walls[5] = new Wall(380, 280, 10, 70, VerticalwallImage);
            walls[6] = new Wall(540, 280, 10, 140, VerticalwallImage);
            walls[7] = new Wall(860, 280, 10, 200, VerticalwallImage);
            walls[8] = new Wall(1010, 400, 10, 80, VerticalwallImage);
            walls[9] = new Wall(1515, 430, 10, 230, VerticalwallImage);
            walls[10] = new Wall(1160, 140, 10, 70, VerticalwallImage);
            walls[11] = new Wall(1330, 290, 10, 70, VerticalwallImage);
            walls[12] = new Wall(1010, 280, 10, 70, VerticalwallImage);
            walls[13] = new Wall(860, 560, 10, 80, VerticalwallImage);
            walls[14] = new Wall(380, 740, 10, 70, VerticalwallImage);
            walls[15] = new Wall(1350, 560, 10, 85, VerticalwallImage);
            walls[16] = new Wall(700, 560, 10, 160, VerticalwallImage);
            walls[17] = new Wall(1515, 140, 10, 70, VerticalwallImage);
            walls[18] = new Wall(1010, 415, 263, 10, HorisontalwallImage);
            walls[19] = new Wall(700, 270, 90, 10, HorisontalwallImage);
            walls[20] = new Wall(380, 550, 170, 10, HorisontalwallImage);
            walls[21] = new Wall(250, 420, 75, 10, HorisontalwallImage);
            walls[22] = new Wall(560, 410, 75, 10, HorisontalwallImage);
            walls[23] = new Wall(380, 721, 90, 10, HorisontalwallImage);
            walls[24] = new Wall(860, 710, 180, 10, HorisontalwallImage);
            walls[25] = new Wall(1010, 550, 180, 10, HorisontalwallImage);

            Image finishImage = Properties.Resources.Finish;
            finish = new Finish(1550, 760, 100, 100, finishImage);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            keysPressed.Add(e.KeyCode);
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
        }

        private void NextLevel()
        {
            if (finish.IsPlayerOnFinish(player))
            {
                int currentLevel = int.Parse(labelNumberOfLavel.Text);
                playerProgress.UnlockLevel(currentLevel + 1);

                if (currentLevel == 3)
                {
                    pictureBoxButtonMainMenu.Visible = true;
                    pictureBoxEndGame.Visible = true;
                }
                else
                {
                    int nextLevel = currentLevel + 1;
                    switch (nextLevel)
                    {
                        case 2:
                            InitializeLevel2();
                            break;
                        case 3:
                            InitializeLevel3();
                            break;
                        default:
                            break;
                    }
                    labelNumberOfLavel.Text = nextLevel.ToString();
                }

            }
        }

        private void MovePlayer()
        {
            int deltaX = 0;
            int deltaY = 0;

            if (keysPressed.Contains(Keys.Up))
                deltaY -= player.Speed;
            if (keysPressed.Contains(Keys.Down))
                deltaY += player.Speed;
            if (keysPressed.Contains(Keys.Left))
                deltaX -= player.Speed;
            if (keysPressed.Contains(Keys.Right))
                deltaX += player.Speed;

            int proposedX = player.X + deltaX;
            int proposedY = player.Y + deltaY;

            if (!CheckWallCollision(new Player(proposedX, proposedY, player.Speed, player.Image), Direction.Up) &&
                !CheckWallCollision(new Player(proposedX, proposedY, player.Speed, player.Image), Direction.Down) &&
                !CheckWallCollision(new Player(proposedX, proposedY, player.Speed, player.Image), Direction.Left) &&
                !CheckWallCollision(new Player(proposedX, proposedY, player.Speed, player.Image), Direction.Right))
            {
                player.X = proposedX;
                player.Y = proposedY;
            }

            NextLevel();
            this.Invalidate();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(player.Image, player.X, player.Y);
            foreach (Wall wall in walls)
            {
                e.Graphics.DrawImage(wall.Image, wall.X, wall.Y, wall.Width, wall.Height);
            }
            e.Graphics.DrawImage(finish.Image, finish.X, finish.Y, finish.Width, finish.Height);
        }

        private bool CheckWallCollision(Player player, Direction direction)
        {
            foreach (Wall wall in walls)
            {
                Rectangle wallBounds = new Rectangle(wall.X, wall.Y, wall.Width, wall.Height);

                switch (direction)
                {
                    case Direction.Up:
                        int topPoint = player.Y - player.Speed + 10;
                        if (wallBounds.IntersectsWith(new Rectangle(player.X, topPoint, player.Width, player.Speed)))
                            return true;
                        break;
                    case Direction.Down:
                        int bottomPoint = player.Y + player.Height + player.Speed;
                        if (wallBounds.IntersectsWith(new Rectangle(player.X, bottomPoint, player.Width, player.Speed)))
                            return true;
                        break;
                    case Direction.Left:
                        int leftPoint = player.X - player.Speed + 10;
                        if (wallBounds.IntersectsWith(new Rectangle(leftPoint, player.Y, player.Speed, player.Height)))
                            return true;
                        break;
                    case Direction.Right:
                        int rightPoint = player.X + player.Width + player.Speed;
                        if (wallBounds.IntersectsWith(new Rectangle(rightPoint, player.Y, player.Speed, player.Height)))
                            return true;
                        break;
                }
            }

            return false;
        }

        private void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 20;
            timer.Tick += (sender, e) => MovePlayer();
            timer.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Sound.IsMusicEnabled)
            {
                Sound.PlayLevelTheme();
                Sound.StopMenuTheme();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sound.StopClickSound();
            Sound.PlayClickSound();
            Sound.PlayMenuTheme();
            Sound.StopLevelTheme();

            Form0 form0 = new Form0();
            form0.FormClosed += (s, args) => this.Close();
            form0.Show();
            this.Hide();
        }

        private void pictureBoxButtonHome_Click(object sender, EventArgs e)
        {
            Sound.StopClickSound();
            Sound.PlayClickSound();
            Sound.PlayMenuTheme();
            Sound.StopLevelTheme();

            Form0 form0 = new Form0();
            form0.FormClosed += (s, args) => this.Close();
            form0.Show();
            this.Hide();
        }

        private void pictureBoxButtonMainMenu_Click(object sender, EventArgs e)
        {
            Sound.StopClickSound();
            Sound.PlayClickSound();
            Sound.PlayMenuTheme();
            Sound.StopLevelTheme();

            Form0 form0 = new Form0();
            form0.FormClosed += (s, args) => this.Close();
            form0.Show();
            this.Hide();
        }
    }
}