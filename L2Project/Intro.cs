using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2Project
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void templatedropdown_Enter(object sender, EventArgs e)
        {
            if (templatedropdown.Text=="Choose Template")
            {
                templatedropdown.Text = "";
            }
        }

        private void templatedropdown_Leave(object sender, EventArgs e)
        {
            if (templatedropdown.Text == "")
            {
                templatedropdown.Text = "Choose Template";
                templatedropdown.ForeColor = Color.DarkGoldenrod;
            }
        }
    }
}
