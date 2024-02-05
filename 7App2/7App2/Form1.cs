using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SR.Service1Client W = new SR.Service1Client())
            {
             if (textBox1.Text.Trim() != "")
                {

                    string y = W.IsLoginFree(textBox1.Text).ToString();
                    label1.Text = y;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SR.Service1Client W = new SR.Service1Client())
            {
                label2.Text = W.MyIPAddress();
            }
        }
    }
}
