using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private void NewTempTitlebox_TextChanged(object sender, EventArgs e)
        {

            


        }
        private void Createbutton_Click(object sender, EventArgs e)
        {
            CreateNewFilePath(); //when you click on create button it will create the template folder

            string templatetitle = NewTempTitlebox.Text; 

            string fileName = @"c:\Templates\" + templatetitle + ".text"; // stores file text name into fileName variable. It will take the folder name, add title of template and text extension
       
            if (File.Exists(fileName)) //checks if FileName already exists
            {
                MessageBox.Show("Template name already exists"); //if fileName exists, it will not create a new template 

            }
            else
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName); // if it does not exist, it will create text file
                writer.Write(NewTempBox.Text); //Writes your template into text file
                writer.Close(); 

                MessageBox.Show("Your new template has been created!");
                this.Close();
            }
            
          
        }


        private void NewTempBox_TextChanged(object sender, EventArgs e)
        {
            string templateText = NewTempBox.Text;

        }

      
        private static void CreateNewFilePath() // creates template folder if it does not already exist
        {
            string Templates = @"c:\Templates";
           
            System.IO.Directory.CreateDirectory(Templates);
            
        }

       
    }
}
