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
    public partial class Form2 : Form
    {

        public string filepath;
        private bool star = false;
        private bool edit_mode = false;
        private int index_edit = 0;
        public int formback;

        string word_text_pre, meaning_text_pre, other_text_pre;

        public Form2()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        
        private void homePageBtn_Click(object sender, EventArgs e)    // cancel button
        {
            if (!edit_mode)
            {
                if (formback == 3)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                    form3.file_name = filepath;
                    System.Diagnostics.Debug.WriteLine(filepath);
                    form3.list_box_file_refresh();
                }

                else
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }

            else
            {
                edit_mode = false;
                starBtn.Enabled = false;
                saveBtn.Enabled = false;
                txtOther.Enabled = false;
                txtWord.Enabled = false;
                txtMeaning.Enabled = false;
                edit_mode = false;
                editBtn.Enabled = true;
                txtWord.Text = word_text_pre;
                txtMeaning.Text = meaning_text_pre;
                txtOther.Text = other_text_pre;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (txtWord.Text != "" && txtMeaning.Text != "" && !edit_mode)
            {
                File.AppendAllText(filepath, txtWord.Text + "@" + txtMeaning.Text + "@" + txtOther.Text + "@" + star.ToString() + "$");
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
                form3.file_name = filepath;
                form3.list_box_file_refresh();
            }

            else if (!edit_mode)
            {
                MessageBox.Show("You Have To Fill Out The Text Boxes Completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtWord.Text == "")
                {
                    txtWord.Focus();
                }

                else
                {
                    txtMeaning.Focus();
                }
            }

            else
            {
                string[] text = File.ReadAllText(filepath).Split('$');
                File.WriteAllText(filepath, "");

                for (int i = 0; i < text.Length; i++)
                {
                    if (i == index_edit)
                    {
                        File.AppendAllText(filepath, txtWord.Text + "@" + txtMeaning.Text + "@" + txtOther.Text + "@" + star.ToString() + "$");
                    }

                    else if (text[i] != string.Empty)
                    {
                        File.AppendAllText(filepath, text[i] + "$");
                    }
                }

                if (formback == 3)
                {
                    Form3 form3 = new Form3();
                    this.Hide();
                    form3.Show();
                    form3.file_name = filepath;
                    form3.list_box_file_refresh();
                }

                else
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                }
            }
        }

        private void starBtn_Click(object sender, EventArgs e)
        {
            if (starBtn.Text == "Star")
                starBtn.Text = "Not Star";

            else
                starBtn.Text = "Star";

            star = !star;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            starBtn.Enabled = true;
            saveBtn.Enabled = true;
            txtOther.Enabled = true;
            txtWord.Enabled = true;
            txtMeaning.Enabled = true;
            edit_mode = true;
            editBtn.Enabled = false;

            string[] text = File.ReadAllText(filepath).Split('$');

            for (int i = 0; i < text.Length; i++)
            {
                string[] word = text[i].Split('@');

                if (word[0] == txtWord.Text)
                {
                    index_edit = i;
                    break;
                }
            }

            word_text_pre = txtWord.Text;
            meaning_text_pre = txtMeaning.Text;
            other_text_pre = txtOther.Text;
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
