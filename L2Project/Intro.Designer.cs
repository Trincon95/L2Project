using System;

namespace L2Project
{
    partial class Intro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.templatedropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Yournamebox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Ticket = new System.Windows.Forms.TextBox();
            this.Clientname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(42, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // templatedropdown
            // 
            this.templatedropdown.AllowDrop = true;
            this.templatedropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templatedropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.templatedropdown.FormattingEnabled = true;
            this.templatedropdown.Items.AddRange(new object[] {
            "Suspension",
            "First Email",
            "Reminder Email",
            "Contacting user (hangouts)",
            "Contacting user (IP address)"});
            this.templatedropdown.Location = new System.Drawing.Point(150, 200);
            this.templatedropdown.Margin = new System.Windows.Forms.Padding(4);
            this.templatedropdown.Name = "templatedropdown";
            this.templatedropdown.Size = new System.Drawing.Size(279, 30);
            this.templatedropdown.TabIndex = 2;
            this.templatedropdown.Text = "Choose Template";
            this.templatedropdown.SelectedIndexChanged += new System.EventHandler(this.templatedropdown_SelectedIndexChanged);
            this.templatedropdown.Enter += new System.EventHandler(this.templatedropdown_Enter);
            this.templatedropdown.Leave += new System.EventHandler(this.templatedropdown_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(119, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Template Automation ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Yournamebox
            // 
            this.Yournamebox.BackColor = System.Drawing.Color.Salmon;
            this.Yournamebox.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yournamebox.ForeColor = System.Drawing.Color.Maroon;
            this.Yournamebox.Location = new System.Drawing.Point(52, 107);
            this.Yournamebox.Name = "Yournamebox";
            this.Yournamebox.Size = new System.Drawing.Size(151, 31);
            this.Yournamebox.TabIndex = 4;
            this.Yournamebox.Text = "Your Name";
            this.Yournamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Yournamebox.Enter += new System.EventHandler(this.Yournamebox_Enter);
            this.Yournamebox.Leave += new System.EventHandler(this.Yournamebox_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(205, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Ticket
            // 
            this.Ticket.BackColor = System.Drawing.Color.Salmon;
            this.Ticket.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket.ForeColor = System.Drawing.Color.Maroon;
            this.Ticket.Location = new System.Drawing.Point(243, 107);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(139, 31);
            this.Ticket.TabIndex = 6;
            this.Ticket.Text = "Ticket #";
            this.Ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ticket.Enter += new System.EventHandler(this.Ticket_Enter);
            this.Ticket.Leave += new System.EventHandler(this.Ticket_Leave);
            // 
            // Clientname
            // 
            this.Clientname.BackColor = System.Drawing.Color.Salmon;
            this.Clientname.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientname.ForeColor = System.Drawing.Color.Maroon;
            this.Clientname.Location = new System.Drawing.Point(412, 107);
            this.Clientname.Name = "Clientname";
            this.Clientname.Size = new System.Drawing.Size(144, 31);
            this.Clientname.TabIndex = 7;
            this.Clientname.Text = "Client Name";
            this.Clientname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Clientname.Enter += new System.EventHandler(this.Clientname_Enter);
            this.Clientname.Leave += new System.EventHandler(this.Clientname_Leave);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.Clientname);
            this.Controls.Add(this.Ticket);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Yournamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.templatedropdown);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Intro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox templatedropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Yournamebox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Ticket;
        private System.Windows.Forms.TextBox Clientname;

        public EventHandler Yournamebox_TextChanged { get; private set; }
    }
}

