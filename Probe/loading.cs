using System.Drawing;
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
            pictureBox1.Parent = pictureBox2;

        }

    }
}
