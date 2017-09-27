using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q_and_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + textbox1.Text + " Question: 17-2x8=1, Yes or No?");
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct answer, " + textbox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect answer, " + textbox1.Text);
        }
    }
}
