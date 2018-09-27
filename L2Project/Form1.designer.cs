namespace round2project
{
    partial class Primary
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
            this.Cnamebox = new System.Windows.Forms.TextBox();
            this.Tnumbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.Copybut = new System.Windows.Forms.Button();
            this.CopyLabel = new System.Windows.Forms.Label();
            this.Choosetemplate = new System.Windows.Forms.Label();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.MoClabel = new System.Windows.Forms.Label();
            this.MoCbox = new System.Windows.Forms.TextBox();
            this.Currentstatuslabel = new System.Windows.Forms.Label();
            this.currentstatbox = new System.Windows.Forms.TextBox();
            this.resetbutton = new System.Windows.Forms.Button();
            this.Ynamecombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previewTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cnamebox
            // 
            this.Cnamebox.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnamebox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Cnamebox.Location = new System.Drawing.Point(428, 118);
            this.Cnamebox.Margin = new System.Windows.Forms.Padding(4);
            this.Cnamebox.Name = "Cnamebox";
            this.Cnamebox.Size = new System.Drawing.Size(320, 40);
            this.Cnamebox.TabIndex = 1;
            this.Cnamebox.Text = "Enter Customers Name";
            this.Cnamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cnamebox.TextChanged += new System.EventHandler(this.Cnamebox_TextChanged);
            this.Cnamebox.Enter += new System.EventHandler(this.Cnamebox_Enter);
            this.Cnamebox.Leave += new System.EventHandler(this.Cnamebox_Leave);
            // 
            // Tnumbox
            // 
            this.Tnumbox.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnumbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Tnumbox.Location = new System.Drawing.Point(430, 193);
            this.Tnumbox.Margin = new System.Windows.Forms.Padding(4);
            this.Tnumbox.Name = "Tnumbox";
            this.Tnumbox.Size = new System.Drawing.Size(318, 40);
            this.Tnumbox.TabIndex = 2;
            this.Tnumbox.Text = "Enter Ticket #";
            this.Tnumbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tnumbox.Enter += new System.EventHandler(this.Tnumbox_Enter);
            this.Tnumbox.Leave += new System.EventHandler(this.Tnumbox_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Primary Email",
            "Reminder Email",
            "Suspension",
            "Hangouts message",
            "IP address"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Primary Email",
            "Reminder Email",
            "Final Email",
            "Suspension",
            "Hangouts message",
            "IP address"});
            this.comboBox1.Location = new System.Drawing.Point(184, 315);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(511, 40);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select Template to Copy";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CreateNewButton.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewButton.ForeColor = System.Drawing.Color.White;
            this.CreateNewButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewButton.Location = new System.Drawing.Point(707, 305);
            this.CreateNewButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(189, 56);
            this.CreateNewButton.TabIndex = 4;
            this.CreateNewButton.Text = "Create New";
            this.CreateNewButton.UseVisualStyleBackColor = false;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // Copybut
            // 
            this.Copybut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Copybut.Font = new System.Drawing.Font("Cambria", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copybut.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Copybut.Location = new System.Drawing.Point(292, 856);
            this.Copybut.Margin = new System.Windows.Forms.Padding(4);
            this.Copybut.Name = "Copybut";
            this.Copybut.Size = new System.Drawing.Size(243, 96);
            this.Copybut.TabIndex = 8;
            this.Copybut.Text = "Copy";
            this.Copybut.UseVisualStyleBackColor = false;
            this.Copybut.Click += new System.EventHandler(this.Copybut_Click);
            // 
            // CopyLabel
            // 
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.Font = new System.Drawing.Font("Cambria", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CopyLabel.Location = new System.Drawing.Point(310, 968);
            this.CopyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(371, 26);
            this.CopyLabel.TabIndex = 7;
            this.CopyLabel.Text = "Template has been copied to Clipboard";
            this.CopyLabel.Visible = false;
            // 
            // Choosetemplate
            // 
            this.Choosetemplate.AutoSize = true;
            this.Choosetemplate.Font = new System.Drawing.Font("Constantia", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choosetemplate.Location = new System.Drawing.Point(338, 266);
            this.Choosetemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Choosetemplate.Name = "Choosetemplate";
            this.Choosetemplate.Size = new System.Drawing.Size(268, 37);
            this.Choosetemplate.TabIndex = 9;
            this.Choosetemplate.Text = "Choose Template:";
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.Location = new System.Drawing.Point(251, 326);
            this.Resultlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(0, 25);
            this.Resultlabel.TabIndex = 10;
            this.Resultlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MoClabel
            // 
            this.MoClabel.AutoSize = true;
            this.MoClabel.Font = new System.Drawing.Font("Adobe Devanagari", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoClabel.Location = new System.Drawing.Point(191, 378);
            this.MoClabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoClabel.Name = "MoClabel";
            this.MoClabel.Size = new System.Drawing.Size(282, 37);
            this.MoClabel.TabIndex = 11;
            this.MoClabel.Text = "Mode of Communication:";
            this.MoClabel.Visible = false;
            // 
            // MoCbox
            // 
            this.MoCbox.Font = new System.Drawing.Font("Constantia", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoCbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MoCbox.Location = new System.Drawing.Point(479, 379);
            this.MoCbox.Margin = new System.Windows.Forms.Padding(4);
            this.MoCbox.Name = "MoCbox";
            this.MoCbox.Size = new System.Drawing.Size(270, 34);
            this.MoCbox.TabIndex = 5;
            this.MoCbox.Text = "Hangouts, SameTime, ETC";
            this.MoCbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoCbox.Visible = false;
            this.MoCbox.Enter += new System.EventHandler(this.MoCbox_Enter_1);
            this.MoCbox.Leave += new System.EventHandler(this.MoCbox_Leave_1);
            // 
            // Currentstatuslabel
            // 
            this.Currentstatuslabel.AutoSize = true;
            this.Currentstatuslabel.Font = new System.Drawing.Font("Adobe Devanagari", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currentstatuslabel.Location = new System.Drawing.Point(244, 433);
            this.Currentstatuslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Currentstatuslabel.Name = "Currentstatuslabel";
            this.Currentstatuslabel.Size = new System.Drawing.Size(226, 37);
            this.Currentstatuslabel.TabIndex = 13;
            this.Currentstatuslabel.Text = "Analysis Performed:";
            this.Currentstatuslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Currentstatuslabel.Visible = false;
            // 
            // currentstatbox
            // 
            this.currentstatbox.Font = new System.Drawing.Font("Constantia", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentstatbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.currentstatbox.Location = new System.Drawing.Point(478, 433);
            this.currentstatbox.Margin = new System.Windows.Forms.Padding(4);
            this.currentstatbox.Multiline = true;
            this.currentstatbox.Name = "currentstatbox";
            this.currentstatbox.Size = new System.Drawing.Size(270, 31);
            this.currentstatbox.TabIndex = 6;
            this.currentstatbox.Text = "Current status of issue";
            this.currentstatbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentstatbox.Visible = false;
            this.currentstatbox.Enter += new System.EventHandler(this.currentstatbox_Enter_1);
            this.currentstatbox.Leave += new System.EventHandler(this.currentstatbox_Leave_1);
            // 
            // resetbutton
            // 
            this.resetbutton.AutoSize = true;
            this.resetbutton.Font = new System.Drawing.Font("Lucida Bright", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.resetbutton.Location = new System.Drawing.Point(557, 885);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(4);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(165, 47);
            this.resetbutton.TabIndex = 9;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Ynamecombo
            // 
            this.Ynamecombo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ynamecombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Ynamecombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Ynamecombo.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ynamecombo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Ynamecombo.FormattingEnabled = true;
            this.Ynamecombo.Items.AddRange(new object[] {
            "Kyle",
            "Ghassan",
            "April",
            "Tania",
            "Ariel",
            "Shadi"});
            this.Ynamecombo.Location = new System.Drawing.Point(428, 40);
            this.Ynamecombo.Margin = new System.Windows.Forms.Padding(4);
            this.Ynamecombo.Name = "Ynamecombo";
            this.Ynamecombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ynamecombo.Size = new System.Drawing.Size(320, 40);
            this.Ynamecombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Devanagari", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Incident ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Devanagari", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "Your Name:";
            // 
            // previewTextLabel
            // 
            this.previewTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.previewTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewTextLabel.Location = new System.Drawing.Point(17, 493);
            this.previewTextLabel.Name = "previewTextLabel";
            this.previewTextLabel.Size = new System.Drawing.Size(936, 345);
            this.previewTextLabel.TabIndex = 7;
            this.previewTextLabel.Text = "Click Copy to view your template";
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(967, 1010);
            this.Controls.Add(this.previewTextLabel);
            this.Controls.Add(this.Cnamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ynamecombo);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.currentstatbox);
            this.Controls.Add(this.MoCbox);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.Choosetemplate);
            this.Controls.Add(this.CopyLabel);
            this.Controls.Add(this.Copybut);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Tnumbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MoClabel);
            this.Controls.Add(this.Currentstatuslabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Primary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aura L2 Template";
            this.Load += new System.EventHandler(this.Primary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Cnamebox;
        private System.Windows.Forms.TextBox Tnumbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button Copybut;
        private System.Windows.Forms.Label CopyLabel;
        private System.Windows.Forms.Label Choosetemplate;
        private System.Windows.Forms.Label Resultlabel;
        private System.Windows.Forms.Label MoClabel;
        private System.Windows.Forms.TextBox MoCbox;
        private System.Windows.Forms.Label Currentstatuslabel;
        private System.Windows.Forms.TextBox currentstatbox;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.ComboBox Ynamecombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label previewTextLabel;
    }
}

