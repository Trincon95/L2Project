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
            this.button2 = new System.Windows.Forms.Button();
            this.yourname = new System.Windows.Forms.Button();
            this.ticketnum = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
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
            this.label1.ForeColor = System.Drawing.Color.Black;
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
            this.yourname.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourname.ForeColor = System.Drawing.Color.Firebrick;
            this.yourname.Location = new System.Drawing.Point(58, 110);
            this.yourname.Name = "yourname";
            this.yourname.Size = new System.Drawing.Size(139, 33);
            this.yourname.TabIndex = 6;
            this.yourname.Text = "Your Name";
            this.yourname.UseVisualStyleBackColor = true;
            // 
            // ticketnum
            // 
            this.ticketnum.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketnum.ForeColor = System.Drawing.Color.Firebrick;
            this.ticketnum.Location = new System.Drawing.Point(240, 133);
            this.ticketnum.Name = "ticketnum";
            this.ticketnum.Size = new System.Drawing.Size(132, 33);
            this.ticketnum.TabIndex = 7;
            this.ticketnum.Text = "Ticket #INC";
            this.ticketnum.UseVisualStyleBackColor = true;
            this.ticketnum.Click += new System.EventHandler(this.button4_Click);
            // 
            // Client
            // 
            this.Client.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.ForeColor = System.Drawing.Color.Firebrick;
            this.Client.Location = new System.Drawing.Point(410, 110);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(138, 33);
            this.Client.TabIndex = 8;
            this.Client.Text = "Client Name";
            this.Client.UseVisualStyleBackColor = true;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.ticketnum);
            this.Controls.Add(this.yourname);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button yourname;
        private System.Windows.Forms.Button ticketnum;
        private System.Windows.Forms.Button Client;

        public EventHandler Yournamebox_TextChanged { get; private set; }
    }
}

