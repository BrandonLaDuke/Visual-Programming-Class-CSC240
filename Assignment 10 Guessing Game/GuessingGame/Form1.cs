using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        int[] ran = new int[10];
        const int MAX_ATTEMPTS = 10;
        int count = 0;
        int correct = 0;
        char myChoice;
        char randomChoice;
        const string FILENAME = @"HighScore.txt";
        static FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
        
        string recordIn;
        int prevHigh;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            const int MAX = 3;
            int x;
            for (x = 0; x < MAX_ATTEMPTS; ++x)
            {
                ran[x] = random.Next(MAX);
                myChoiceLabel.Text += " " + ran[x];
            }
            recordIn = reader.ReadLine();
            prevHigh = Convert.ToInt32(recordIn);
            prevHighLabel.Text += "" + prevHigh;
            reader.Close();
            inFile.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ran[count] == 0)
            {
                randomChoice = 'A';
            }
            if (ran[count] == 1)
            {
                randomChoice = 'B';
            }
            if (ran[count] == 2)
            {
                randomChoice = 'C';
            }
            
            if (radioButton1.Checked.Equals(true))
            {
                myChoice = 'A';
            } else if (radioButton2.Checked.Equals(true))
            {
                myChoice = 'B';
            } else if (radioButton3.Checked.Equals(true))
            {
                myChoice = 'C';
            } else
            {
                //log error?do nothing?
            }
            if (myChoice == randomChoice)
            {
                correct = correct + 1;
            }
            myChoiceLabel.Text = "My choice was " + myChoice;
            randomChoiceLabel.Text = "Random choice was " + randomChoice;
            ++count;
            scoreLabel.Text = "Score is " + correct + " out of " + count;
            if (count == MAX_ATTEMPTS)
            {
                if (prevHigh < correct)
                {
                    FileStream outFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(outFile);
                    writer.WriteLine("" + correct); //Writing to file???
                    writer.Close();
                    outFile.Close();
                }
                button1.Enabled = false;
                prevHighScore.Text = "Congrats you beat the high score of " + prevHigh + " with a score of " + correct + "!";
            }
        }
    }
}
