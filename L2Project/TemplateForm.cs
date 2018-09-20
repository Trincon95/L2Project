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
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {

        }



        private void NewTempBox_Enter(object sender, EventArgs e)
        {
            if (NewTempBox.Text == "Design New Template Here")
            {
                NewTempBox.Text = "";
            }
        }

        private void NewTempBox_Leave(object sender, EventArgs e)
        {
            if (NewTempBox.Text == "")
            {
                NewTempBox.Text = "Design New Template Here";
            }
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            string templatetitle = NewTempTitlebox.Text;
        }

        public static string templatetitle
        {
            get { return templatetitle; }
        }
    }
}
