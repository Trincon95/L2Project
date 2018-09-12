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
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.Createnew = new System.Windows.Forms.RadioButton();
            this.existingtemplate = new System.Windows.Forms.RadioButton();
            this.Errorstemplate = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.Font = new System.Drawing.Font("Modern No. 20", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.ForeColor = System.Drawing.Color.Yellow;
            this.Welcomelabel.Location = new System.Drawing.Point(279, 34);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(173, 41);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Welcome";
            this.Welcomelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Welcomelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Createnew
            // 
            this.Createnew.AutoSize = true;
            this.Createnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Createnew.Location = new System.Drawing.Point(262, 113);
            this.Createnew.Name = "Createnew";
            this.Createnew.Size = new System.Drawing.Size(275, 33);
            this.Createnew.TabIndex = 2;
            this.Createnew.TabStop = true;
            this.Createnew.Text = "Create New Template\r\n";
            this.Createnew.UseVisualStyleBackColor = true;
            // 
            // existingtemplate
            // 
            this.existingtemplate.AutoSize = true;
            this.existingtemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingtemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.existingtemplate.Location = new System.Drawing.Point(262, 164);
            this.existingtemplate.Name = "existingtemplate";
            this.existingtemplate.Size = new System.Drawing.Size(231, 33);
            this.existingtemplate.TabIndex = 3;
            this.existingtemplate.TabStop = true;
            this.existingtemplate.Text = "Existing Template\r\n";
            this.existingtemplate.UseVisualStyleBackColor = true;
            // 
            // Errorstemplate
            // 
            this.Errorstemplate.AutoSize = true;
            this.Errorstemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errorstemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Errorstemplate.Location = new System.Drawing.Point(258, 203);
            this.Errorstemplate.Name = "Errorstemplate";
            this.Errorstemplate.Size = new System.Drawing.Size(235, 33);
            this.Errorstemplate.TabIndex = 4;
            this.Errorstemplate.TabStop = true;
            this.Errorstemplate.Text = "Error Explanations";
            this.Errorstemplate.UseVisualStyleBackColor = true;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Errorstemplate);
            this.Controls.Add(this.existingtemplate);
            this.Controls.Add(this.Createnew);
            this.Controls.Add(this.Welcomelabel);
            this.Name = "Intro";
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.RadioButton Createnew;
        private System.Windows.Forms.RadioButton existingtemplate;
        private System.Windows.Forms.RadioButton Errorstemplate;
    }
}

