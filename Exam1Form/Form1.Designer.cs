namespace Exam1Volkova
{
    partial class Form
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
            this.lblFVTC = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# is Fun!";
            // 
            // lblFVTC
            // 
            this.lblFVTC.AutoSize = true;
            this.lblFVTC.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFVTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFVTC.Location = new System.Drawing.Point(101, 163);
            this.lblFVTC.Name = "lblFVTC";
            this.lblFVTC.Size = new System.Drawing.Size(294, 24);
            this.lblFVTC.TabIndex = 1;
            this.lblFVTC.Text = "Fox Valley Technical College";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.Navy;
            this.btnDisplay.Location = new System.Drawing.Point(69, 235);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(105, 34);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(185, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(312, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(472, 339);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblFVTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form";
            this.Text = "Intro to C# ~ Exercise 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFVTC;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

