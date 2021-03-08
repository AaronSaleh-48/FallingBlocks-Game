using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingBlocks
{
    public partial class frmMain : Form
    {
        //Variablendeklaration
        Random rnd = new Random();
        int BlockFallingSpeed = 1;
        int MovingSpeed = 20;
        int PlayerFallingSpeed = 10;
        public static int Score;
        bool right = false;
        bool left = false;

        public frmMain()
        {
            InitializeComponent();
            frmTitleScreen.Player.Play();
            pbPlayer.BackColor = Color.Transparent;
            pbBlock.BackColor = Color.Transparent;
            lblScoreText.BackColor = Color.Transparent;
            lblScore.BackColor = Color.Transparent;
        }

        private void tmrGravitation_Tick(object sender, EventArgs e)
        {
            //Block Falling
            if (!pbBlock.Bounds.IntersectsWith(pbGround.Bounds))
            {
                pbBlock.Top += BlockFallingSpeed;
            }

            //Block Respawning & Speed increase
            if (pbBlock.Bounds.IntersectsWith(pbGround.Bounds))
            {
                BlockFallingSpeed++;

                //Score
                Score++;
                lblScore.Text = Convert.ToString(Score);

                int BlockRespawnPoint = rnd.Next(1, 600);
                pbBlock.Location = new Point(BlockRespawnPoint, -100);
            }

            //Player Gravity
            if (!pbPlayer.Bounds.IntersectsWith(pbGround.Bounds))
            {
                pbPlayer.Top += PlayerFallingSpeed;
            }
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            //Player Moving
            if (right == true)
            {
                pbPlayer.Left += MovingSpeed;
            }

            if (left == true)
            {
                pbPlayer.Left -= MovingSpeed;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //Check Key Pressed
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            //Check Key Pressed
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }

        private void tmrCollision_Tick(object sender, EventArgs e)
        {
            //Check Player Touches Block
            if (pbPlayer.Bounds.IntersectsWith(pbBlock.Bounds))
            {
                this.Hide();
                new frmEndScreen().Show(this);
                tmrCollision.Enabled = false;
                BlockFallingSpeed = 0;
            }

            //Check Player Toucher Wall
            if (pbPlayer.Bounds.IntersectsWith(pbWallL.Bounds))
            {
                left = false;
            }
            else if (pbPlayer.Bounds.IntersectsWith(pbWallR.Bounds))
            {
                right = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pbGround_Click(object sender, EventArgs e)
        {

        }

        private void pbBlock_Click(object sender, EventArgs e)
        {

        }
    }
}
