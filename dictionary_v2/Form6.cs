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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace dictionary_v2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        string[] word;

        private void homePageBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        public void list_box_file_refresh()
        {
            string[] filePath = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\");
            string[] fileName = new string[filePath.Length];

            for (int i = 0; i < filePath.Length; i++)
            {
                fileName[i] = new FileInfo(filePath[i]).Name;
            }

            listBox1.Items.Clear();
            foreach (string i in fileName)
            {
                listBox1.Items.Add(i);
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            word = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\dictionary\" + listBox1.SelectedItems[0].ToString()).Split('$');
            listBox1.Items.Clear();

            int j = 0;


            for (int i = 0; i < word.Length - 1; i++)
            {
                string[] strings = word[i].Split('@');

                listBox1.Items.Add(strings[0]);
                j++;
                listBox1.Items.Add(strings[1]);
                listBox1.Items.Add(" ");
                
            }

            openBtn.Enabled = false;
            backBtn.Enabled = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            list_box_file_refresh();
            openBtn.Enabled = true;
            backBtn.Enabled = false;
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
