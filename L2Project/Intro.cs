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

        private void templatedropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Yournamebox_Enter(object sender, EventArgs e)
        {
            if (Yournamebox.Text == "Your Name")
            {
                Yournamebox.Text = "";
            }
        }

        private void Yournamebox_Leave(object sender, EventArgs e)
        {
            if (Yournamebox.Text == "")
            {
                Yournamebox.Text = "Your Name";
                Yournamebox.ForeColor = Color.DarkRed;
            }
        }

        private void Ticket_Enter(object sender, EventArgs e)
        {
            if (Ticket.Text == "Ticket #")
            {
                Ticket.Text = "";
            }
        }

        private void Ticket_Leave(object sender, EventArgs e)
        {
            if (Ticket.Text == "")
            {
                Ticket.Text = "Ticket #";
            }
        }

        private void Clientname_Enter(object sender, EventArgs e)
        {
            if (Clientname.Text == "Client Name")
            {
                Clientname.Text = "";
            }
        }

        private void Clientname_Leave(object sender, EventArgs e)
        {
            if (Clientname.Text == "")
            {
                Clientname.Text = "Client Name";
            }
        }
    }
}
