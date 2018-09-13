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
    public partial class ticknum : Form
    {
        public ticknum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string ticknum = "";
            ticknum = ticknumbox.Text;
            MessageBox.Show(ticknum);

        }
    }
}
