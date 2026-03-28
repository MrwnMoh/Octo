using Animations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Octo
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();


            Animations.clsAnimation.Transparent(btnPlay, pbPanel);
            Animations.clsAnimation.Transparent(btnInfo, pbPanel);


        }

        bool IsVsAi = false;
        bool IsAivsAi = false;

        int Speed = 250;
        private void tbPlayer2_TextChanged(object sender, EventArgs e)
        {
            LpMaxPlayer2.Text = tbPlayer2.Text.Length.ToString();
        }

        private void tbPlayer1_TextChanged(object sender, EventArgs e)
        {
            LpMaxPlayer1.Text = tbPlayer1.Text.Length.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlay frm = new frmPlay(tbPlayer1.Text,tbPlayer2.Text,this,IsVsAi,chkAiAnimation.Checked, IsAivsAi,Speed);
            frm.Show();
            this.Hide();
        }

        private void rbPlayerVsAi_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPlayerVsAi.Checked)
            {
                tbPlayer2.Enabled = false;
                tbPlayer2.Text = "Ai";

                cbAiSpeed.Visible = true;
                lpSpeed.Visible = true;

                IsVsAi = true;
                chkAiAnimation.Visible = true;
            }
            else
            {
                tbPlayer2.Enabled = true;
                tbPlayer2.Text = "Player2";

                cbAiSpeed.Visible = false;
                lpSpeed.Visible = false;

                IsVsAi = false;
                chkAiAnimation.Visible = false;

            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAivsAi.Checked)
            {
                tbPlayer1.Enabled = false;
                tbPlayer2.Enabled = false;
                tbPlayer1.Text = "Ai 1";
                tbPlayer2.Text = "Ai 2";

                cbAiSpeed.Visible = true;
                lpSpeed.Visible = true;

                IsVsAi = true;
                IsAivsAi = true;

                chkAiAnimation.Visible = true;

                chkAiAnimation.Checked = true;
                chkAiAnimation.Enabled = false;
            }
            else
            {
                tbPlayer1.Enabled = true;
                tbPlayer2.Enabled = true;
                tbPlayer1.Text = "Player 1";
                tbPlayer2.Text = "Player 2";

                cbAiSpeed.Visible = false;
                lpSpeed.Visible = false;

                IsVsAi = false;
                IsAivsAi = false;

                chkAiAnimation.Visible = false;

                chkAiAnimation.Enabled = true;


            }
        }

        private void cbAiSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAiSpeed.SelectedIndex == 0)
                Speed = 250;
            else if (cbAiSpeed.SelectedIndex == 1)
                Speed = 150;
            else
                Speed = 50;


        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            cbAiSpeed.SelectedIndex = 0;
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            clsAnimation.AnimationOnHover(sender, e, 5);
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            clsAnimation.AnimationOnUnHover(sender, e, 5);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmGameInfo frm = new frmGameInfo();
            frm.ShowDialog();
        }
    }
}
