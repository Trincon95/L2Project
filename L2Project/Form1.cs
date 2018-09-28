using L2Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace round2project
{
    public partial class Primary : Form
    {
        public Primary()
        {
            InitializeComponent();

        }



        public void Cnamebox_Enter(object sender, EventArgs e) // Creates Placeholder
        {
            if (Cnamebox.Text == "Enter Customers Name")
            {
                Cnamebox.Text = "";
                Cnamebox.ForeColor = Color.Black;

            }
        }

        public void Cnamebox_Leave(object sender, EventArgs e) //Creates Placeholder
        {
            if (Cnamebox.Text == "")
            {
                Cnamebox.Text = "Enter Customers Name";
                
            }
        }

        public void Tnumbox_Enter(object sender, EventArgs e) // Creates Placeholder
        {
            if (Tnumbox.Text == "Enter Ticket #")
            {
                Tnumbox.Text = "";
                Tnumbox.ForeColor = Color.Black;
            }
        }

        public void Tnumbox_Leave(object sender, EventArgs e) //Creates Placeholder
        {
            if (Tnumbox.Text == "")
            {
                Tnumbox.Text = "Enter Ticket #";
            }
        }
        private void MoCbox_Enter_1(object sender, EventArgs e)
        {
            if (MoCbox.Text == "Hangouts, SameTime, ETC")
            {
                MoCbox.Text = "";
                MoCbox.ForeColor = Color.Black;
            }
        }

        private void MoCbox_Leave_1(object sender, EventArgs e)
        {
            if (MoCbox.Text == "")
            {
                MoCbox.Text = "Hangouts, SameTime, ETC";
            }
        }
        private void currentstatbox_Enter_1(object sender, EventArgs e)
        {
            if (currentstatbox.Text == "Current status of issue")
            {
                currentstatbox.Text = "";
                currentstatbox.ForeColor = Color.Black;
            }
        }

        private void currentstatbox_Leave_1(object sender, EventArgs e)
        {
            if (currentstatbox.Text == "")
            {
                currentstatbox.Text = "Current status of issue";
            }
        }


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Suspension template text boxes visibility
        {

            if (comboBox1.Text == "Suspension")
            {
                MoClabel.Show();
                MoCbox.Show();
                Currentstatuslabel.Show();
                currentstatbox.Show();
              if (currentstatbox.Text == "Current status of issue")
                {
                    currentstatbox.Text = "";
                    currentstatbox.ForeColor = Color.Black;
                }
                if (currentstatbox.Text == "")
                {
                    currentstatbox.Text = "Current status of issue";
                }

            }
            if (comboBox1.Text.Contains("Suspension") == false)
            {
                MoCbox.Hide();
                MoClabel.Hide();
                currentstatbox.Hide();
                Currentstatuslabel.Hide();
            }

        }

        public void Copybut_Click(object sender, EventArgs e)
        {
            string comboBoxValue = comboBox1.SelectedItem.ToString();

            if (comboBox1.Text == "Hangouts message")
            {
                string hangouts = "Hey " + Cnamebox.Text + ",";
                string hangouts1 = "My name is " + Ynamecombo.Text + ". I am with L2 Aura Support.  Please advise me when it is a good time to resolve your issue INC" + Tnumbox.Text + ". ";
                string hangouts2 = hangouts + "\n" + "\n" + hangouts1;

                previewTextLabel.Text = hangouts2;
                Clipboard.SetText(hangouts2);

            }
            if (comboBox1.Text == "Suspension")
            {

                string username = "Username: " + Cnamebox.Text;
                string modeofcom = "Mode of Communication: " + MoCbox.Text;
                string status = "Analysis Performed & Current Status: " + currentstatbox.Text;
                string Nextaction = "Next Action Item: Awaiting response from " + Cnamebox.Text + " with a good time to discuss the issue.";
                string group = "Team to perform next action item: PWC IT APP ASP - L2 ASSURANCE";
                DateTime ETA = DateTime.Now;
                string eta = "ETA: " + ETA.AddDays(2).ToString();

                string suspension = username + "\n" + modeofcom + "\n" + status + "\n" + Nextaction + "\n" + group + "\n" + eta;
                Clipboard.SetText(suspension);
                previewTextLabel.Text = suspension;
            }
            if (comboBox1.Text == "Primary Email")
            {
                string subject = "Aura Issue INC#" + Tnumbox.Text + "\n" + "\n";
                string pemail = "Hi " + Cnamebox.Text + "," + "\n" + "\n" + "Hope you are doing well!" + "\n" + "\n" + "I am with L2 Aura Support. With regard to the incident raised by you, we would further request to meet remotely or WebEx in order to investigate the issue." + "\n" + "\n";
                string pemail1 = "Could you please Email or Sametime me your convenient time to work on the issue?" + "\n";
                string pemail2 = "Kindly 'reply to all',  so any one from team 'TCS ASR App Support Aura' can assist you in my absence." + "\n";
                string pemail3 = "Thanks,";
                string primarye = subject + pemail + pemail1 + pemail2 + "\n" + pemail3;
                Clipboard.SetText(primarye);
                previewTextLabel.Text = primarye;
            }
            if (comboBox1.Text == "Reminder Email")
            {
                string subject = "*(Reminder) Aura Issue INC#" + Tnumbox.Text + "\n" + "\n";
                string semail = "Hi " + Cnamebox.Text + "," + "\n" + "\n" + "Hope you are doing well!" + "\n" + "\n" + "I am with L2 Aura Support. With regard to the incident raised by you, we would further request to meet remotely or WebEx in order to investigate the issue." + "\n";
                string semail1 = "Could you please Email or Sametime me your convenient time to work on the issue?" + "\n" + "\n";
                string semail2 = "Kindly 'reply to all',  so any one from team 'TCS ASR App Support Aura' can assist you in my absence." + "\n";
                string semail3 = "Thanks,";
                string secondarye = subject + semail + semail1 + semail2 + "\n" + semail3;
                Clipboard.SetText(secondarye);
                previewTextLabel.Text = secondarye;
            }
            if (comboBox1.Text == "IP address")
            {
                string ip = "May i have your IP address please?" + "\n" + "\n";
                string ip1 = "This can be found by Search > My Computer info";
                string ipadd = ip + ip1;
                Clipboard.SetText(ipadd);
                previewTextLabel.Text = ipadd;

            }else if (comboBox1.Text == comboBoxValue)

             {
                string text = System.IO.File.ReadAllText(@"\Templates\" + comboBoxValue + ".txt");
                Clipboard.SetText(text);
                previewTextLabel.Text = text; 
            }

            CopyLabel.Show();
        }



        private void resetbutton_Click(object sender, EventArgs e)
        {

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
           
           
           previewTextLabel.Text = "Click Copy to view your Template";
            


            CopyLabel.Hide();

            if (currentstatbox.Text == "Current status of issue")
            {
                currentstatbox.Text = "";         
            }

            if (currentstatbox.Text == "")
            {
                currentstatbox.Text = "Current status of issue";
            }


            if (Cnamebox.Text == "Enter Customers Name")
            {
                Cnamebox.Text = "";
            }

            if (Cnamebox.Text == "")
            {
                Cnamebox.Text = "Enter Customers Name";
            }

            if (Tnumbox.Text == "Enter Ticket #")
            {
                Tnumbox.Text = "";
            }

            if (Tnumbox.Text == "")
            {
                Tnumbox.Text = "Enter Ticket #";
            }
          
            if (MoCbox.Text == "Hangouts, SameTime, ETC")
                {
                    MoCbox.Text = "";
                }
            
            if (MoCbox.Text == "")
                {
                    MoCbox.Text = "Hangouts, SameTime, ETC";
                }
            


        }

        private void Primary_Load(object sender, EventArgs e)
        {

            string Templates = @"c:\Templates";

            System.IO.Directory.CreateDirectory(Templates);

            DropDown_Add();
            //List<string> fileList = fileArray.ToList();
            //  string templateName = Path.GetFileNameWithoutExtension(name);
          

        }


        private void CreateNewButton_Click(object sender, EventArgs e)
        {

            L2Project.TemplateForm Tf = new TemplateForm();
            Tf.ShowDialog();
            this.Close();

        }

        private void Cnamebox_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        }

        private void DropDown_Add()
        {
            string[] fileArray = Directory.GetFiles(@"c:\Templates");
            
            string templateName = Path.GetFileNameWithoutExtension(@"c:\Templates");

                  foreach (string name in fileArray)


                    comboBox1.Items.Add(Path.GetFileNameWithoutExtension(name));
            }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select Template to Copy")
            {
                comboBox1.Text = "";
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Select Template to Copy";
            }
        }

       
    }

     
 }
