using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class V : Form
    {
        int value;
        int result;
        public V()
        {
            InitializeComponent();
        }

        private void V_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            value = int.Parse(textBox1.Text);
        }

        private void outB_Click(object sender, EventArgs e)
        {
            if ((inCb.SelectedIndex==0 && outCb.SelectedIndex == 0) || (inCb.SelectedIndex == 1 && outCb.SelectedIndex == 1) || (inCb.SelectedIndex == 2 && outCb.SelectedIndex == 2) || (inCb.SelectedIndex == 3 && outCb.SelectedIndex == 3))
            {
                textBox2.Text = value.ToString();
            } else if (inCb.SelectedIndex == 0 && outCb.SelectedIndex == 1)
            {
                result = value * 1000;
                textBox2.Text = result.ToString();
            }
            else if (inCb.SelectedIndex == 0 && outCb.SelectedIndex == 2)
            {
                result = value * 1000000;
                textBox2.Text = result.ToString();
            }
            else if (inCb.SelectedIndex == 0 && outCb.SelectedIndex == 3)
            {
                result = value * 1000000000;
                textBox2.Text = result.ToString();
            }
        }

        private void inCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = 0;
            result = 0;
        }

        private void outCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
