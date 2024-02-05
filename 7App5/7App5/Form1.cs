using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7App5
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
               if (label1.Text.Trim() != "")
                label1.Text = W.F4(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SR.Service1Client W = new SR.Service1Client())
            {
                dataGridView1.DataSource = W.GetAllElements();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SR.Service1Client W = new SR.Service1Client())
            {
                dataGridView2.DataSource = W.GetElementByID(2020);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += TextBox_TextChanged;
            textBox2.TextChanged += TextBox_TextChanged;
        }
        private static void TextBox_TextChanged(object sender, EventArgs e)
        {
         TextBox textBox = (TextBox)sender;
            string cleanedText = Regex.Replace(textBox.Text, "[^0-9]", "");
            textBox.Text = cleanedText;
        }
    }
}
