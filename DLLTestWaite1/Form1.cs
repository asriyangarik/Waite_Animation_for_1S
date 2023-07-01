using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaiteAnimation1S;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            MyObject.StopeMyWaite();
        }

        private void button3_Click(object sender, EventArgs e)
        {
     
            MyObject.StartWaite();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyObject.StartChake();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
           
           
        }
    }
}
