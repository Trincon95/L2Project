namespace L2Project
{
    partial class yourname
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
            this.yournamebox = new System.Windows.Forms.TextBox();
            this.YNGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yournamebox
            // 
            this.yournamebox.Location = new System.Drawing.Point(52, 81);
            this.yournamebox.Name = "yournamebox";
            this.yournamebox.Size = new System.Drawing.Size(159, 26);
            this.yournamebox.TabIndex = 0;
            this.yournamebox.TextChanged += new System.EventHandler(this.yournamebox_TextChanged);
            // 
            // YNGo
            // 
            this.YNGo.AutoSize = true;
            this.YNGo.Location = new System.Drawing.Point(241, 81);
            this.YNGo.Name = "YNGo";
            this.YNGo.Size = new System.Drawing.Size(45, 30);
            this.YNGo.TabIndex = 1;
            this.YNGo.Text = "Go";
            this.YNGo.UseVisualStyleBackColor = true;
            // 
            // yourname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 194);
            this.Controls.Add(this.YNGo);
            this.Controls.Add(this.yournamebox);
            this.Name = "yourname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yourname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yournamebox;
        private System.Windows.Forms.Button YNGo;
    }
}