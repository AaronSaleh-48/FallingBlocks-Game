using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FallingBlocks
{
    public partial class frmTitleScreen : Form
    {
        Random rnd = new Random();
        public static SoundPlayer Player = new SoundPlayer(Properties.Resources._3D_Dot_Game_Heroes_Soundtrack___Breakout);

        public frmTitleScreen()
        {
            InitializeComponent();
            Player.Play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMain.BlockFallingSpeed = 1;
            new frmMain().Show(this);
            this.Hide();
        }

        private void tmrButtonColorChange_Tick(object sender, EventArgs e)
        {
            int RandomColor = rnd.Next(1, 5);
            switch (RandomColor)
            {
                case 1:
                    btnStart.BackColor = Color.Red;
                    break;

                case 2:
                    btnStart.BackColor = Color.Blue;
                    break;

                case 3:
                    btnStart.BackColor = Color.Green;
                    break;

                case 4:
                    btnStart.BackColor = Color.Yellow;
                    break;
            }
        }

        private void frmTitleScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
