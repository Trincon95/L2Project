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
            if (Cnamebox.Text == "Enter Customer's Name")
            {
                Cnamebox.Text = "";
                Cnamebox.ForeColor = Color.Black;
            }
        }

        public void Cnamebox_Leave(object sender, EventArgs e) //Creates Placeholder
        {
            if (Cnamebox.Text == "")
            {
                Cnamebox.Text = "Enter Customer's Name";
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
            string message = "Hey " + Cnamebox.Text + "," + "\n" + "\n" + "My name is " + nameTextBox.Text + ". I am with L2 Aura Support.  Please advise me when it is a good time to resolve your issue " + Tnumbox.Text + ". ";
            System.IO.File.WriteAllText(@"C:\L2AutomationTemplates\Hangouts message.txt", message);

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
                string text = System.IO.File.ReadAllText(@"\L2AutomationTemplates\" + comboBoxValue + ".txt");
                Clipboard.SetText(text);
                previewTextLabel.Text = text;
            }

            CopyLabel.Hide();
        }

        public void Copybut_Click(object sender, EventArgs e)
        {

            try
            {
                string comboBoxValue = comboBox1.SelectedItem.ToString();

                DateTime ETA = DateTime.Now;
                string suspension = "User name: " + Cnamebox.Text + "\n" + "Mode of Communication: " + MoCbox.Text + "\n" + "Analysis Performed and Current Status: " + Cnamebox.Text + " is unavailable/unresponsive via " + MoCbox.Text+ ". Sent email requesting a webex to investigate issue." + "\n" + "Next Action Item: Investigate issue and formulate a resolution once " + Cnamebox.Text + " is available."
                + "\n" + "Team to perform next action item: PWC IT APP ASP - L2 ASSURANCE" + "\n" + "ETA: " + ETA.AddDays(2).ToString();
                System.IO.File.WriteAllText(@"C:\L2AutomationTemplates\Suspension.txt", suspension);

                if (comboBox1.Text == "Suspension")
                {
                    previewTextLabel.Text = suspension;
                }

                if (comboBox1.Text == comboBoxValue)
                {
                    string text = System.IO.File.ReadAllText(@"\L2AutomationTemplates\" + comboBoxValue + ".txt");
                    Clipboard.SetText(text);
                    CopyLabel.Show();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please select a template to copy");
               
            }
           
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            /* foreach (Control c in Controls)
             {
                 if (c is TextBox)
                 {
                     c.Text = "";
                 }
             }*/

            Cnamebox.Text = "";
            Tnumbox.Text = "";
            MoCbox.Text = "";

            previewTextLabel.Text = "Click Copy to view your Template";

            comboBox1.Text = "Select Template to Copy";

            CopyLabel.Hide();
            MoClabel.Hide();
            MoCbox.Hide();

            if (Cnamebox.Text == "Enter Customer's Name")
            {
                Cnamebox.Text = "";
            }

            if (Cnamebox.Text == "")
            {
                Cnamebox.Text = "Enter Customer's Name";
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

            string path = @"C:\Users\Public\IBM\Notes\Data\workspace\.metadata\.plugins\com.ibm.collaboration.realtime.login";

            string[] nameFile = Directory.GetFiles(path);

            foreach (string name in nameFile)
            {

                string NameFile = Path.GetFileNameWithoutExtension(name);

                NameFile = NameFile.Substring(NameFile.IndexOf('=') + 1);

                NameFile = NameFile.Substring(0, NameFile.IndexOf(" "));

                nameTextBox.SelectedText = NameFile;           
            }

            string Templates = @"c:\L2AutomationTemplates";

            System.IO.Directory.CreateDirectory(Templates);

            Template_Files();
            DropDown_Add();

        }


        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            L2Project.TemplateForm Tf = new TemplateForm(this);
            Tf.ShowDialog();
            //this.Close();
        }

        private void Cnamebox_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        }

        private void Template_Files()
        {
            string message = "Hey " + Cnamebox.Text + "," + "\n" + "\n" + "My name is " + nameTextBox.Text + ". I am with L2 Aura Support. Please advise me when it is a good time to resolve your issue " + Tnumbox.Text + ". ";
            System.IO.File.WriteAllText(@"C:\L2AutomationTemplates\Hangouts message.txt", message);

            DateTime ETA = DateTime.Now;
            string suspension = "User name: " + Cnamebox.Text + "\n" + "Mode of Communication: " + MoCbox.Text + "\n" + "Analysis Performed and Current Status: " + Cnamebox.Text + " unavailable/unresponsive via " + MoCbox.Text + ". Sent email requesting a webex to investigate issue." + "\n" + "Next Action Item: Investigate issue and formulate a resolution once " + Cnamebox.Text + " is available."
            + "\n" + "Team to perform next action item: PWC IT APP ASP - L2 ASSURANCE" + "\n" + "ETA: " + ETA.AddDays(2).ToString();
            System.IO.File.WriteAllText(@"C:\L2AutomationTemplates\Suspension.txt", suspension);

            string primaryemail = "Aura Issue #" + Tnumbox.Text + "\n" + "\n" + "Hello " + Cnamebox.Text + "," + "\n" + "\n" + "Hope you are doing well!" + "\n" + "\n" + "I am with the Aura Level 2 Technical Support team. Your call to the Aura Help Desk regarding " + Tnumbox.Text + " was escalated to us. We would further request to meet remotely or WebEx in order to investigate the issue." + "\n" + "\n" + "Let me know what is the best time and method to reach you, and I will be happy to assist."
            + "\n" + "\n" + "Please 'reply to all', so any one from team can assist you in my absence." + "\n" + "\n" + "Thanks,";
            System.IO.File.WriteAllText(@"C:\L2AutomationTemplates\Primary Email.txt", primaryemail);

            string reminderEmail = "*(Reminder)* Aura Issue #" + Tnumbox.Text + "\n" + "\n" + "\n" +
            "Hello " + Cnamebox.Text + "," + "\n" + "\n" + "Hope you are doing well!" + "\n" + "\n" + "I am with the Aura Level 2 Technical Support team. Your call to the Aura Help Desk regarding " + Tnumbox.Text + " was escalated to us. We would further request to meet remotely or WebEx in order to investigate the issue." + "\n" + "\n" + "Let me know what is the best time and method to reach you, and I will be happy to assist."
            + "\n" + "\n" + "Please 'reply to all', so any one from team can assist you in my absence." + "\n" + "\n" + "Thanks,";
            System.IO.File.WriteAllText(@"C:\L2AutomationTemplates\Reminder Email.txt", reminderEmail);

            string ipAddress = "Please provide me with your IP address" + "\n" + 
            "This can be found by Search > \"My Computer Info\"";
            System.IO.File.WriteAllText(@"C:\L2AutomationTemplates\IP address.txt", ipAddress);

            string finalEmail = "*(Final Reminder)* Aura Issue #" + Tnumbox.Text + "\n" + "\n" + "\n" + "Hello " + Cnamebox.Text + "," + "\n" + "\n" +
            "I am with 2nd level support assigned to Incident " + Tnumbox.Text + " reported with Aura. With regard to this incident, we have made an attempt to approach you twice in the past few days." + "\n" + "\n" +
            "Please be advised that if we don't hear back at the end of business tomorrow we will consider the issue to be resolved and close the ticket with following status 'no action needed / no return contact by customer'." + "\n" + "\n" +
            "Please let us know ASAP if you still require our assistance. " + "\n" + "\n" + "Should you happen to experience this issue in the future, please contact PwC Help to log a new support request." + "\n" + "\n" + "Thank you,";
            System.IO.File.WriteAllText(@"C:\L2AutomationTemplates\Final Email.txt", finalEmail);
        }
        public void Refresh_form()
        {
            this.DropDown_Add();
        }

        private void DropDown_Add()
        {
            comboBox1.Items.Clear();
            string[] fileArray = Directory.GetFiles(@"c:\L2AutomationTemplates");
            
            string templateName = Path.GetFileNameWithoutExtension(@"c:\L2AutomationTemplates");

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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string comboBoxValue = comboBox1.SelectedItem.ToString();
                string path = @"\L2AutomationTemplates\" + comboBoxValue + ".txt";

                File.Delete(path);

                MessageBox.Show("Your template has been deleted");

                Refresh_form();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select template to delete");
            }
        

            comboBox1.Text = "Select Template to Copy";

            previewTextLabel.Text = "Click \"Copy\" to view your Template";



        }

        private void MoCbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void previewTextLabel_Click(object sender, EventArgs e)
        {

        }
    }

     
 }
