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
    public partial class frmEndScreen : Form
    {
        SoundPlayer Player = new SoundPlayer(Properties.Resources.Boxing____Training);

        public frmEndScreen()
        {
            InitializeComponent();
            Player.Play();

            //Score
            lblScore.Text = Convert.ToString(frmMain.Score);
        }

        private void frmEndScreen_Load(object sender, EventArgs e)
        {

        }

        private void frmEndScreen_KeyDown(object sender, KeyEventArgs e)
        {
            //Restart
            if (e.KeyCode == Keys.Enter)
            {
                new frmTitleScreen().Show(this);
                this.Hide();
            }

            //Escape
            if (e.KeyCode == Keys.Escape)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
