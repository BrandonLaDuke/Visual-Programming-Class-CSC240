using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Create vars
            string inputWord; 
            string opPigLatinT;
            
            // Set inputWord to value of the text box
            inputWord = normalWord.Text;

            //Create an output that reformats the word input using substring to piglatin
            opPigLatinT = inputWord.Substring(1, inputWord.Length - 1) + inputWord.Substring(0, 1) + "ay";

            //Output PigLatin Text
            outputPigLatin.Text = String.Format("The Pig Latin version is: {0}", opPigLatinT);
        }
    }
}
