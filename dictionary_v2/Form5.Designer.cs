namespace dictionary_v2
{
    partial class Form5
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.operatorAns = new System.Windows.Forms.Label();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.ansLabel = new System.Windows.Forms.Label();
            this.numberOfQuests = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(10, 70);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(268, 46);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "questionLabel";
            // 
            // operatorAns
            // 
            this.operatorAns.AutoSize = true;
            this.operatorAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorAns.Location = new System.Drawing.Point(12, 197);
            this.operatorAns.Name = "operatorAns";
            this.operatorAns.Size = new System.Drawing.Size(196, 36);
            this.operatorAns.TabIndex = 1;
            this.operatorAns.Text = "Your Answer:";
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTxtBox.Location = new System.Drawing.Point(12, 255);
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.Size = new System.Drawing.Size(1018, 41);
            this.answerTxtBox.TabIndex = 2;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(848, 390);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(182, 44);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Show Answer";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansLabel.Location = new System.Drawing.Point(12, 320);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(111, 29);
            this.ansLabel.TabIndex = 4;
            this.ansLabel.Text = "ansLabel";
            this.ansLabel.Visible = false;
            // 
            // numberOfQuests
            // 
            this.numberOfQuests.AutoSize = true;
            this.numberOfQuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numberOfQuests.Location = new System.Drawing.Point(11, 9);
            this.numberOfQuests.Name = "numberOfQuests";
            this.numberOfQuests.Size = new System.Drawing.Size(79, 29);
            this.numberOfQuests.TabIndex = 5;
            this.numberOfQuests.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(1036, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(485, 314);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 448);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberOfQuests);
            this.Controls.Add(this.ansLabel);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.operatorAns);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label ansLabel;
        private System.Windows.Forms.Label numberOfQuests;
        public System.Windows.Forms.Label operatorAns;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}