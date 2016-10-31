namespace Dictionary_words
{
    partial class Form1
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
            this.lbxWords = new System.Windows.Forms.ListBox();
            this.btnLoadWords = new System.Windows.Forms.Button();
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxRndWords = new System.Windows.Forms.ListBox();
            this.btnCreateAnagram = new System.Windows.Forms.Button();
            this.lbxAnagramPhrases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxWords
            // 
            this.lbxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxWords.FormattingEnabled = true;
            this.lbxWords.HorizontalScrollbar = true;
            this.lbxWords.ItemHeight = 29;
            this.lbxWords.Location = new System.Drawing.Point(551, 1);
            this.lbxWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxWords.Name = "lbxWords";
            this.lbxWords.Size = new System.Drawing.Size(382, 91);
            this.lbxWords.TabIndex = 0;
            // 
            // btnLoadWords
            // 
            this.btnLoadWords.Location = new System.Drawing.Point(13, 1);
            this.btnLoadWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadWords.Name = "btnLoadWords";
            this.btnLoadWords.Size = new System.Drawing.Size(128, 41);
            this.btnLoadWords.TabIndex = 1;
            this.btnLoadWords.Text = "Load Words";
            this.btnLoadWords.UseVisualStyleBackColor = true;
            this.btnLoadWords.Click += new System.EventHandler(this.btnLoadWords_Click);
            // 
            // txtInputWord
            // 
            this.txtInputWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputWord.Location = new System.Drawing.Point(12, 94);
            this.txtInputWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputWord.Multiline = true;
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(921, 69);
            this.txtInputWord.TabIndex = 2;
            this.txtInputWord.Text = "Honouring God and keeping our heads above water";
            this.txtInputWord.TextChanged += new System.EventHandler(this.txtInputWord_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Anagram";
            // 
            // lbxRndWords
            // 
            this.lbxRndWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRndWords.FormattingEnabled = true;
            this.lbxRndWords.HorizontalScrollbar = true;
            this.lbxRndWords.ItemHeight = 22;
            this.lbxRndWords.Location = new System.Drawing.Point(321, 1);
            this.lbxRndWords.Name = "lbxRndWords";
            this.lbxRndWords.Size = new System.Drawing.Size(224, 92);
            this.lbxRndWords.TabIndex = 5;
            // 
            // btnCreateAnagram
            // 
            this.btnCreateAnagram.Location = new System.Drawing.Point(147, 3);
            this.btnCreateAnagram.Name = "btnCreateAnagram";
            this.btnCreateAnagram.Size = new System.Drawing.Size(168, 39);
            this.btnCreateAnagram.TabIndex = 6;
            this.btnCreateAnagram.Text = "Create Anagram";
            this.btnCreateAnagram.UseVisualStyleBackColor = true;
            this.btnCreateAnagram.Click += new System.EventHandler(this.btnCreateAnagram_Click);
            // 
            // lbxAnagramPhrases
            // 
            this.lbxAnagramPhrases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAnagramPhrases.FormattingEnabled = true;
            this.lbxAnagramPhrases.HorizontalScrollbar = true;
            this.lbxAnagramPhrases.ItemHeight = 29;
            this.lbxAnagramPhrases.Location = new System.Drawing.Point(12, 161);
            this.lbxAnagramPhrases.Name = "lbxAnagramPhrases";
            this.lbxAnagramPhrases.Size = new System.Drawing.Size(921, 323);
            this.lbxAnagramPhrases.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 527);
            this.Controls.Add(this.lbxAnagramPhrases);
            this.Controls.Add(this.btnCreateAnagram);
            this.Controls.Add(this.lbxRndWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputWord);
            this.Controls.Add(this.btnLoadWords);
            this.Controls.Add(this.lbxWords);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWords;
        private System.Windows.Forms.Button btnLoadWords;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxRndWords;
        private System.Windows.Forms.Button btnCreateAnagram;
        private System.Windows.Forms.ListBox lbxAnagramPhrases;
    }
}

