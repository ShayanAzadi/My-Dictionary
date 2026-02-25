namespace dictionary_v2
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
            this.searchResListBox = new System.Windows.Forms.ListBox();
            this.manageBtn = new System.Windows.Forms.Button();
            this.examBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.optionBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchResListBox
            // 
            this.searchResListBox.Enabled = false;
            this.searchResListBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResListBox.FormattingEnabled = true;
            this.searchResListBox.ItemHeight = 34;
            this.searchResListBox.Location = new System.Drawing.Point(15, 238);
            this.searchResListBox.Name = "searchResListBox";
            this.searchResListBox.Size = new System.Drawing.Size(604, 208);
            this.searchResListBox.TabIndex = 15;
            this.searchResListBox.Visible = false;
            // 
            // manageBtn
            // 
            this.manageBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBtn.Location = new System.Drawing.Point(12, 119);
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.Size = new System.Drawing.Size(77, 30);
            this.manageBtn.TabIndex = 14;
            this.manageBtn.Text = "Manage";
            this.manageBtn.UseVisualStyleBackColor = true;
            this.manageBtn.Visible = false;
            this.manageBtn.Click += new System.EventHandler(this.manageBtn_Click);
            // 
            // examBtn
            // 
            this.examBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examBtn.Location = new System.Drawing.Point(12, 83);
            this.examBtn.Name = "examBtn";
            this.examBtn.Size = new System.Drawing.Size(77, 30);
            this.examBtn.TabIndex = 13;
            this.examBtn.Text = "Test";
            this.examBtn.UseVisualStyleBackColor = true;
            this.examBtn.Visible = false;
            this.examBtn.Click += new System.EventHandler(this.examBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.Location = new System.Drawing.Point(12, 47);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(77, 30);
            this.readBtn.TabIndex = 12;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Visible = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // optionBtn
            // 
            this.optionBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionBtn.Location = new System.Drawing.Point(12, 11);
            this.optionBtn.Name = "optionBtn";
            this.optionBtn.Size = new System.Drawing.Size(77, 30);
            this.optionBtn.TabIndex = 11;
            this.optionBtn.Text = "...";
            this.optionBtn.UseVisualStyleBackColor = true;
            this.optionBtn.Click += new System.EventHandler(this.optionBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(648, 189);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(122, 53);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 49);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 73);
            this.label1.TabIndex = 8;
            this.label1.Text = "My Dictionary";
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.Location = new System.Drawing.Point(648, 248);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(122, 53);
            this.openBtn.TabIndex = 16;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Visible = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(698, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.searchResListBox);
            this.Controls.Add(this.manageBtn);
            this.Controls.Add(this.examBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.optionBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox searchResListBox;
        private System.Windows.Forms.Button manageBtn;
        private System.Windows.Forms.Button examBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button optionBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button button1;
    }
}

