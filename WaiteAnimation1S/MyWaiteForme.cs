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
        Image _myPictureWaiteGif = Properties.Resources.waite;
        Image _myPictureChakeGif = Properties.Resources.check;

        static MyWaiteForme _myWaiteInstanse;

        public MyWaiteForme()
        {
           
            InitializeComponent();

        }

        public void PosWaite()
        {
            pictureBox1.Image = _myPictureGif;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            ImageAnimator.Animate(_myPictureGif, null);
        }
        public void Waite()
        {
            pictureBox1.Image = _myPictureWaiteGif;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            ImageAnimator.Animate(_myPictureGif, null);
        }

        public void chek()
        {
            pictureBox1.Image = _myPictureChakeGif;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            ImageAnimator.Animate(_myPictureGif, null);
        }

        public static MyWaiteForme GetMyWaiteInstanse()
        {
            if (_myWaiteInstanse == null)
            {
                _myWaiteInstanse = new MyWaiteForme();

            }
            return _myWaiteInstanse;
        }

    }
}
