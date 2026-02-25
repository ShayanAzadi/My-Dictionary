using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.CodeDom;

namespace dictionary_v2
{
    public partial class Form5 : Form
    {

        string[] selected_files_path;
        int number_of_questions;
        string[] questions, answers, info;
        int questIndex = 0;
        bool only_star;

        public Form5(string[] selected_files, int number_of_question, bool just_star)
        {
            InitializeComponent();
            MaximizeBox = false;

            selected_files_path = selected_files;

            number_of_questions = number_of_question;
            only_star = just_star;
            examQuestMaker();

            questionLabel.Text = questions[questIndex];
            ansLabel.Text = answers[questIndex];
            numberOfQuests.Text = "1 / " + number_of_questions.ToString();
            richTextBox1.Text = info[questIndex];
        }

        // next and show answer button
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (nextBtn.Text == "Show Answer")
            {
                if (questIndex == number_of_questions - 1)
                    nextBtn.Text = "Done";

                else
                    nextBtn.Text = "Next";
                

                ansLabel.Visible = true;
                richTextBox1.Visible = true;
            }

            else if (nextBtn.Text == "Next")
            {
                questIndex++;
                numberOfQuests.Text = (questIndex + 1).ToString() + " / " + number_of_questions.ToString();
                nextBtn.Text = "Show Answer";
                questionLabel.Text = questions[questIndex];
                ansLabel.Text = answers[questIndex];
                ansLabel.Visible = false;
                richTextBox1.Visible = false;
                richTextBox1.Text = info[questIndex];
            }

            else if (nextBtn.Text == "Done")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void examQuestMaker()
        {
            List<string> words = new List<string>();
            List<string> meanings = new List<string>();
            List<string> otherInfo = new List<string>();
            
            foreach (string i in selected_files_path)
            {
                string[] fileInfo = File.ReadAllText(i).Split('$');

                for (int j = 0; j < fileInfo.Length - 1; j++)
                {
                    string[] wordInfo = fileInfo[j].Split('@');

                    if (only_star is true && wordInfo[3] == "True" || only_star is false) 
                    {
                        words.Add(wordInfo[0]);
                        meanings.Add(wordInfo[1]);
                        otherInfo.Add(wordInfo[2]);
                    }
                }
            }

            if (number_of_questions == -1)
            {
                number_of_questions = words.Count;
            }

            if (number_of_questions > words.Count)
            {
                number_of_questions = words.Count;
            }


            questions = new string[number_of_questions];
            answers = new string[number_of_questions];
            info = new string[number_of_questions];
            Random random = new Random();

            for (int i = 0; i < number_of_questions; i++)
            {
                int random_num = random.Next(0, words.Count());
                questions[i] = words[random_num];
                answers[i] = meanings[random_num];
                info[i] = otherInfo[random_num];

                words.RemoveAt(random_num);
                meanings.RemoveAt(random_num);
                otherInfo.RemoveAt(random_num);
            }
        }

        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }
    }
}
