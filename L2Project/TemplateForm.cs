using round2project;
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

        private Primary form1;
        public TemplateForm()
        {
            InitializeComponent();
        }
        public TemplateForm(Primary parentform)
        {
            form1 = parentform;
            InitializeComponent();
        }


        private void TemplateForm_Load(object sender, EventArgs e)
        {

        }


        private void NewTempBox_Enter(object sender, EventArgs e)
        {
            if (NewTempBox.Text == "Enter Template Text Here...")
            {
                NewTempBox.Text = "";
                NewTempBox.ForeColor = Color.Black;
            }
        }

        private void NewTempBox_Leave(object sender, EventArgs e)
        {
            if (NewTempBox.Text == "")
            {
                NewTempBox.Text = "Enter Template Text Here...";
            }
        }
        private void NewTempTitlebox_TextChanged(object sender, EventArgs e)
        {




        }
        private void Createbutton_Click(object sender, EventArgs e)
        {
            string strComputerName = Environment.MachineName.ToString();

            strComputerName = strComputerName.Substring(0, strComputerName.Length - 2);



            CreateNewFilePath(); //when you click on create button it will create the template folder

            string templatetitle = NewTempTitlebox.Text;

            string fileName = @"C:\Users\%GUID%\AppData\Local\SupportTemplates\".Replace("%GUID%", strComputerName)  + templatetitle + ".txt"; //stores file text name into fileName variable. It will take the folder name, add title of template and text extension

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


                form1.Refresh_form();
                    this.Hide();               
                  //  round2project.Primary F = new round2project.Primary();
                  //  F.ShowDialog();
                     
        }

    } 

        private void NewTempBox_TextChanged(object sender, EventArgs e)
        {
            string templateText = NewTempBox.Text;

        }

      
        private static void CreateNewFilePath() // creates template folder if it does not already exist
        {
            
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void NewTempTitlebox_Enter(object sender, EventArgs e)
        {
            if (NewTempTitlebox.Text == "Enter template title")
            {
                NewTempTitlebox.Text = "";
                NewTempTitlebox.ForeColor = Color.Black;
            }
        }

        private void NewTempTitlebox_Leave(object sender, EventArgs e)
        {
            if (NewTempTitlebox.Text == "")
            {
                NewTempTitlebox.Text = "Enter template title";
            }
        }
    }
}
