using System;
using System.Windows.Forms;

namespace Probe
{
    public partial class closeBrowser : Form
    {
        public closeBrowser()
        {
            InitializeComponent();
        }

        private void pre_accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
