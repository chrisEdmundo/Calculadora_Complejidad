using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = textBox1.Text.Split(' ');
            int Complejidad = 1;
            int NoLineas = 0;
            foreach (var word in words)
            {
                if ((word.Equals("if")) || (word.Equals("case")) || (word.Equals("foreach")) || (word.Equals("case")) || (word.Equals("||")) || (word.Equals("&&")) || (word.Equals("while")) || (word.Equals("for")))
                {
                    Complejidad += 1;
                }
            }
            foreach (var linea in textBox1.Lines)
            {
                NoLineas+=1;
            }
            textBox2.Text = Complejidad + "";
            textBox3.Text = NoLineas + "";
        }
    }
}
