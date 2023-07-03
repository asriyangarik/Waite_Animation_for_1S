using System.Drawing;
using System.Windows.Forms;

namespace WaiteAnimation1S
{
    public partial class MyWaiteForme : Form
    {
        Image _myPictureGif = Properties.Resources.NFCPAY;
        Image _myPictureWaiteGif = Properties.Resources.waite;
        Image _myPictureChakeGif = Properties.Resources.check;
        Image _myPictureWaite1Gif = Properties.Resources.waite1;
        Image _myPictureWaite2Gif = Properties.Resources.PLZWaite;
        Image _myPictureWaite3Gif = Properties.Resources.loading_gif;

        static MyWaiteForme _myWaiteInstanse;

        public MyWaiteForme()
        {          
            InitializeComponent();
          
        }

        public  void PosWaite()
        {
            this.Size = new Size(473, 370);
            pictureBox1.Size = new Size(453, 352);
         //   this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = _myPictureGif;
            ImageAnimator.Animate(_myPictureGif, null);
        }
        public void Waite()
        {
            this.Size = new Size(473, 130);
            pictureBox1.Size = new Size(453, 110);
          //  this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = _myPictureWaiteGif;           
            ImageAnimator.Animate(_myPictureWaiteGif, null);
        }

        public void chek()
        {
            this.Size = new Size(245, 223);
            pictureBox1.Size = new Size(221, 206);
          //  this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = _myPictureChakeGif;
            ImageAnimator.Animate(_myPictureChakeGif, null);
        }

        public void Waite1()
        {
            this.Size = new Size(552, 518);
            pictureBox1.Size = new Size(531, 500);
           // this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = _myPictureWaite1Gif;
            ImageAnimator.Animate(_myPictureWaite1Gif, null);
        }

        public void Waite2()
        {
            this.Size = new Size(676, 644);
            pictureBox1.Size = new Size(655, 626);
           // this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = _myPictureWaite2Gif;
            ImageAnimator.Animate(_myPictureWaite2Gif, null);
        }

        public void Waite3()
        {
            this.Size = new Size(274, 277);
            pictureBox1.Size = new Size(253, 261);
           // this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = _myPictureWaite3Gif;
            ImageAnimator.Animate(_myPictureWaite3Gif, null);
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
