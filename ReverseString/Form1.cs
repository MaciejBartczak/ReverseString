using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseString
{
    public partial class Form1 : Form
    {
        private string text;
        private string reversedText;


        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            if (text == textBox1.Text)
                return;
            label1.Location = new Point(textBox1.Location.X, textBox1.Height + textBox1.Location.Y + 20);
            reversedText = string.Empty;
            for (int i = textBox1.TextLength - 1; i > -1; i--)
            {
                reversedText += textBox1.Text.Substring(i, 1);
            }
            label1.Text = reversedText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 15)
            textBox1.Width = textBox1.TextLength * 6;
        }

        private void Cleaner_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            label1.Text = string.Empty;
        }
    }
}
