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
    public partial class yourname : Form
    {
        public yourname()
        {
            InitializeComponent();
        }
        public static class Initial
        {
            
           
        }
            public void YNGo_Click(object sender, EventArgs e)
            {
                this.Hide();
                string YName = "";
                YName = yournamebox.Text;
         
            }
        
    }
}