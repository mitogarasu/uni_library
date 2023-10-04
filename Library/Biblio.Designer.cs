namespace Library
{
    partial class Biblio
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
            this.Add_book = new System.Windows.Forms.Button();
            this.Update_book = new System.Windows.Forms.Button();
            this.Delete_book = new System.Windows.Forms.Button();
            this.List_books = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.List_readers = new System.Windows.Forms.Button();
            this.Delete_reader = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Add_reader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_book
            // 
            this.Add_book.Location = new System.Drawing.Point(13, 37);
            this.Add_book.Name = "Add_book";
            this.Add_book.Size = new System.Drawing.Size(131, 23);
            this.Add_book.TabIndex = 0;
            this.Add_book.Text = "Добавить книгу";
            this.Add_book.UseVisualStyleBackColor = true;
            // 
            // Update_book
            // 
            this.Update_book.Location = new System.Drawing.Point(13, 78);
            this.Update_book.Name = "Update_book";
            this.Update_book.Size = new System.Drawing.Size(131, 23);
            this.Update_book.TabIndex = 1;
            this.Update_book.Text = "Редактировать книгу";
            this.Update_book.UseVisualStyleBackColor = true;
            // 
            // Delete_book
            // 
            this.Delete_book.Location = new System.Drawing.Point(13, 120);
            this.Delete_book.Name = "Delete_book";
            this.Delete_book.Size = new System.Drawing.Size(131, 23);
            this.Delete_book.TabIndex = 2;
            this.Delete_book.Text = "Удалить книгу";
            this.Delete_book.UseVisualStyleBackColor = true;
            // 
            // List_books
            // 
            this.List_books.Location = new System.Drawing.Point(13, 163);
            this.List_books.Name = "List_books";
            this.List_books.Size = new System.Drawing.Size(131, 23);
            this.List_books.TabIndex = 3;
            this.List_books.Text = "Просмотреть книги";
            this.List_books.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(189, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 147);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(189, 219);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 147);
            this.listBox2.TabIndex = 9;
            // 
            // List_readers
            // 
            this.List_readers.Location = new System.Drawing.Point(13, 345);
            this.List_readers.Name = "List_readers";
            this.List_readers.Size = new System.Drawing.Size(152, 23);
            this.List_readers.TabIndex = 8;
            this.List_readers.Text = "Просмотреть читателей";
            this.List_readers.UseVisualStyleBackColor = true;
            // 
            // Delete_reader
            // 
            this.Delete_reader.Location = new System.Drawing.Point(13, 302);
            this.Delete_reader.Name = "Delete_reader";
            this.Delete_reader.Size = new System.Drawing.Size(152, 23);
            this.Delete_reader.TabIndex = 7;
            this.Delete_reader.Text = "Удалить читателя";
            this.Delete_reader.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Редактировать читателя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add_reader
            // 
            this.Add_reader.Location = new System.Drawing.Point(13, 219);
            this.Add_reader.Name = "Add_reader";
            this.Add_reader.Size = new System.Drawing.Size(152, 23);
            this.Add_reader.TabIndex = 5;
            this.Add_reader.Text = "Добавить читателя";
            this.Add_reader.UseVisualStyleBackColor = true;
            // 
            // Biblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.List_readers);
            this.Controls.Add(this.Delete_reader);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Add_reader);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.List_books);
            this.Controls.Add(this.Delete_book);
            this.Controls.Add(this.Update_book);
            this.Controls.Add(this.Add_book);
            this.Name = "Biblio";
            this.Text = "Biblio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_book;
        private System.Windows.Forms.Button Update_book;
        private System.Windows.Forms.Button Delete_book;
        private System.Windows.Forms.Button List_books;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button List_readers;
        private System.Windows.Forms.Button Delete_reader;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Add_reader;
    }
}