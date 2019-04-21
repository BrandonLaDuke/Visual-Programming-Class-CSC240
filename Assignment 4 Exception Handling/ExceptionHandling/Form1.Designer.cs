namespace ExceptionHandling
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
            this.intInput = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an interger";
            // 
            // intInput
            // 
            this.intInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intInput.Location = new System.Drawing.Point(173, 26);
            this.intInput.Name = "intInput";
            this.intInput.Size = new System.Drawing.Size(279, 29);
            this.intInput.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.DarkTurquoise;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.Black;
            this.confirm.Location = new System.Drawing.Point(17, 58);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(435, 30);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Okay";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.BackColor = System.Drawing.SystemColors.WindowText;
            this.output.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(12, 101);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 26);
            this.output.TabIndex = 3;
            this.output.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(503, 161);
            this.Controls.Add(this.output);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.intInput);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Exception Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intInput;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label output;
    }
}

