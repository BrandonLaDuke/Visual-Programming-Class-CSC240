namespace FiveColors
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
            this.redBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.purpleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(112, 67);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(75, 23);
            this.redBtn.TabIndex = 0;
            this.redBtn.Text = "Red";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // blueBtn
            // 
            this.blueBtn.Location = new System.Drawing.Point(237, 66);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(75, 23);
            this.blueBtn.TabIndex = 1;
            this.blueBtn.Text = "Blue";
            this.blueBtn.UseVisualStyleBackColor = true;
            this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
            // 
            // yellowBtn
            // 
            this.yellowBtn.Location = new System.Drawing.Point(489, 66);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(75, 23);
            this.yellowBtn.TabIndex = 3;
            this.yellowBtn.Text = "Yellow";
            this.yellowBtn.UseVisualStyleBackColor = true;
            this.yellowBtn.Click += new System.EventHandler(this.yellowBtn_Click);
            // 
            // greenBtn
            // 
            this.greenBtn.Location = new System.Drawing.Point(364, 67);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(75, 23);
            this.greenBtn.TabIndex = 2;
            this.greenBtn.Text = "Green";
            this.greenBtn.UseVisualStyleBackColor = true;
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // purpleBtn
            // 
            this.purpleBtn.Location = new System.Drawing.Point(608, 67);
            this.purpleBtn.Name = "purpleBtn";
            this.purpleBtn.Size = new System.Drawing.Size(75, 23);
            this.purpleBtn.TabIndex = 4;
            this.purpleBtn.Text = "Purple";
            this.purpleBtn.UseVisualStyleBackColor = true;
            this.purpleBtn.Click += new System.EventHandler(this.purpleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purpleBtn);
            this.Controls.Add(this.yellowBtn);
            this.Controls.Add(this.greenBtn);
            this.Controls.Add(this.blueBtn);
            this.Controls.Add(this.redBtn);
            this.Name = "Form1";
            this.Text = "Five Colors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Button yellowBtn;
        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Button purpleBtn;
    }
}

