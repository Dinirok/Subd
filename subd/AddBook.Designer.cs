namespace subd
{
    partial class AddBook
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
            this.nameOfBook = new System.Windows.Forms.TextBox();
            this.BookGenre = new System.Windows.Forms.TextBox();
            this.NameAuthor = new System.Windows.Forms.TextBox();
            this.BookAdd = new System.Windows.Forms.Button();
            this.Opisanie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameOfBook
            // 
            this.nameOfBook.Location = new System.Drawing.Point(24, 46);
            this.nameOfBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameOfBook.Multiline = true;
            this.nameOfBook.Name = "nameOfBook";
            this.nameOfBook.Size = new System.Drawing.Size(185, 67);
            this.nameOfBook.TabIndex = 0;
            // 
            // BookGenre
            // 
            this.BookGenre.Location = new System.Drawing.Point(215, 46);
            this.BookGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookGenre.Multiline = true;
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.Size = new System.Drawing.Size(175, 67);
            this.BookGenre.TabIndex = 1;
            this.BookGenre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NameAuthor
            // 
            this.NameAuthor.Location = new System.Drawing.Point(396, 46);
            this.NameAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameAuthor.Multiline = true;
            this.NameAuthor.Name = "NameAuthor";
            this.NameAuthor.Size = new System.Drawing.Size(185, 67);
            this.NameAuthor.TabIndex = 2;
            // 
            // BookAdd
            // 
            this.BookAdd.Location = new System.Drawing.Point(335, 179);
            this.BookAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookAdd.Name = "BookAdd";
            this.BookAdd.Size = new System.Drawing.Size(121, 41);
            this.BookAdd.TabIndex = 3;
            this.BookAdd.Text = "Добавить книгу";
            this.BookAdd.UseVisualStyleBackColor = true;
            this.BookAdd.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // Opisanie
            // 
            this.Opisanie.Location = new System.Drawing.Point(587, 46);
            this.Opisanie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Opisanie.Multiline = true;
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.Size = new System.Drawing.Size(185, 67);
            this.Opisanie.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Жанр книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Автор книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Описание книги";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Opisanie);
            this.Controls.Add(this.BookAdd);
            this.Controls.Add(this.NameAuthor);
            this.Controls.Add(this.BookGenre);
            this.Controls.Add(this.nameOfBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameOfBook;
        private System.Windows.Forms.TextBox BookGenre;
        private System.Windows.Forms.TextBox NameAuthor;
        private System.Windows.Forms.Button BookAdd;
        private System.Windows.Forms.TextBox Opisanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}