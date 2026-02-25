namespace dictionary_v2
{
    partial class Form3
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
            this.homePageBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.renameDir = new System.Windows.Forms.Button();
            this.addDir = new System.Windows.Forms.Button();
            this.addWord = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homePageBtn
            // 
            this.homePageBtn.Location = new System.Drawing.Point(12, 22);
            this.homePageBtn.Name = "homePageBtn";
            this.homePageBtn.Size = new System.Drawing.Size(122, 46);
            this.homePageBtn.TabIndex = 1;
            this.homePageBtn.Text = "Home Page";
            this.homePageBtn.UseVisualStyleBackColor = true;
            this.homePageBtn.Click += new System.EventHandler(this.homePageBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(12, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1018, 328);
            this.listBox1.TabIndex = 8;
            // 
            // renameDir
            // 
            this.renameDir.Location = new System.Drawing.Point(140, 22);
            this.renameDir.Name = "renameDir";
            this.renameDir.Size = new System.Drawing.Size(122, 46);
            this.renameDir.TabIndex = 3;
            this.renameDir.Text = "Rename File";
            this.renameDir.UseVisualStyleBackColor = true;
            this.renameDir.Click += new System.EventHandler(this.renameDir_Click);
            // 
            // addDir
            // 
            this.addDir.Location = new System.Drawing.Point(268, 22);
            this.addDir.Name = "addDir";
            this.addDir.Size = new System.Drawing.Size(122, 46);
            this.addDir.TabIndex = 2;
            this.addDir.Text = "Add File";
            this.addDir.UseVisualStyleBackColor = true;
            this.addDir.Click += new System.EventHandler(this.addDir_Click);
            // 
            // addWord
            // 
            this.addWord.Enabled = false;
            this.addWord.Location = new System.Drawing.Point(396, 22);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(122, 46);
            this.addWord.TabIndex = 0;
            this.addWord.Text = "Add Word";
            this.addWord.UseVisualStyleBackColor = true;
            this.addWord.Click += new System.EventHandler(this.addWord_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(780, 22);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(122, 46);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(185, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(845, 34);
            this.textBox1.TabIndex = 7;
            // 
            // backBtn
            // 
            this.backBtn.Enabled = false;
            this.backBtn.Location = new System.Drawing.Point(652, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(122, 46);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(524, 22);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(122, 46);
            this.openBtn.TabIndex = 4;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Files";
            // 
            // moveBtn
            // 
            this.moveBtn.Enabled = false;
            this.moveBtn.Location = new System.Drawing.Point(908, 22);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(122, 46);
            this.moveBtn.TabIndex = 11;
            this.moveBtn.Text = "Move";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 552);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addWord);
            this.Controls.Add(this.addDir);
            this.Controls.Add(this.renameDir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.homePageBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homePageBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button renameDir;
        private System.Windows.Forms.Button addDir;
        private System.Windows.Forms.Button addWord;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button moveBtn;
    }
}