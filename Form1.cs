using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__GUI_Assessment
{
    public partial class Form1 : Form

    {
        private List<string> wordList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string newWord = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(newWord))
            {
                wordList.Add(newWord);
                UpdateWordList();
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                wordList.RemoveAt(listBox1.SelectedIndex);
                UpdateWordList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string updatedWord = textBox1.Text.Trim();
                if (!string.IsNullOrEmpty(updatedWord))
                {
                    wordList[listBox1.SelectedIndex] = updatedWord;
                    UpdateWordList();
                }
                textBox1.Clear();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wordList.Clear();
            UpdateWordList();
        }
        private void UpdateWordList()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(wordList.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
