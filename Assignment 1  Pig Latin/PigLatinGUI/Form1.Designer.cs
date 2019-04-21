namespace PigLatinGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.normalWord = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.outputPigLatin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a word:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // normalWord
            // 
            this.normalWord.Location = new System.Drawing.Point(132, 51);
            this.normalWord.Name = "normalWord";
            this.normalWord.Size = new System.Drawing.Size(141, 20);
            this.normalWord.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(132, 91);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(141, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert to Pig Latin";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // outputPigLatin
            // 
            this.outputPigLatin.AutoSize = true;
            this.outputPigLatin.Location = new System.Drawing.Point(12, 131);
            this.outputPigLatin.Name = "outputPigLatin";
            this.outputPigLatin.Size = new System.Drawing.Size(118, 13);
            this.outputPigLatin.TabIndex = 3;
            this.outputPigLatin.Text = "The pig latin version is: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 223);
            this.Controls.Add(this.outputPigLatin);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.normalWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pig Latin GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox normalWord;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label outputPigLatin;
    }
}

