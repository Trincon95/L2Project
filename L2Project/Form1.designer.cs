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
            this.Title = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // Cnamebox
            // 
            this.Cnamebox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnamebox.ForeColor = System.Drawing.Color.Crimson;
            this.Cnamebox.Location = new System.Drawing.Point(62, 224);
            this.Cnamebox.Name = "Cnamebox";
            this.Cnamebox.Size = new System.Drawing.Size(143, 26);
            this.Cnamebox.TabIndex = 1;
            this.Cnamebox.Text = "Customer Name";
            this.Cnamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cnamebox.TextChanged += new System.EventHandler(this.Cnamebox_TextChanged);
            this.Cnamebox.Enter += new System.EventHandler(this.Cnamebox_Enter);
            this.Cnamebox.Leave += new System.EventHandler(this.Cnamebox_Leave);
            // 
            // Tnumbox
            // 
            this.Tnumbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnumbox.ForeColor = System.Drawing.Color.Crimson;
            this.Tnumbox.Location = new System.Drawing.Point(62, 298);
            this.Tnumbox.Name = "Tnumbox";
            this.Tnumbox.Size = new System.Drawing.Size(143, 26);
            this.Tnumbox.TabIndex = 2;
            this.Tnumbox.Text = "Ticket #";
            this.Tnumbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tnumbox.Enter += new System.EventHandler(this.Tnumbox_Enter);
            this.Tnumbox.Leave += new System.EventHandler(this.Tnumbox_Leave);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(189, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(419, 122);
            this.Title.TabIndex = 3;
            this.Title.Text = "Aura L2 Template \r\nGenerator ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.comboBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Primary Email",
            "Reminder Email",
            "Final Email",
            "Suspension",
            "Hangouts message",
            "IP address"});
            this.comboBox1.Location = new System.Drawing.Point(268, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.BackColor = System.Drawing.Color.CadetBlue;
            this.CreateNewButton.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.CreateNewButton.Location = new System.Drawing.Point(574, 143);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(181, 75);
            this.CreateNewButton.TabIndex = 5;
            this.CreateNewButton.Text = "Create New";
            this.CreateNewButton.UseVisualStyleBackColor = false;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // Copybut
            // 
            this.Copybut.BackColor = System.Drawing.Color.CadetBlue;
            this.Copybut.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copybut.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Copybut.Location = new System.Drawing.Point(167, 420);
            this.Copybut.Name = "Copybut";
            this.Copybut.Size = new System.Drawing.Size(417, 131);
            this.Copybut.TabIndex = 6;
            this.Copybut.Text = "Copy";
            this.Copybut.UseVisualStyleBackColor = false;
            this.Copybut.Click += new System.EventHandler(this.Copybut_Click);
            // 
            // CopyLabel
            // 
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyLabel.ForeColor = System.Drawing.Color.Crimson;
            this.CopyLabel.Location = new System.Drawing.Point(231, 585);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(291, 21);
            this.CopyLabel.TabIndex = 7;
            this.CopyLabel.Text = "Template has been copied to Clipboard :)";
            this.CopyLabel.Visible = false;
            // 
            // Choosetemplate
            // 
            this.Choosetemplate.AutoSize = true;
            this.Choosetemplate.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choosetemplate.Location = new System.Drawing.Point(308, 173);
            this.Choosetemplate.Name = "Choosetemplate";
            this.Choosetemplate.Size = new System.Drawing.Size(120, 18);
            this.Choosetemplate.TabIndex = 9;
            this.Choosetemplate.Text = "Choose Template:";
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.Location = new System.Drawing.Point(333, 262);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(0, 20);
            this.Resultlabel.TabIndex = 10;
            this.Resultlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MoClabel
            // 
            this.MoClabel.AutoSize = true;
            this.MoClabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoClabel.Location = new System.Drawing.Point(308, 269);
            this.MoClabel.Name = "MoClabel";
            this.MoClabel.Size = new System.Drawing.Size(182, 21);
            this.MoClabel.TabIndex = 11;
            this.MoClabel.Text = "Mode of Communication:";
            this.MoClabel.Visible = false;
            // 
            // MoCbox
            // 
            this.MoCbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoCbox.Location = new System.Drawing.Point(485, 267);
            this.MoCbox.Name = "MoCbox";
            this.MoCbox.Size = new System.Drawing.Size(204, 26);
            this.MoCbox.TabIndex = 12;
            this.MoCbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoCbox.Visible = false;
            // 
            // Currentstatuslabel
            // 
            this.Currentstatuslabel.AutoSize = true;
            this.Currentstatuslabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currentstatuslabel.Location = new System.Drawing.Point(334, 314);
            this.Currentstatuslabel.Name = "Currentstatuslabel";
            this.Currentstatuslabel.Size = new System.Drawing.Size(129, 21);
            this.Currentstatuslabel.TabIndex = 13;
            this.Currentstatuslabel.Text = "Issue Description:";
            this.Currentstatuslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Currentstatuslabel.Visible = false;
            // 
            // currentstatbox
            // 
            this.currentstatbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentstatbox.Location = new System.Drawing.Point(485, 314);
            this.currentstatbox.Multiline = true;
            this.currentstatbox.Name = "currentstatbox";
            this.currentstatbox.Size = new System.Drawing.Size(204, 26);
            this.currentstatbox.TabIndex = 14;
            this.currentstatbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentstatbox.Visible = false;
            // 
            // resetbutton
            // 
            this.resetbutton.AutoSize = true;
            this.resetbutton.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.ForeColor = System.Drawing.Color.Crimson;
            this.resetbutton.Location = new System.Drawing.Point(658, 471);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(97, 40);
            this.resetbutton.TabIndex = 15;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Ynamecombo
            // 
            this.Ynamecombo.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ynamecombo.ForeColor = System.Drawing.Color.Crimson;
            this.Ynamecombo.FormattingEnabled = true;
            this.Ynamecombo.Items.AddRange(new object[] {
            "Kyle",
            "Ghassan",
            "April",
            "Tania",
            "Ariel",
            "Shadi"});
            this.Ynamecombo.Location = new System.Drawing.Point(62, 143);
            this.Ynamecombo.Name = "Ynamecombo";
            this.Ynamecombo.Size = new System.Drawing.Size(143, 33);
            this.Ynamecombo.TabIndex = 18;
            this.Ynamecombo.Text = "Name";
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(778, 644);
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
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Tnumbox);
            this.Controls.Add(this.Cnamebox);
            this.Name = "Primary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primary";
            this.Load += new System.EventHandler(this.Primary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Cnamebox;
        private System.Windows.Forms.TextBox Tnumbox;
        private System.Windows.Forms.Label Title;
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
    }
}

