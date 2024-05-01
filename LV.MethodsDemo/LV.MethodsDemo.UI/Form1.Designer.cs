namespace LV.MethodsDemo.UI
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(78, 87);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(159, 49);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(78, 142);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(159, 49);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(362, 82);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(231, 64);
            this.pnl1.TabIndex = 1;
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(362, 170);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(231, 64);
            this.pnl2.TabIndex = 2;
            // 
            // pnl3
            // 
            this.pnl3.Location = new System.Drawing.Point(362, 254);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(231, 64);
            this.pnl3.TabIndex = 3;
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(78, 197);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(159, 49);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(78, 252);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(159, 49);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(131, 421);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(182, 29);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(375, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 53);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 547);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;
    }
}

