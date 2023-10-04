namespace Library
{
    partial class MainForm
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
            this.biblio = new System.Windows.Forms.Button();
            this.reader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // biblio
            // 
            this.biblio.Location = new System.Drawing.Point(203, 180);
            this.biblio.Name = "biblio";
            this.biblio.Size = new System.Drawing.Size(101, 23);
            this.biblio.TabIndex = 0;
            this.biblio.Text = "Библиотекарь";
            this.biblio.UseVisualStyleBackColor = true;
            this.biblio.Click += new System.EventHandler(this.biblio_Click);
            // 
            // reader
            // 
            this.reader.Location = new System.Drawing.Point(478, 180);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(75, 23);
            this.reader.TabIndex = 1;
            this.reader.Text = "Читатель";
            this.reader.UseVisualStyleBackColor = true;
            this.reader.Click += new System.EventHandler(this.reader_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.biblio);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button biblio;
        private System.Windows.Forms.Button reader;
    }
}