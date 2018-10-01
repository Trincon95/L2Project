namespace L2Project
{
    partial class TemplateForm
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
            this.NewTempBox = new System.Windows.Forms.TextBox();
            this.Createbutton = new System.Windows.Forms.Button();
            this.NewTempTitlebox = new System.Windows.Forms.TextBox();
            this.NewTemplatelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewTempBox
            // 
            this.NewTempBox.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTempBox.ForeColor = System.Drawing.Color.DarkGray;
            this.NewTempBox.Location = new System.Drawing.Point(13, 99);
            this.NewTempBox.Margin = new System.Windows.Forms.Padding(4);
            this.NewTempBox.Multiline = true;
            this.NewTempBox.Name = "NewTempBox";
            this.NewTempBox.Size = new System.Drawing.Size(977, 397);
            this.NewTempBox.TabIndex = 1;
            this.NewTempBox.Text = "Enter Template Text Here...";
            this.NewTempBox.TextChanged += new System.EventHandler(this.NewTempBox_TextChanged);
            this.NewTempBox.Enter += new System.EventHandler(this.NewTempBox_Enter);
            this.NewTempBox.Leave += new System.EventHandler(this.NewTempBox_Leave);
            // 
            // Createbutton
            // 
            this.Createbutton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Createbutton.Font = new System.Drawing.Font("Constantia", 9.857143F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbutton.ForeColor = System.Drawing.Color.MintCream;
            this.Createbutton.Location = new System.Drawing.Point(362, 504);
            this.Createbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(250, 72);
            this.Createbutton.TabIndex = 2;
            this.Createbutton.Text = "Create";
            this.Createbutton.UseVisualStyleBackColor = false;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // NewTempTitlebox
            // 
            this.NewTempTitlebox.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTempTitlebox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NewTempTitlebox.Location = new System.Drawing.Point(320, 36);
            this.NewTempTitlebox.Margin = new System.Windows.Forms.Padding(4);
            this.NewTempTitlebox.Name = "NewTempTitlebox";
            this.NewTempTitlebox.Size = new System.Drawing.Size(389, 36);
            this.NewTempTitlebox.TabIndex = 0;
            this.NewTempTitlebox.Text = "Enter template title";
            this.NewTempTitlebox.TextChanged += new System.EventHandler(this.NewTempTitlebox_TextChanged);
            this.NewTempTitlebox.Enter += new System.EventHandler(this.NewTempTitlebox_Enter);
            this.NewTempTitlebox.Leave += new System.EventHandler(this.NewTempTitlebox_Leave);
            // 
            // NewTemplatelabel
            // 
            this.NewTemplatelabel.AutoSize = true;
            this.NewTemplatelabel.Font = new System.Drawing.Font("Constantia", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTemplatelabel.Location = new System.Drawing.Point(239, 38);
            this.NewTemplatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewTemplatelabel.Name = "NewTemplatelabel";
            this.NewTemplatelabel.Size = new System.Drawing.Size(73, 29);
            this.NewTemplatelabel.TabIndex = 4;
            this.NewTemplatelabel.Text = "Title:";
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1019, 605);
            this.Controls.Add(this.NewTemplatelabel);
            this.Controls.Add(this.NewTempTitlebox);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.NewTempBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewTempBox;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.TextBox NewTempTitlebox;
        private System.Windows.Forms.Label NewTemplatelabel;
    }
}