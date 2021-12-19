using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIP_Zonnevolger
{
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }

        private void rdbAutomatisch_CheckedChanged(object sender, EventArgs e)
        {
            grpBesturing.Enabled = false;
        }

        private void rdbManueel_CheckedChanged(object sender, EventArgs e)
        {
            grpBesturing.Enabled = true;
        }
    }
}
