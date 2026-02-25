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

namespace dictionary_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            Directory.CreateDirectory(path);
        }

        bool enable = false;
        List<string> words_path = new List<string>();
        List<string> words = new List<string>();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\";

        private void optionBtn_Click(object sender, EventArgs e)
        {
            readBtn.Visible = !enable;
            manageBtn.Visible = !enable;
            examBtn.Visible = !enable;
            enable = !enable;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string word_name = searchResListBox.SelectedItem.ToString();

                for (int i = 0; i < words.Count(); i++)
                {
                    string[] wordInfo = words[i].Split('@');

                    if (wordInfo[0] == word_name)
                    {
                        Form2 form2 = new Form2();
                        form2.filepath = words_path[i];
                        form2.formback = 1;
                        form2.editBtn.Enabled = true;
                        form2.editBtn.Visible = true;
                        form2.txtWord.Text = wordInfo[0];
                        form2.txtMeaning.Text = wordInfo[1];
                        form2.txtOther.Text = wordInfo[2];

                        if (wordInfo[3] == "True")
                        {
                            form2.starBtn.Text = "Star";
                        }

                        else
                        {
                            form2.starBtn.Text = "Not Star";
                        }

                        form2.starBtn.Enabled = false;
                        form2.saveBtn.Enabled = false;
                        form2.txtOther.Enabled = false;
                        form2.txtWord.Enabled = false;
                        form2.txtMeaning.Enabled = false;
                        this.Hide();
                        form2.Show();
                    }
                }
            }

            catch { }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchResListBox.Items.Clear();
            openBtn.Visible = true;

            //Read Data

            string[] files_list = Directory.GetFiles(path);
            words_path.Clear();
            words.Clear();

            for (int i = 0; i < files_list.Length; i++)
            {

                string[] word = File.ReadAllText(files_list[i]).Split('$');
                for (int j = 0; j < word.Length; j++)
                {
                    words.Add(word[j]);
                    words_path.Add(files_list[i]);
                }
            }

            searchResListBox.Enabled = true;
            searchResListBox.Visible = true;


            // search


            string typed_letters = textBox1.Text;

            for (int i = 0; i < words.Count(); i++)
            {
                int index = 0;
                string word = words[i].Split('@')[0];

                if (typed_letters.Length > word.Length)
                {
                    continue;
                }

                if (typed_letters == word)
                {
                    searchResListBox.Items.Add(word);
                    continue;
                }


                for (int j = 0; j < word.Length; j++)
                {
                    if (word.Length - j < typed_letters.Length - index || index == typed_letters.Length)
                    {
                        break;
                    }

                    if (typed_letters[index] == word[j])
                    {
                        index++;
                    }

                    else
                    {
                        index = 0;
                    }
                }

                if (index == typed_letters.Length)
                {
                    searchResListBox.Items.Add(word);
                }
            }
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            form3.list_box_file_refresh();
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
            form6.list_box_file_refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
