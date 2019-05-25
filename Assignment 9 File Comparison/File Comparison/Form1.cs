using System;
using System.IO;
using System.Windows.Forms;

namespace File_Comparison
{
    public partial class Form1 : Form
    {
        long fileSize1, fileSize2;
        FileInfo fileInfo1, fileInfo2;
        string fileName1, fileName2;
        string ratio;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName2 = openFileDialog2.FileName;
                label4.Text = label4.Text + fileName2;
                fileInfo2 = new FileInfo(fileName2);
                fileSize2 = fileInfo2.Length;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "File 1 Size: " + fileSize1;
            label2.Text = "File 2 Size: " + fileSize2;
            var gcd = GCD(fileSize1, fileSize2);
            ratio = "Ratio: " + string.Format("{0}:{1}", fileSize1 / gcd, fileSize2 / gcd);
            label5.Text = Convert.ToString(ratio);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }
        private static long GCD(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName1 = openFileDialog1.FileName;
                label3.Text = label3.Text + fileName1;
                fileInfo1 = new FileInfo(fileName1);
                fileSize1 = fileInfo1.Length;
            }
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
