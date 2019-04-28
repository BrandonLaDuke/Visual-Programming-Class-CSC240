using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_Night
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code from week 1. If not the same it's at least similar.
            string word;
            string pigLatinVersion;
            word = inputWord.Text;
            pigLatinVersion = word.Substring(1, word.Length - 1) + word.Substring(0, 1) + "ay";
            outputLabel.Text = String.Format("The pig latin version is {0}", pigLatinVersion);

        }

        private void dayBtn_Click(object sender, EventArgs e)
        {
            // Change color of elements. this refers to background of form.
            title.ForeColor = Color.Black;
            label.ForeColor = Color.Black;
            inputWord.ForeColor = Color.Black;
            inputWord.BackColor = ColorTranslator.FromHtml("#dddddd");
            outputLabel.ForeColor = Color.Black;
            this.BackColor = Color.Yellow;
        }

        private void nightBtn_Click(object sender, EventArgs e)
        {
            //same as day btn but changes them in the other direction.
            title.ForeColor = Color.White;
            label.ForeColor = Color.White;
            inputWord.ForeColor = Color.LightBlue;
            inputWord.BackColor = ColorTranslator.FromHtml("#222222");
            outputLabel.ForeColor = Color.White;
            this.BackColor = Color.DarkBlue;
        }
    }
}
