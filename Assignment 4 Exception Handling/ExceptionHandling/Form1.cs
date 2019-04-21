using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            // Set a var of number that will hold input of number.
            int number;

            // Try Catch thing to catch and exceptions that might be thrown so the program dosent crash.
            try
            {
                // Convert input string in to an integer
                number = Convert.ToInt32(intInput.Text);
                // Reset input feild to empty string
                intInput.Text = "";
                // output success and reply with number.
                output.Text = "You successfully entered an interger!\nYou're interger was " + number + ".";

            }
            // Catch exception incase of invalid input string
            catch(FormatException format)
            {
                // Out put what was wrong.
                output.Text = format.Message;
            }
        }
    }
}
