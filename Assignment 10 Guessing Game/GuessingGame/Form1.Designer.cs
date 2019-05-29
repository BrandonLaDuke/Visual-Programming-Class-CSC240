namespace GuessingGame
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.myChoiceLabel = new System.Windows.Forms.Label();
            this.randomChoiceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.prevHighLabel = new System.Windows.Forms.Label();
            this.prevHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make a guess: A, B or C";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 100);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(34, 123);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // myChoiceLabel
            // 
            this.myChoiceLabel.AutoSize = true;
            this.myChoiceLabel.Location = new System.Drawing.Point(152, 89);
            this.myChoiceLabel.Name = "myChoiceLabel";
            this.myChoiceLabel.Size = new System.Drawing.Size(35, 13);
            this.myChoiceLabel.TabIndex = 4;
            this.myChoiceLabel.Text = "label2";
            // 
            // randomChoiceLabel
            // 
            this.randomChoiceLabel.AutoSize = true;
            this.randomChoiceLabel.Location = new System.Drawing.Point(152, 109);
            this.randomChoiceLabel.Name = "randomChoiceLabel";
            this.randomChoiceLabel.Size = new System.Drawing.Size(35, 13);
            this.randomChoiceLabel.TabIndex = 5;
            this.randomChoiceLabel.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit guess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(152, 192);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score";
            // 
            // prevHighLabel
            // 
            this.prevHighLabel.AutoSize = true;
            this.prevHighLabel.Location = new System.Drawing.Point(54, 239);
            this.prevHighLabel.Name = "prevHighLabel";
            this.prevHighLabel.Size = new System.Drawing.Size(120, 13);
            this.prevHighLabel.TabIndex = 8;
            this.prevHighLabel.Text = "Previous High Score is: ";
            // 
            // prevHighScore
            // 
            this.prevHighScore.AutoSize = true;
            this.prevHighScore.Location = new System.Drawing.Point(66, 274);
            this.prevHighScore.Name = "prevHighScore";
            this.prevHighScore.Size = new System.Drawing.Size(104, 13);
            this.prevHighScore.TabIndex = 9;
            this.prevHighScore.Text = "Previous High Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prevHighScore);
            this.Controls.Add(this.prevHighLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.randomChoiceLabel);
            this.Controls.Add(this.myChoiceLabel);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label myChoiceLabel;
        private System.Windows.Forms.Label randomChoiceLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label prevHighLabel;
        private System.Windows.Forms.Label prevHighScore;
    }
}

