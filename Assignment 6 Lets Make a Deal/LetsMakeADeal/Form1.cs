using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsMakeADeal
{
    public partial class Form1 : Form
    {
        //declair a random function, and a function
        Random RandomClass = new Random();
        int rand, door1, door2, door3, selectedDoor;
        string[] prize = { "new car", "big-Screen TV", "Live Goat" }; // COntains the array of prizes.
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            btn1.ForeColor = Color.White;
            btn1.BackColor = Color.Black;
            btn2.ForeColor = Color.White;
            btn2.BackColor = Color.Black;
            btn3.ForeColor = Color.White;
            btn3.BackColor = Color.Black;
            btnYes.ForeColor = Color.White;
            btnYes.BackColor = Color.Black;
            btnNo.ForeColor = Color.White;
            btnNo.BackColor = Color.Black;
            infoLabel.ForeColor = Color.White;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rand = RandomClass.Next(0, 2); //Generates random number 0, 1
            door1 = RandomClass.Next(0, 3);
            door2 = RandomClass.Next(0, 3);
            while (door1 == door2)
            {
                door2 = RandomClass.Next(0, 3);
            }
            if (door1 + door2 ==1)
            {
                door3 = 2;
            } else if (door1 + door2 == 1)
            {
                door3 = 1;
            } else
            {
                door3 = 0;
            }
            infoLabel.Text = "Door 1 is " + door1 + ", Door 2 is " + door2 + ", Door 3 is " + door3 + ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            selectedDoor = 0;
            DisableButtons();
            outputLabel.Text = "You chose Door 1";
            if (door1 == 0)
            {
                if (rand == 0)
                {
                    outputLabel.Text += "\nDoor 2 Had a " + prize[door2];
                }
                else
                {
                    outputLabel.Text += "\nDoor 3 Had a " + prize[door3];
                }
            } else
            {
                if (door2 == 0)
                {
                    outputLabel.Text += "\nDoor3 had a " + prize[door3];
                    rand = 1;
                } else
                {
                    outputLabel.Text += "\nDoor 2 had a " + prize[door2];
                    rand = 0;
                }
            }
            outputLabel.Text += "\nDo you want to switch your selection?";
            btnYes.Visible = true;
            btnNo.Visible = true;
        }
        private void btn2_Click_1(object sender, EventArgs e)
        {
            selectedDoor = 0;
            DisableButtons();
            outputLabel.Text = "You chose Door 2";
            if (door2 == 0)
            {
                if (rand == 0)
                {
                    outputLabel.Text += "\nDoor 1 Had a " + prize[door1];
                }
                else
                {
                    outputLabel.Text += "\nDoor 3 Had a " + prize[door3];
                }
            }
            else
            {
                if (door1 == 0)
                {
                    outputLabel.Text += "\nDoor3 had a " + prize[door3];
                    rand = 1;
                }
                else
                {
                    outputLabel.Text += "\nDoor 1 had a " + prize[door1];
                    rand = 0;
                }
            }
            outputLabel.Text += "\nDo you want to switch your selection?";
            btnYes.Visible = true;
            btnNo.Visible = true;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            selectedDoor = 0;
            DisableButtons();
            outputLabel.Text = "You chose Door 3";
            if (door3 == 0)
            {
                if (rand == 0)
                {
                    outputLabel.Text += "\nDoor 1 Had a " + prize[door1];
                }
                else
                {
                    outputLabel.Text += "\nDoor 2 Had a " + prize[door2];
                }
            }
            else
            {
                if (door1 == 0)
                {
                    outputLabel.Text += "\nDoor2 had a " + prize[door2];
                    rand = 1;
                }
                else
                {
                    outputLabel.Text += "\nDoor 1 had a " + prize[door1];
                    rand = 0;
                }
            }
            outputLabel.Text += "\nDo you want to switch your selection?";
            btnYes.Visible = true;
            btnNo.Visible = true;
        }
        private void btnYes_Click_1(object sender, EventArgs e)
        {
            if (selectedDoor == 0)
            {
                if (rand == 0)
                {
                    selectedDoor = 1;
                } else
                {
                    selectedDoor = 2;
                }
            } else
            {
                if (selectedDoor == 1)
                {
                    if (rand == 0)
                    {
                        selectedDoor = 2;
                    } else
                    {
                        selectedDoor = 0;
                    }
                } else
                {
                    if (rand == 0)
                    {
                        selectedDoor = 1;
                    } else
                    {
                        selectedDoor = 0;
                    }
                }
            }
            RevealPrize();
        }
        private void btnNo_Click_1(object sender, EventArgs e)
        {
            RevealPrize();
        }
        private void RevealPrize()
        {
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            if (selectedDoor == 0)
            {
                prizeLabel.Text = "You won a " + prize[door1];
            } else if (selectedDoor == 1)
            {
                prizeLabel.Text = "You wan a " + prize[door2];
            } else
            {
                prizeLabel.Text = "You won a " + prize[door3];
            }
        }
        private void DisableButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
        }

    }
}
