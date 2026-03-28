using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octo
{
    public partial class frmGameInfo : Form
    {
        public frmGameInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGameInfo_Load(object sender, EventArgs e)
        {
            Animations.clsAnimation.Transparent(label1, pbBlue);
            Animations.clsAnimation.Transparent(label2, pbBlue);
            Animations.clsAnimation.Transparent(label3, pbBlue);
            Animations.clsAnimation.Transparent(label4, pbBlue);
            Animations.clsAnimation.Transparent(pictureBox2, pbBlue);

        }
    }
}
