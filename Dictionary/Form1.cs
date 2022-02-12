using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Word is invalid!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Mean is invalid!");
                textBox2.Focus();
                return;
            }
            listBox1.Items.Add(new NewWord() { Word = textBox1.Text, Mean = textBox2.Text });
            textBox1.Text = textBox2.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                NewWord word = (NewWord)listBox1.SelectedItem;
                textBox4.Text = word.Mean;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox3.Text)) return;
            var ds = listBox1.Items.Cast<NewWord>().Where(s => s.Word.Contains(textBox3.Text));
            if (ds.Count() <= 0) return;
            listBox1.SelectedItem = ds.First();
        }
    }
}
