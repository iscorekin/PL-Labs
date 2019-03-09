using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        private int amount = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (amount >= 1)
            {
                if (radioButton1.Checked)
                    label1.Text = (amount * 20).ToString();
                if (radioButton2.Checked)
                    label1.Text = (amount * 30).ToString();
                if (radioButton3.Checked)
                    label1.Text = (amount * 40).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out amount);
        }
    }
}
