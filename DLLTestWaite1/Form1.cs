using System;
using System.Windows.Forms;
using WaiteAnimation1S;

namespace DLLTestWaite1
{
    public partial class Form1 : Form
    {
        WaiteAnimation MyObject = new WaiteAnimation();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyObject.StartMyWaitePOS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyObject.StartWaite();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyObject.StartChake();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyObject.StopeMyWaite();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyObject.StartWaite1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyObject.StartWaite2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyObject.StartWaite3();
        }
    }
}
