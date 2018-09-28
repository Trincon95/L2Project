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
using Microsoft.Win32;


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
  

 


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Suspension template text boxes visibility
        {
            string message = "Hey " + Cnamebox.Text + "," + "\n" + "\n" + "My name is " + Ynamecombo.Text + ". I am with L2 Aura Support.  Please advise me when it is a good time to resolve your issue INC" + Tnumbox.Text + ". ";
            System.IO.File.WriteAllText(@"C:\Templates\Hangouts message.txt", message);

            Template_Files();


            string comboBoxValue = comboBox1.SelectedItem.ToString();

            if (comboBox1.Text == "Suspension")
            {

                MoClabel.Show();
                MoCbox.Show();
           

            }
            if (comboBox1.Text.Contains("Suspension") == false)
            {
                MoCbox.Hide();
                MoClabel.Hide();
   
            }

            if (comboBox1.Text == comboBoxValue)

            {
                string text = System.IO.File.ReadAllText(@"\Templates\" + comboBoxValue + ".txt");
                Clipboard.SetText(text);
                previewTextLabel.Text = text;
            }

            

        }

        public void Copybut_Click(object sender, EventArgs e)
        {
            try
            {
                string comboBoxValue = comboBox1.SelectedItem.ToString();

                DateTime ETA = DateTime.Now;
                string suspension = "Username: " + Cnamebox.Text + "\n" + "Mode of Communication: " + MoCbox.Text + "\n" + "Analysis Performed and Current Status: " + Cnamebox.Text + " unavailable/unresponsive via . Sent email requesting a webex to investigate issue." + "\n" + "Next Action Item: Investigate issue and formulate a resolution once  is available."
                    + "\n" + "Team to perform next action item: PWC IT APP ASP - L2 ASSURANCE" + "\n" + "ETA: " + ETA.AddDays(2).ToString();
                System.IO.File.WriteAllText(@"C:\Templates\Suspension.txt", suspension);

                if (comboBox1.Text == "Suspension")
                {
                    previewTextLabel.Text = suspension;
                }


                if (comboBox1.Text == comboBoxValue)
                {
                    string text = System.IO.File.ReadAllText(@"\Templates\" + comboBoxValue + ".txt");
                    Clipboard.SetText(text);
                }
                CopyLabel.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a template to copy");
            }
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

            comboBox1.Text = "Select Template to Copy";

            CopyLabel.Hide();

           

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
            /*   string name1 = System.Windows.Forms.SystemInformation.UserName.ToString();
               Ynamecombo.Text = name1;
               */

            // string userName = @"C:\Users\Public\IBM\Notes\Data\workspace\.metadata\.plugins\com.ibm.collaboration.realtime.login";
            //  Ynamecombo.Text = userName;
            /* using (RegistryKey userName = Registry.LocalMachine.OpenSubKey(@"Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\SessionData\1\LoggedOnDisplayName"))
             {
                 Object o = userName.GetValue("LoggedOnDisplayName");
                 Convert.ToString(userName);
                 Ynamecombo.Text = userName;
             }*/

     string path = @"C:\Users\Public\IBM\Notes\Data\workspace\.metadata\.plugins\com.ibm.collaboration.realtime.login";

            string[] nameFile = Directory.GetFiles(path);


            foreach (string name in nameFile)
            {

                string NameFile = Path.GetFileNameWithoutExtension(name);

                NameFile = NameFile.Substring(NameFile.IndexOf('=') + 1);

                NameFile = NameFile.Substring(0, NameFile.IndexOf(" ") + 1);

                   Ynamecombo.SelectedText = NameFile;           
            }

            

            string Templates = @"c:\Templates";

            System.IO.Directory.CreateDirectory(Templates);

            Template_Files();
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

        private void Template_Files()
        {
            string message = "Hey " + Cnamebox.Text + "," + "\n" + "\n" + "My name is " + Ynamecombo.Text + ". I am with L2 Aura Support.  Please advise me when it is a good time to resolve your issue INC" + Tnumbox.Text + ". ";
            System.IO.File.WriteAllText(@"C:\Templates\Hangouts message.txt", message);

            DateTime ETA = DateTime.Now;
            string suspension = "Username: " + Cnamebox.Text + "\n" + "Mode of Communication: " + MoCbox.Text + "\n" + "Analysis Performed and Current Status: " + Cnamebox.Text + " unavailable/unresponsive. Sent email requesting a webex to investigate issue." + "\n" + "Next Action Item: Investigate issue and formulate a resolution once  is available."
                   + "\n" + "Team to perform next action item: PWC IT APP ASP - L2 ASSURANCE" + "\n" + "ETA: " + ETA.AddDays(2).ToString();
            System.IO.File.WriteAllText(@"C:\Templates\Suspension.txt", suspension);

            string primaryemail = "Aura Issue #" + Tnumbox.Text + "\n" + "\n" + "Hello " + Cnamebox.Text + "," + "\n" + "\n" + "Hope you are doing well!" + "\n" + "\n" + "I am with the Aura level 2 Technical Support team. Your call to the Aura Help Desk regarding " + Tnumbox.Text + " was escalated to us. Please let me know what is the best time and method to reach you, and I will be happy to assist you."
                 + "\n" + "\n" + "Please reply to all, so any one from team can assist you in my absence." + "\n" + "\n" + "Thanks,";
            System.IO.File.WriteAllText(@"C:\Templates\Primary Email.txt", primaryemail);

            string reminderEmail = "*(Reminder)* Aura Issue #" + Tnumbox.Text + "\n" + "\n" + "\n" +
            "Hello " + Cnamebox.Text + "," + "\n" + "\n" + "Hope you are doing well!" + "\n" + "\n" + "I am with the Aura level 2 Technical Support team. Your call to the Aura Help Desk regarding " + Tnumbox.Text + " was escalated to us. Please let me know what is the best time and method to reach you, and I will be happy to assist you."
                 + "\n" + "\n" + "Please reply to all, so any one from team can assist you in my absence." + "\n" + "\n" + "Thanks,";
            System.IO.File.WriteAllText(@"C:\Templates\Reminder Email.txt", reminderEmail);

            string ipAddress = "May i have your IP address please?" + "\n" + "\n" + "\n" +
            "This can be found by Search > My Computer info";
            System.IO.File.WriteAllText(@"C:\Templates\IP address.txt", ipAddress);

            string finalEmail = "*(Final Reminder)* Aura Issue #" + Tnumbox.Text + "\n" + "\n" + "\n" + "Hello " + Cnamebox.Text + "," + "\n" + "\n" +
                "I am with 2nd level support assigned to Incident" + Tnumbox.Text + " reported with Aura. With regard to this incident, we have made an attempt to approach you twice in the past few days." + "\n" + "\n" +
                "Please be advised that if  we don't hear back at the end of business tomorrow we will consider the issue to be resolved and close the ticket with following status 'no action needed / no return contact by customer'." + "\n" + "\n" +
                "Please let us know ASAP if you still require our assistance. " + "\n" + "\n" + "Please contact PWC Help to log a new support request should you happen to experience this  issue in the future." + "\n" + "\n" + "Thank you,";
            System.IO.File.WriteAllText(@"C:\Templates\Final Email.txt", finalEmail);
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
