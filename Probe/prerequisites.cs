using System;
using System.Windows.Forms;

namespace Probe
{
    public partial class prerequisites : Form
    {
        public prerequisites()
        {
            InitializeComponent();
        }

        private void pre_accept_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new MainForm();
            frm.Show();
        }

        private void pre_deny_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
