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
            this.Cnamebox.ForeColor = System.Drawing.Color.SlateGray;
            this.Cnamebox.Location = new System.Drawing.Point(123, 57);
            this.Cnamebox.Margin = new System.Windows.Forms.Padding(4);
            this.Cnamebox.Name = "Cnamebox";
            this.Cnamebox.Size = new System.Drawing.Size(294, 36);
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
            this.Tnumbox.ForeColor = System.Drawing.Color.SlateGray;
            this.Tnumbox.Location = new System.Drawing.Point(133, 155);
            this.Tnumbox.Margin = new System.Windows.Forms.Padding(4);
            this.Tnumbox.Name = "Tnumbox";
            this.Tnumbox.Size = new System.Drawing.Size(263, 36);
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
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
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
            this.comboBox1.Location = new System.Drawing.Point(184, 261);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(472, 36);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Select template to copy";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.BackColor = System.Drawing.Color.CadetBlue;
            this.CreateNewButton.Font = new System.Drawing.Font("Lucida Bright", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewButton.ForeColor = System.Drawing.Color.White;
            this.CreateNewButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateNewButton.Location = new System.Drawing.Point(548, 28);
            this.CreateNewButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(228, 73);
            this.CreateNewButton.TabIndex = 9;
            this.CreateNewButton.Text = "Create New";
            this.CreateNewButton.UseVisualStyleBackColor = false;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // Copybut
            // 
            this.Copybut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Copybut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copybut.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Copybut.Location = new System.Drawing.Point(339, 777);
            this.Copybut.Margin = new System.Windows.Forms.Padding(4);
            this.Copybut.Name = "Copybut";
            this.Copybut.Size = new System.Drawing.Size(223, 92);
            this.Copybut.TabIndex = 7;
            this.Copybut.Text = "Copy";
            this.Copybut.UseVisualStyleBackColor = false;
            this.Copybut.Click += new System.EventHandler(this.Copybut_Click);
            // 
            // CopyLabel
            // 
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.Font = new System.Drawing.Font("Cambria", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CopyLabel.Location = new System.Drawing.Point(286, 893);
            this.CopyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(329, 23);
            this.CopyLabel.TabIndex = 7;
            this.CopyLabel.Text = "Template has been copied to Clipboard";
            this.CopyLabel.Visible = false;
            // 
            // Choosetemplate
            // 
            this.Choosetemplate.AutoSize = true;
            this.Choosetemplate.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choosetemplate.Location = new System.Drawing.Point(334, 228);
            this.Choosetemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Choosetemplate.Name = "Choosetemplate";
            this.Choosetemplate.Size = new System.Drawing.Size(214, 29);
            this.Choosetemplate.TabIndex = 9;
            this.Choosetemplate.Text = "Choose Template:";
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.Location = new System.Drawing.Point(285, 277);
            this.Resultlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(0, 25);
            this.Resultlabel.TabIndex = 10;
            this.Resultlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MoClabel
            // 
            this.MoClabel.AutoSize = true;
            this.MoClabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoClabel.Location = new System.Drawing.Point(180, 315);
            this.MoClabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoClabel.Name = "MoClabel";
            this.MoClabel.Size = new System.Drawing.Size(216, 24);
            this.MoClabel.TabIndex = 11;
            this.MoClabel.Text = "Mode of Communication:";
            this.MoClabel.Visible = false;
            // 
            // MoCbox
            // 
            this.MoCbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoCbox.Location = new System.Drawing.Point(412, 315);
            this.MoCbox.Margin = new System.Windows.Forms.Padding(4);
            this.MoCbox.Name = "MoCbox";
            this.MoCbox.Size = new System.Drawing.Size(248, 29);
            this.MoCbox.TabIndex = 5;
            this.MoCbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoCbox.Visible = false;
            // 
            // Currentstatuslabel
            // 
            this.Currentstatuslabel.AutoSize = true;
            this.Currentstatuslabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currentstatuslabel.Location = new System.Drawing.Point(241, 367);
            this.Currentstatuslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Currentstatuslabel.Name = "Currentstatuslabel";
            this.Currentstatuslabel.Size = new System.Drawing.Size(155, 24);
            this.Currentstatuslabel.TabIndex = 13;
            this.Currentstatuslabel.Text = "Issue Description:";
            this.Currentstatuslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Currentstatuslabel.Visible = false;
            // 
            // currentstatbox
            // 
            this.currentstatbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentstatbox.Location = new System.Drawing.Point(412, 367);
            this.currentstatbox.Margin = new System.Windows.Forms.Padding(4);
            this.currentstatbox.Multiline = true;
            this.currentstatbox.Name = "currentstatbox";
            this.currentstatbox.Size = new System.Drawing.Size(248, 30);
            this.currentstatbox.TabIndex = 6;
            this.currentstatbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentstatbox.Visible = false;
            // 
            // resetbutton
            // 
            this.resetbutton.AutoSize = true;
            this.resetbutton.Font = new System.Drawing.Font("Lucida Bright", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.ForeColor = System.Drawing.Color.Maroon;
            this.resetbutton.Location = new System.Drawing.Point(591, 806);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(4);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(151, 45);
            this.resetbutton.TabIndex = 8;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Ynamecombo
            // 
            this.Ynamecombo.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ynamecombo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Ynamecombo.FormattingEnabled = true;
            this.Ynamecombo.Items.AddRange(new object[] {
            "Kyle",
            "Ghassan",
            "April",
            "Tania",
            "Ariel",
            "Shadi"});
            this.Ynamecombo.Location = new System.Drawing.Point(513, 155);
            this.Ynamecombo.Margin = new System.Windows.Forms.Padding(4);
            this.Ynamecombo.Name = "Ynamecombo";
            this.Ynamecombo.Size = new System.Drawing.Size(307, 36);
            this.Ynamecombo.TabIndex = 3;
            this.Ynamecombo.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Devanagari", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Incident ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Devanagari", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Select Your Name:";
            // 
            // previewTextLabel
            // 
            this.previewTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.previewTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewTextLabel.Location = new System.Drawing.Point(8, 421);
            this.previewTextLabel.Name = "previewTextLabel";
            this.previewTextLabel.Size = new System.Drawing.Size(864, 352);
            this.previewTextLabel.TabIndex = 22;
            this.previewTextLabel.Text = "Template copied";
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(884, 957);
            this.Controls.Add(this.previewTextLabel);
            this.Controls.Add(this.Cnamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ynamecombo);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.currentstatbox);
            this.Controls.Add(this.Currentstatuslabel);
            this.Controls.Add(this.MoCbox);
            this.Controls.Add(this.MoClabel);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.Choosetemplate);
            this.Controls.Add(this.CopyLabel);
            this.Controls.Add(this.Copybut);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Tnumbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
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

