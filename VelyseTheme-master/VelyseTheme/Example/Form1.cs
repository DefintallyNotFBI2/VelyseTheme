using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void velyseButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            long valnumericb = velyseNumericButton1.Value;
            timer1.Interval = (int)valnumericb;

            velyseCircularProgressBar1.Value += 1;
            velyseProgressBar1.Value += 1;
            if (velyseCircularProgressBar1.Value == 100 && velyseProgressBar1.Value == 100)
            {
                velyseCircularProgressBar1.Value = 0;
                velyseProgressBar1.Value = 0;
            }

            int userVal = int.Parse(velyseTextBox1.Text);
            velyseNumericButton1.Valueperclick = userVal;
        }

        private void velyseCheckbox1_Click(object sender, EventArgs e)
        {
            if(velyseCheckbox1.Checked == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void velyseCheckbox1_Click_1(object sender, EventArgs e)
        {
            if (!!velyseCheckbox1.Checked)
            {
                timer1.Stop();
                velyseCheckbox1.Text = "Start again";
            }
            else if(!velyseCheckbox1.Checked)
            {
                timer1.Start();
                velyseCheckbox1.Text = "Stop Progressbars";
            }
        }

        private void velyseTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
