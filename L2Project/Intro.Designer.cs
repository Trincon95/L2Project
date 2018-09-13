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
            this.templatedropdown = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.yourname = new System.Windows.Forms.Button();
            this.ticketnum = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // templatedropdown
            // 
            this.templatedropdown.AllowDrop = true;
            this.templatedropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.templatedropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templatedropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(205, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Copy\r\n";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // yourname
            // 
            this.yourname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.yourname.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yourname.Location = new System.Drawing.Point(46, 110);
            this.yourname.Name = "yourname";
            this.yourname.Size = new System.Drawing.Size(139, 33);
            this.yourname.TabIndex = 6;
            this.yourname.Text = "Your Name";
            this.yourname.UseVisualStyleBackColor = false;
            this.yourname.Click += new System.EventHandler(this.yourname_Click);
            // 
            // ticketnum
            // 
            this.ticketnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.ticketnum.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ticketnum.Location = new System.Drawing.Point(221, 110);
            this.ticketnum.Name = "ticketnum";
            this.ticketnum.Size = new System.Drawing.Size(138, 33);
            this.ticketnum.TabIndex = 7;
            this.ticketnum.Text = "Ticket #INC";
            this.ticketnum.UseVisualStyleBackColor = false;
            this.ticketnum.Click += new System.EventHandler(this.button4_Click);
            // 
            // Client
            // 
            this.Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.Client.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Client.Location = new System.Drawing.Point(395, 110);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(138, 33);
            this.Client.TabIndex = 8;
            this.Client.Text = "Client Name";
            this.Client.UseVisualStyleBackColor = false;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(46, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create New\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(573, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.ticketnum);
            this.Controls.Add(this.yourname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.templatedropdown);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Intro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox templatedropdown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button yourname;
        private System.Windows.Forms.Button ticketnum;
        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Button button1;

        public EventHandler Yournamebox_TextChanged { get; private set; }
    }
}

