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
            this.button2 = new System.Windows.Forms.Button();
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
            this.NewTempBox.Size = new System.Drawing.Size(802, 269);
            this.NewTempBox.TabIndex = 0;
            this.NewTempBox.Text = "Design New Template Here";
            this.NewTempBox.Enter += new System.EventHandler(this.NewTempBox_Enter);
            this.NewTempBox.Leave += new System.EventHandler(this.NewTempBox_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewTempTitlebox
            // 
            this.NewTempTitlebox.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTempTitlebox.Location = new System.Drawing.Point(177, 24);
            this.NewTempTitlebox.Name = "NewTempTitlebox";
            this.NewTempTitlebox.Size = new System.Drawing.Size(217, 27);
            this.NewTempTitlebox.TabIndex = 3;
            this.NewTempTitlebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewTempBox);
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewTempBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NewTempTitlebox;
        private System.Windows.Forms.Label NewTemplatelabel;
    }
}