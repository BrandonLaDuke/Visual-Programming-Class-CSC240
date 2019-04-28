namespace Day_Night
{
    partial class mainForm
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
            this.dayBtn = new System.Windows.Forms.Button();
            this.nightBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.inputWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayBtn
            // 
            this.dayBtn.Location = new System.Drawing.Point(413, 32);
            this.dayBtn.Name = "dayBtn";
            this.dayBtn.Size = new System.Drawing.Size(75, 23);
            this.dayBtn.TabIndex = 0;
            this.dayBtn.Text = "Day";
            this.dayBtn.UseVisualStyleBackColor = true;
            this.dayBtn.Click += new System.EventHandler(this.dayBtn_Click);
            // 
            // nightBtn
            // 
            this.nightBtn.Location = new System.Drawing.Point(413, 61);
            this.nightBtn.Name = "nightBtn";
            this.nightBtn.Size = new System.Drawing.Size(75, 23);
            this.nightBtn.TabIndex = 1;
            this.nightBtn.Text = "Night";
            this.nightBtn.UseVisualStyleBackColor = true;
            this.nightBtn.Click += new System.EventHandler(this.nightBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(39, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(179, 25);
            this.title.TabIndex = 2;
            this.title.Text = "Pig Latin Generator";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(40, 78);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 17);
            this.label.TabIndex = 58;
            this.label.Text = "Enter text >>";
            // 
            // inputWord
            // 
            this.inputWord.Location = new System.Drawing.Point(152, 77);
            this.inputWord.Name = "inputWord";
            this.inputWord.Size = new System.Drawing.Size(171, 20);
            this.inputWord.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(41, 116);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 17);
            this.outputLabel.TabIndex = 61;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 386);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputWord);
            this.Controls.Add(this.label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.nightBtn);
            this.Controls.Add(this.dayBtn);
            this.Name = "mainForm";
            this.Text = "Day Night";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dayBtn;
        private System.Windows.Forms.Button nightBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox inputWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputLabel;
    }
}

