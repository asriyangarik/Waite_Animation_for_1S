using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaiteAnimation1S
{
    public partial class MyWaiteForme : Form
    {
        Image _myPictureGif = Properties.Resources.NFCPAY;
        
        public MyWaiteForme()
        {
           
            InitializeComponent();
            // EventHandler zz = (sender, e) => { };
            pictureBox1.Image = _myPictureGif;
            ImageAnimator.Animate(_myPictureGif, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
