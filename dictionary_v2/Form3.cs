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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        bool not_in_file = true;
        public string file_name = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\";
        string[] word;
        bool cut = false;
        string[] movedWordDate;

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void addDir_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text;
            File.Create(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\" + fileName + ".txt").Close();
            textBox1.Text = string.Empty;
            list_box_file_refresh();
        }

        private void renameDir_Click(object sender, EventArgs e)
        {
            string selectedName = listBox1.SelectedItem.ToString();
            string newName = textBox1.Text + ".txt";
            textBox1.Text = string.Empty;
            File.Move(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\" + selectedName, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\" + newName);
            list_box_file_refresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (not_in_file)
            {
                string fileName = listBox1.SelectedItem.ToString();
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\" + fileName);
                list_box_file_refresh();
            }

            else
            {
                File.WriteAllText(file_name, "");

                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (i == listBox1.SelectedIndex)
                    {
                        continue;
                    }

                    File.AppendAllText(file_name, word[i] + "$");
                }

                list_box_word_refresh();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            file_name = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\";
            list_box_file_refresh();
            not_in_file = true;
            renameDir.Enabled = true;
            addDir.Enabled = true;
            backBtn.Enabled = false;
            moveBtn.Enabled = false;
            addWord.Enabled = false;
            textBox1.Enabled = true;
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Text = "Files";
        }
        private void moveBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0 && !not_in_file)
            {
                int index = listBox1.SelectedIndex;
                movedWordDate = word[index].Split('@');
                
                cut = true;
                renameDir.Enabled = false;
                addDir.Enabled = false;
                backBtn.Enabled = false;
                moveBtn.Enabled = true;
                deleteBtn.Enabled = false;
                addWord.Enabled = false;
                openBtn.Enabled = false;
                textBox1.Enabled = false;
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Text = "Files";

                File.WriteAllText(file_name, "");

                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }

                    File.AppendAllText(file_name, word[i] + "$");
                }

                file_name = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\";
                list_box_file_refresh();
                not_in_file = true;
            }

            else if (listBox1.SelectedItems.Count != 0 && not_in_file && cut)
            {
                file_name += listBox1.SelectedItem.ToString();
                cut = false;
                File.AppendAllText(file_name, movedWordDate[0] + "@" + movedWordDate[1] + "@" + movedWordDate[2] + "@" + movedWordDate[3] + "$");

                renameDir.Enabled = true;
                addDir.Enabled = true;
                deleteBtn.Enabled = true;
                moveBtn.Enabled = false;
                openBtn.Enabled = true;
                textBox1.Enabled = true;
                file_name = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\";
                list_box_file_refresh();
            }

        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (not_in_file)
            {
                file_name += listBox1.SelectedItem.ToString();
                not_in_file = false;
                renameDir.Enabled = false;
                addDir.Enabled = false;
                backBtn.Enabled = true;
                moveBtn.Enabled = true;
                addWord.Enabled = true;
                textBox1.Enabled = false;
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Text = listBox1.SelectedItem.ToString();
                list_box_word_refresh();
            }

            else
            {
                Form2 form2 = new Form2();
                form2.filepath = file_name;
                form2.editBtn.Enabled = true;
                form2.editBtn.Visible = true;
                form2.formback = 3;

                int index = listBox1.SelectedIndex;
                string[] wordInfo = word[index].Split('@');

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

        private void addWord_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.formback = 3;
            this.Hide();
            form2.Show();
            form2.filepath = file_name;
        }

        public void list_box_file_refresh()
        {
            if (file_name == Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\") 
            {
                string[] filePath = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\");
                string[] fileName = new string[filePath.Length];

                for (int i = 0; i < filePath.Length; i++)
                {
                    fileName[i] = new FileInfo(filePath[i]).Name;
                }

                listBox1.Items.Clear();
                listBox1.Items.AddRange(fileName);
            }

            else
            {
                not_in_file = false;
                renameDir.Enabled = false;
                addDir.Enabled = false;
                backBtn.Enabled = true;
                moveBtn.Enabled = true;
                addWord.Enabled = true;
                textBox1.Enabled = false;
                label1.Visible = false;
                textBox1.Visible = false;
                string[] arr = file_name.Split('\\');
                label2.Text = arr[arr.Length - 1];
                list_box_word_refresh();
            }
        }

        private void list_box_word_refresh()
        {
            listBox1.Items.Clear();
            word = File.ReadAllText(file_name).Split('$');


            for (int i = 0; i < word.Length - 1; i++)
            {
                string[] strings = word[i].Split('@');

                listBox1.Items.Add(strings[0]);
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
