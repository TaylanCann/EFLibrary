namespace EFLibrary.Forms
{
    partial class BookScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dateTimeBookYear = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Year";
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(173, 89);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(125, 27);
            this.txtPageCount.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Page Count";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(173, 40);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(125, 27);
            this.txtBookName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Book Name";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(77, 323);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(173, 63);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dateTimeBookYear
            // 
            this.dateTimeBookYear.Location = new System.Drawing.Point(171, 136);
            this.dateTimeBookYear.Name = "dateTimeBookYear";
            this.dateTimeBookYear.Size = new System.Drawing.Size(127, 27);
            this.dateTimeBookYear.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Author";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(171, 177);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(127, 28);
            this.cbAuthor.TabIndex = 19;
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 20;
            this.lbCategories.Location = new System.Drawing.Point(415, 40);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCategories.Size = new System.Drawing.Size(156, 164);
            this.lbCategories.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Categories";
            // 
            // BookScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeBookYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBook);
            this.Name = "BookScreen";
            this.Text = "BookScreen";
            this.Load += new System.EventHandler(this.BookScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DateTimePicker dateTimeBookYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.Label label4;
    }
}