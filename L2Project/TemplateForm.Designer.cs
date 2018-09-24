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
            this.NewTempBox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTempBox.Location = new System.Drawing.Point(0, 73);
            this.NewTempBox.Multiline = true;
            this.NewTempBox.Name = "NewTempBox";
            this.NewTempBox.Size = new System.Drawing.Size(800, 258);
            this.NewTempBox.TabIndex = 0;
            this.NewTempBox.Text = "Design New Template Here";
            this.NewTempBox.TextChanged += new System.EventHandler(this.NewTempBox_TextChanged);
            this.NewTempBox.Enter += new System.EventHandler(this.NewTempBox_Enter);
            this.NewTempBox.Leave += new System.EventHandler(this.NewTempBox_Leave);
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(554, 372);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(218, 46);
            this.Createbutton.TabIndex = 2;
            this.Createbutton.Text = "Create";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // NewTempTitlebox
            // 
            this.NewTempTitlebox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTempTitlebox.Location = new System.Drawing.Point(177, 24);
            this.NewTempTitlebox.Name = "NewTempTitlebox";
            this.NewTempTitlebox.Size = new System.Drawing.Size(217, 27);
            this.NewTempTitlebox.TabIndex = 3;
            this.NewTempTitlebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewTempTitlebox.TextChanged += new System.EventHandler(this.NewTempTitlebox_TextChanged);
            // 
            // NewTemplatelabel
            // 
            this.NewTemplatelabel.AutoSize = true;
            this.NewTemplatelabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTemplatelabel.Location = new System.Drawing.Point(119, 28);
            this.NewTemplatelabel.Name = "NewTemplatelabel";
            this.NewTemplatelabel.Size = new System.Drawing.Size(52, 18);
            this.NewTemplatelabel.TabIndex = 4;
            this.NewTemplatelabel.Text = "Title:";
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewTemplatelabel);
            this.Controls.Add(this.NewTempTitlebox);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.NewTempBox);
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