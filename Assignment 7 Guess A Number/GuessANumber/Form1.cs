using System;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class Form1 : Form
    {
        Random ranNumberGenerator = new Random();
        int randomNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = ranNumberGenerator.Next(1, 5);
            radioButton6.Checked = true;
            label1.Text = "Pick a number. \nSee if you can win!"; //Bug fix new line \n oes not work in design mode.
            emptyLabel2.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (randomNumber == 1)
                {
                    emptyLabel2.Text = "You win!!";
                } else
                {
                    emptyLabel2.Text = "Sorry - You Loose...";
                }
                radioButton1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (randomNumber == 2)
                {
                    emptyLabel2.Text = "You win!!";
                }
                else
                {
                    emptyLabel2.Text = "Sorry - You Loose...";
                }
                radioButton1.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (randomNumber == 3)
                {
                    emptyLabel2.Text = "You win!!";
                }
                else
                {
                    emptyLabel2.Text = "Sorry - You Loose...";
                }
                radioButton1.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (randomNumber == 4)
                {
                    emptyLabel2.Text = "You win!!";
                }
                else
                {
                    emptyLabel2.Text = "Sorry - You Loose...";
                }
                radioButton1.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (randomNumber == 5)
                {
                    emptyLabel2.Text = "You win!!";
                }
                else
                {
                    emptyLabel2.Text = "Sorry - You Loose...";
                }
                radioButton1.Enabled = false;
            }
        }

        private void hint_Click(object sender, EventArgs e)
        {
            if (randomNumber == 1)
            {
                hintText.Text = "It's not 3";
            } else
            {
                hintText.Text = "It's not " + (randomNumber - 1);
            }
        }
    }
}
