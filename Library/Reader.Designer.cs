namespace Library
{
    partial class Reader
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(764, 199);
            this.listBox1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(30, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "label1";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(117, 9);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(35, 13);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "label2";
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.Location = new System.Drawing.Point(205, 9);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(35, 13);
            this.Birth.TabIndex = 3;
            this.Birth.Text = "label3";
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.listBox1);
            this.Name = "Reader";
            this.Text = "Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Birth;
    }
}