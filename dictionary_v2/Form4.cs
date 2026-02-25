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
using System.Windows.Forms.VisualStyles;

namespace dictionary_v2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            file_path = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\");
            MaximizeBox = false;
        }

        string[] file_path;

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void selectRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = selectRadioBtn.Checked;

            foreach (var i in file_path)
            {
                string name = new FileInfo(i).Name;
                listBox1.Items.Add(name);
            }
        }

        private void makeExamBtn_Click(object sender, EventArgs e)
        {
            string[] selected_files_path;

            if (listBox1.Visible)
            {
                var selected_topics = listBox1.SelectedIndices;
                selected_files_path = new string[selected_topics.Count];


                for (int i = 0; i < selected_topics.Count; i++)
                {
                    selected_files_path[i] = file_path[selected_topics[i]];
                }
            }

            else
            {
                selected_files_path = file_path;
            }


            int number_of_question = (int)numericUpDown1.Value;

            if (checkBox2.Checked is true)
                number_of_question = -1;


            Form5 form5 = new Form5(selected_files_path, number_of_question, checkBox1.Checked);
            form5.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = !checkBox2.Checked;
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
