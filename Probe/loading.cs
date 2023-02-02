using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probe
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();

            
            label9.Parent = pictureBox2;
            label9.BackColor = Color.Transparent;
            pictureBox1.Parent= pictureBox2;

        }

    }
}
