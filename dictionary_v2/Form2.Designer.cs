namespace dictionary_v2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.RichTextBox();
            this.homePageBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.starBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meaning:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Other Information: ";
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(18, 295);
            this.txtOther.Name = "txtOther";
            this.txtOther.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOther.Size = new System.Drawing.Size(1172, 300);
            this.txtOther.TabIndex = 3;
            this.txtOther.Text = "";
            // 
            // homePageBtn
            // 
            this.homePageBtn.Location = new System.Drawing.Point(1091, 99);
            this.homePageBtn.Name = "homePageBtn";
            this.homePageBtn.Size = new System.Drawing.Size(99, 38);
            this.homePageBtn.TabIndex = 6;
            this.homePageBtn.Text = "Cancel";
            this.homePageBtn.UseVisualStyleBackColor = true;
            this.homePageBtn.Click += new System.EventHandler(this.homePageBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1091, 56);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(99, 38);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(114, 12);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(971, 38);
            this.txtWord.TabIndex = 1;
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(18, 196);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(1172, 38);
            this.txtMeaning.TabIndex = 2;
            // 
            // starBtn
            // 
            this.starBtn.Location = new System.Drawing.Point(1091, 12);
            this.starBtn.Name = "starBtn";
            this.starBtn.Size = new System.Drawing.Size(99, 38);
            this.starBtn.TabIndex = 4;
            this.starBtn.Text = "Not Star";
            this.starBtn.UseVisualStyleBackColor = true;
            this.starBtn.Click += new System.EventHandler(this.starBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(1091, 143);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(99, 38);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 610);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.starBtn);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.homePageBtn);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button homePageBtn;
        public System.Windows.Forms.RichTextBox txtOther;
        public System.Windows.Forms.TextBox txtWord;
        public System.Windows.Forms.TextBox txtMeaning;
        public System.Windows.Forms.Button starBtn;
        public System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.Button editBtn;
    }
}