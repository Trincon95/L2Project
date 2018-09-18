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
        public class Initial
        {
            public void YNbox_TextChanged(object sender, EventArgs e)
            {

            }
        }

            public void templatedropdown_Enter(object sender, EventArgs e)
            {
                if (templatedropdown.Text == "Choose Template")
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

            private void templatedropdown_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {
                ticknum TN = new ticknum();
                TN.ShowDialog();
            }

            private void yourname_Click(object sender, EventArgs e)
            {
                yourname YN = new yourname();
                YN.ShowDialog();
            }

            private void Client_Click(object sender, EventArgs e)
            {
                clientname CN = new clientname();
                CN.ShowDialog();
            }


 
        }
    
    
}
