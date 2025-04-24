using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_1
{
    public partial class Form1 : Form
    {
        private Random random;
        private double p;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            p = 0.5;
        }

        private void btAnswer_Click(object sender, EventArgs e)
        {
            double alpha = random.NextDouble(); // [0.0, 1.0)

            if (alpha < p)
            {
                lbAnswer.Text = "ДА!"; 
            }
            else
            {
                lbAnswer.Text = "НЕТ!"; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
