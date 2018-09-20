using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

 

        public void Cnamebox_Enter(object sender, EventArgs e)
        {
            if (Cnamebox.Text == "Client ")
            {
                Cnamebox.Text = "";
            }
        }

        public void Cnamebox_Leave(object sender, EventArgs e)
        {
            if (Cnamebox.Text == "")
            {
                Cnamebox.Text = "Client ";
            }
        }

        public void Tnumbox_Enter(object sender, EventArgs e)
        {
            if (Tnumbox.Text == "Ticket #")
            {
                Tnumbox.Text = "";
            }
        }

        public void Tnumbox_Leave(object sender, EventArgs e)
        {
            if (Tnumbox.Text == "")
            {
                Tnumbox.Text = "Ticket #";
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Suspension")
            {
                MoClabel.Show();
                MoCbox.Show();
                Currentstatuslabel.Show();
                currentstatbox.Show();
            }
            if (comboBox1.Text .Contains("Suspension") == false)
            {
                MoCbox.Hide();
                MoClabel.Hide();
                currentstatbox.Hide();
                Currentstatuslabel.Hide();
            }
   
            

            
        }
        

        public void Copybut_Click(object sender, EventArgs e)
        {
          

            if (comboBox1.Text == "Hangouts message")
            {
                string hangouts = "Hey " + Cnamebox.Text + ",";
                string hangouts1 = "My name is " + Ynamecombo.Text + ". I am with L2 Aura Support.  Please advise me when it is a good time to resolve your issue INC" + Tnumbox.Text + ". ";
                string hangouts2 = hangouts + "\n" + hangouts1;
                
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
              
            }
              if (comboBox1.Text == "Primary Email")
            {
                string subject = "Aura Issue INC#" + Tnumbox.Text + "\n" + "\n";
                string pemail = "Hi " + Cnamebox.Text + "," + "\n" + "Hope you are doing well!" + "\n" + "I am with L2 Aura Support. With regard to the incident raised by you, we would further request to meet remotely or WebEx in order to investigate the issue." + "\n";
                string pemail1 = "Could you please Email or Sametime me your convenient time to work on the issue?" + "\n";
                string pemail2 = "Kindly 'reply to all',  so any one from team 'TCS ASR App Support Aura' can assist you in my absence." + "\n";
                string pemail3 = "Thanks,";
                string primarye = subject + pemail + pemail1 + pemail2 + pemail3;
                Clipboard.SetText(primarye);
            }
            if (comboBox1.Text == "Reminder Email")
            {
                string subject = "*(Reminder) Aura Issue INC#" + Tnumbox.Text + "\n" + "\n";
                string semail = "Hi " + Cnamebox.Text + "," + "\n" + "Hope you are doing well!" + "\n" + "I am with L2 Aura Support. With regard to the incident raised by you, we would further request to meet remotely or WebEx in order to investigate the issue." + "\n";
                string semail1 = "Could you please Email or Sametime me your convenient time to work on the issue?" + "\n";
                string semail2 = "Kindly 'reply to all',  so any one from team 'TCS ASR App Support Aura' can assist you in my absence." + "\n";
                string semail3 = "Thanks,";
                string secondarye = subject + semail + semail1 + semail2 + semail3;
                Clipboard.SetText(secondarye);
            }
            if (comboBox1.Text == "Final Email")
            {
                string subject = "*(Final Reminder) Aura Issue INC#" + Tnumbox.Text + "\n" + "\n";
                string femail = "Hello " + Cnamebox.Text + "," + "\n" + "I am with 2nd level support assigned to Incident INC" + Tnumbox.Text + " reported with Aura." + "\n";
                string femail1 = "With regard to this incident, we have made an attempt to approach you twice in the past few days." + "\n";
                string femail2 = "Please be advised that if  we don't hear back by the end of business TODAY, we will consider the issue to be resolved and close the ticket with following status 'no action needed / no return contact by customer'." + "\n";
                string femail3 = "Please let us know ASAP if you still require our assistance. " + "\n";
                string femail4 = "Please contact PWC Help to log a new support request should you happen to experience this issue in the future. " + "\n";
                string femail5 = "Thank you, ";
                string finale = subject + femail + femail1 + femail2 + femail3 + femail4 + femail5;
                Clipboard.SetText(finale);
            }
            if (comboBox1.Text == "IP address")
            {
                string ip = "May i have your IP address please?" + "\n" + "\n";
                    string ip1 = "This can be found by Search > My Computer info";
                string ipadd = ip + ip1;
                Clipboard.SetText(ipadd);
            }
            CopyLabel.Show();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }


            CopyLabel.Hide();
            
            
            if (Cnamebox.Text == "Client Name")
                {
                    Cnamebox.Text = "";
                }
            
            if (Cnamebox.Text == "")
                {
                    Cnamebox.Text = "Client Name";
                }
            

 
                if (Tnumbox.Text == "Ticket #")
                {
                    Tnumbox.Text = "";
                }
            

 
                if (Tnumbox.Text == "")
                {
                    Tnumbox.Text = "Ticket #";
                }
            




        }

        private void Primary_Load(object sender, EventArgs e)
        {

        }
    }
}
